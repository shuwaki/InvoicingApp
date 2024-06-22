using Microsoft.VisualBasic;
using System.Drawing.Printing;
using System.Runtime;
using System.Transactions;
using System.Windows.Forms;

namespace LifelineGlobalInvoicingApp
{
    public partial class Homepage : Form
    {
        Invoice Invoice { get; set; }
        bool newpage = true;
        int mPageNumber = 1;
        int serialno = 1;
        public Homepage()
        {
            InitializeComponent();
            CompanyNameLabel.Text = CompanyInfo.CompanyName;
            CompanyAddressLabel.Text = CompanyInfo.CompanyAddress;
            CompanyPhoneLabel.Text = CompanyInfo.CompanyPhone;
            PaymentInfoTextBox.Lines = CompanyInfo.PaymentInfo;
            ServicesTextBox.Lines = CompanyInfo.Services;
            Invoice = new(new(""));
            ItemsDataGridView.DataSource = Invoice.Items;
            ItemsDataGridView.Columns[1].FillWeight = 200;
            ItemsDataGridView.Columns[0].FillWeight = 50;

            CustomerNameTextBox.DataBindings.Add("Text", Invoice.Customer, "Name");
            CustomerPhoneTextBox.DataBindings.Add("Text", Invoice.Customer, "Phone");
            CustomerAddressTextBox.DataBindings.Add("Text", Invoice.Customer, "Address");
            InvoiceNumberTextBox.DataBindings.Add("Text", Invoice, "InvoiceNumber");
            InvoiceDateTimePicker.DataBindings.Add("Value", Invoice, "InvoiceDate");
            InvoiceDueDateTextBox.DataBindings.Add("Text", Invoice, "DueDate");
            SubtotalTextBox.DataBindings.Add("Text", Invoice, "Subtotal");
            DiscountTextBox.DataBindings.Add("Text", Invoice, "Discount");
            TotalTextBox.DataBindings.Add("Text", Invoice, "Total");

            if (File.Exists("invoiceNumber.txt"))
            {
                string fileContent = File.ReadAllText("invoiceNumber.txt");
                if (int.TryParse(fileContent, out int s))
                    Invoice.SetNumber(s);
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //if companyinfo has changed, update
        }

        private void AddLineutton_Click(object sender, EventArgs e)
        {
            Invoice.Items.Add(new(""));
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            var defaultFont = new Font("calibri", 8);
            var defaultFontBold = new Font("calibri", 8, FontStyle.Bold);
            var companyNameFont = new Font("Showcard Gothic", 10, FontStyle.Regular);
            var headerFont = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
            var titleFont = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            var statusFont = new Font("Rockwell Extra Bold", 16, FontStyle.Bold);
            Margins xx = new(30, 30, 30, 30);
            int paperwidth = PrintDocument1.DefaultPageSettings.PaperSize.Width;

            using var f = new Font("arial", 8f);
            e.Graphics?.DrawString(mPageNumber.ToString(), f, Brushes.Black, 0f, 0f);

            int usablewidth = paperwidth - xx.Left - xx.Right;
            var fmt = new StringFormat(StringFormatFlags.LineLimit)
            {
                LineAlignment = StringAlignment.Center,
                Trimming = StringTrimming.EllipsisCharacter
            };
            int y = xx.Top;
            Rectangle rc0, rc1, rc2, rc3, rc4;
            int x, h;
            var brush = new SolidBrush(Color.FromArgb(120, 198, 220));
            var pen = new Pen(brush);
            if (mPageNumber == 1)
            {
                e.Graphics?.FillRectangle(brush, new Rectangle(xx.Left, xx.Top, usablewidth, 10));
                y += 10;
                e.Graphics?.FillRectangle(Brushes.LightGray, new Rectangle(xx.Left, y, usablewidth, 65));
                string[] invoicedetails = ["Invoice Number: " + Invoice.InvoiceNumber.ToString(), "Invoice Date: " + Invoice.InvoiceDate.ToString("G"), "Due Date: " + Invoice.DueDate];

                string?[] customerdetails = ["Name: " + Invoice.Customer.Name, "Address: " + Invoice.Customer.Address, "Phone: " + Invoice.Customer.Phone];


                if (!string.IsNullOrWhiteSpace(CompanyInfo.CompanyName))
                {
                    e.Graphics?.DrawString(CompanyInfo.CompanyName, companyNameFont, Brushes.SteelBlue, xx.Left + 3, y);
                    y += TextRenderer.MeasureText(CompanyInfo.CompanyName, companyNameFont).Height;
                }
                if (!string.IsNullOrWhiteSpace(CompanyInfo.CompanyAddress))
                {
                    e.Graphics?.DrawString(CompanyInfo.CompanyAddress, headerFont, Brushes.Black, (usablewidth - TextRenderer.MeasureText(CompanyInfo.CompanyAddress, headerFont).Width), y);
                    y += TextRenderer.MeasureText(CompanyInfo.CompanyAddress, headerFont).Height;
                }
                if (!string.IsNullOrWhiteSpace(CompanyInfo.CompanyPhone))
                {
                    e.Graphics?.DrawString(CompanyInfo.CompanyPhone, headerFont, Brushes.Black, (usablewidth - TextRenderer.MeasureText(CompanyInfo.CompanyAddress, headerFont).Width), y);
                    y += TextRenderer.MeasureText(CompanyInfo.CompanyPhone, headerFont).Height;
                }
                if (!string.IsNullOrWhiteSpace(CompanyInfo.CompanyEmail))
                {
                    e.Graphics?.DrawString(CompanyInfo.CompanyEmail, defaultFont, Brushes.Black, (usablewidth - TextRenderer.MeasureText(CompanyInfo.CompanyAddress, headerFont).Width), y);
                    y += TextRenderer.MeasureText(CompanyInfo.CompanyEmail, defaultFont).Height;
                }

                y += 20;
                int setPoint = y;
                e.Graphics?.DrawString("BILL TO", defaultFontBold, Brushes.Black, (20 + xx.Left), y);
                e.Graphics?.DrawLine(new(Brushes.Black), new((20 + xx.Left), y + TextRenderer.MeasureText("BILL TO", defaultFontBold).Height), new((220 + xx.Left), y + TextRenderer.MeasureText("BILL TO", defaultFontBold).Height));
                y += TextRenderer.MeasureText("BILL TO", defaultFontBold).Height;
                for (int i = 0; i < customerdetails.Length; i++)
                {
                    e.Graphics?.DrawString(customerdetails[i], defaultFont, Brushes.Black, (float)(20 + xx.Left), y);
                    y += TextRenderer.MeasureText(customerdetails[i], defaultFont).Height;
                }

                y = setPoint;
                e.Graphics?.DrawString("INVOICE DETAILS", defaultFontBold, Brushes.Black, (usablewidth / 2) + 50, y);
                e.Graphics?.DrawLine(new(Brushes.Black), new((usablewidth / 2) + 50, y + TextRenderer.MeasureText("INVOICE DETAILS", defaultFontBold).Height), new((usablewidth / 2) + 200, y + TextRenderer.MeasureText("INVOICE DETAILS", defaultFontBold).Height));
                y += TextRenderer.MeasureText("INVOICE DETAILS", defaultFontBold).Height;

                for (int i = 0; i < invoicedetails.Length; i++)
                {
                    e.Graphics?.DrawString(invoicedetails[i], defaultFont, Brushes.Black, (usablewidth / 2) + 50, y);
                    y += TextRenderer.MeasureText(invoicedetails[i], defaultFont).Height;
                }

                y += 20;
            }
            else
            {
                y = xx.Top;
            }
            mPageNumber += 1;

            if (newpage)
            {
                x = xx.Left;

                for (int i = 0; i <= 4; i++)
                {

                    fmt.Alignment = StringAlignment.Near;

                    rc0 = new Rectangle(x, y, 40, 20);
                    rc1 = new Rectangle(x, y, usablewidth - 230, 20);
                    rc2 = new Rectangle(x, y, 70, 20);
                    rc3 = new Rectangle(x, y, 60, 20);
                    rc4 = new Rectangle(x, y, 60, 20);

                    switch (i)
                    {
                        case 0:
                            x += rc0.Width;
                            e.Graphics?.FillRectangle(brush, rc0);
                            e.Graphics?.DrawRectangle(pen, rc0);
                            e.Graphics?.DrawString("S/No", defaultFont, Brushes.White, rc0, fmt);
                            break;

                        case 1:
                            x += rc1.Width;
                            e.Graphics?.FillRectangle(brush, rc1);
                            e.Graphics?.DrawRectangle(pen, rc1);
                            e.Graphics?.DrawString("Description", defaultFont, Brushes.White, rc1, fmt);
                            break;

                        case 2:
                            x += rc2.Width;
                            e.Graphics?.FillRectangle(brush, rc2);
                            e.Graphics?.DrawRectangle(pen, rc2);
                            e.Graphics?.DrawString("Rate", defaultFont, Brushes.White, rc2, fmt);
                            break;

                        case 3:
                            x += rc3.Width;
                            e.Graphics?.FillRectangle(brush, rc3);
                            e.Graphics?.DrawRectangle(pen, rc3);
                            e.Graphics?.DrawString("Quantity", defaultFont, Brushes.White, rc3, fmt);
                            break;

                        case 4:
                            x += rc4.Width;
                            e.Graphics?.FillRectangle(brush, rc4);
                            e.Graphics?.DrawRectangle(pen, rc4);
                            e.Graphics?.DrawString("Total", defaultFont, Brushes.White, rc4, fmt);
                            break;

                    }

                }
                y += 20;

            }
            newpage = false;

            for (int j = serialno - 1, loopTo3 = Invoice.Items.Count - 1; j <= loopTo3; j++)
            {
                x = xx.Left;
                h = 0;

                for (int i = 0; i <= 4; i++)
                {
                    rc0 = new Rectangle(x, y, 40, 20);
                    rc1 = new Rectangle(x, y, usablewidth - 230, 20);
                    rc2 = new Rectangle(x, y, 70, 20);
                    rc3 = new Rectangle(x, y, 60, 20);
                    rc4 = new Rectangle(x, y, 60, 20);

                    switch (i)
                    {
                        case 0:
                            x += rc0.Width;
                            e.Graphics?.DrawRectangle(Pens.Black, rc0);
                            e.Graphics?.DrawString(serialno.ToString(), defaultFont, Brushes.Black, rc0, fmt);
                            break;

                        case 1:
                            x += rc1.Width;
                            e.Graphics?.DrawRectangle(Pens.Black, rc1);
                            e.Graphics?.DrawString(Invoice.Items[j].Description, defaultFont, Brushes.Black, rc1, fmt);
                            break;

                        case 2:
                            x += rc2.Width;
                            e.Graphics?.DrawRectangle(Pens.Black, rc2);
                            e.Graphics?.DrawString(Invoice.Items[j].Rate.ToString("N2"), defaultFont, Brushes.Black, rc2, fmt);
                            break;

                        case 3:
                            x += rc3.Width;
                            e.Graphics?.DrawRectangle(Pens.Black, rc3);
                            e.Graphics?.DrawString(Invoice.Items[j].Quantity.ToString(), defaultFont, Brushes.Black, rc3, fmt);
                            break;

                        case 4:
                            x += rc4.Width;
                            e.Graphics?.DrawRectangle(Pens.Black, rc4);
                            e.Graphics?.DrawString(Invoice.Items[j].Total.ToString("N2"), defaultFont, Brushes.Black, rc4, fmt);
                            break;

                    }

                    h = 20;
                }
                serialno += 1;

                fmt.Alignment = StringAlignment.Near;
                y += h;

                if (y + h > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    newpage = true;
                    return;
                }
            }

            y += 10;
            var secondPoint = y;
            string[] summary = ["Subtotal: " + Invoice.Subtotal.ToString("N2"), "Discount: " + Invoice.Discount.ToString("N2"), "Total: " + Invoice.Total.ToString("N2")];
            for (int i = 0; i < summary.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(summary[i]) && summary[i] != 0.ToString("N2"))
                {
                    e.Graphics?.DrawString(summary[i], defaultFontBold, Brushes.Black, (usablewidth - TextRenderer.MeasureText(summary[i], defaultFontBold).Width), y);
                    y += TextRenderer.MeasureText(summary[i], defaultFontBold).Height;
                }
            }

            y = secondPoint;
            string[] paymentDetails = PaymentInfoTextBox.Lines;
            e.Graphics?.DrawString("PAYMENT INFO", defaultFontBold, Brushes.Black, xx.Left + 3, y);
            y += TextRenderer.MeasureText("PAYMENT INFO", defaultFontBold).Height;
            for (int i = 0; i < paymentDetails.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(paymentDetails[i]) && paymentDetails[i] != 0.ToString("N2"))
                {
                    e.Graphics?.DrawString(paymentDetails[i], defaultFont, Brushes.Black, xx.Left + 3, y);
                    y += TextRenderer.MeasureText(paymentDetails[i], defaultFont).Height;
                }
            }

            y += 10;
            string[] services = ServicesTextBox.Lines;
            e.Graphics?.DrawString("SERVICES", defaultFontBold, Brushes.Black, xx.Left + 3, y);
            y += TextRenderer.MeasureText("SERVICES", defaultFontBold).Height;
            for (int i = 0; i < services.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(services[i]) && services[i] != 0.ToString("N2"))
                {
                    e.Graphics?.DrawString(services[i], defaultFont, Brushes.Black, xx.Left + 3, y);
                    y += TextRenderer.MeasureText(services[i], defaultFont).Height;
                }
            }
            e.Graphics?.FillRectangle(brush, new Rectangle(xx.Left, y, usablewidth, 10));
        }

        private void PrintDocument1_BeginPrint(object sender, PrintEventArgs e)
        {
            newpage = true;
            mPageNumber = 1;
            serialno = 1;
        }

        public void Print()
        {
            PrintDialog1 = new PrintDialog
            {
                AllowSomePages = true,
                Document = PrintDocument1,
                UseEXDialog = true
            };

            var x = PrintDialog1.ShowDialog();
            if (x == DialogResult.OK)
                PrintDocument1.Print();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void PrintDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            string filePath = "invoiceNumber.txt";
            File.WriteAllText(filePath, Invoice.RaiseNumber().ToString());
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            PrintDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            PrintDocument1.Print();
        }

        private void ItemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var x = (InvoiceLine)ItemsDataGridView.Rows[e.RowIndex].DataBoundItem;
                Invoice.Items.Remove(x);
            }
        }
    }
}
