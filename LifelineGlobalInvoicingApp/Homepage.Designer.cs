namespace LifelineGlobalInvoicingApp
{
    partial class Homepage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            PrintButton = new Button();
            ExportButton = new Button();
            panel3 = new Panel();
            CompanyEmailTextBox = new TextBox();
            CompanyAddressTextBox = new TextBox();
            CompanyPhoneTextBox = new TextBox();
            CompanyNameTextBox = new TextBox();
            panel4 = new Panel();
            label19 = new Label();
            label18 = new Label();
            label7 = new Label();
            label17 = new Label();
            InvoiceNumberTextBox = new TextBox();
            label16 = new Label();
            label15 = new Label();
            InvoiceDateTimePicker = new DateTimePicker();
            label4 = new Label();
            InvoiceDueDateTextBox = new TextBox();
            label3 = new Label();
            CustomerPhoneTextBox = new TextBox();
            CustomerAddressTextBox = new TextBox();
            CustomerNameTextBox = new TextBox();
            ItemsDataGridView = new DataGridView();
            RemoveColumn = new DataGridViewButtonColumn();
            panel5 = new Panel();
            label5 = new Label();
            PaymentInfoTextBox = new TextBox();
            panel6 = new Panel();
            label6 = new Label();
            ServicesTextBox = new TextBox();
            panel7 = new Panel();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            TotalTextBox = new TextBox();
            SubtotalTextBox = new TextBox();
            DiscountTextBox = new TextBox();
            AddLineutton = new Button();
            InvoicesContextMenuStrip = new ContextMenuStrip(components);
            PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            PrintDialog1 = new PrintDialog();
            PrintPreviewDialog1 = new PrintPreviewDialog();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsDataGridView).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 0);
            tableLayoutPanel1.Margin = new Padding(10, 3, 10, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(614, 681);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 8);
            tableLayoutPanel2.Controls.Add(PrintButton, 1, 7);
            tableLayoutPanel2.Controls.Add(ExportButton, 2, 7);
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Controls.Add(panel4, 0, 2);
            tableLayoutPanel2.Controls.Add(ItemsDataGridView, 0, 3);
            tableLayoutPanel2.Controls.Add(panel5, 0, 5);
            tableLayoutPanel2.Controls.Add(panel6, 0, 6);
            tableLayoutPanel2.Controls.Add(panel7, 2, 4);
            tableLayoutPanel2.Controls.Add(AddLineutton, 0, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 9;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.Size = new Size(608, 675);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            tableLayoutPanel2.SetColumnSpan(panel1, 3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 10);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            tableLayoutPanel2.SetColumnSpan(panel2, 3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 665);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(608, 10);
            panel2.TabIndex = 1;
            // 
            // PrintButton
            // 
            PrintButton.Dock = DockStyle.Fill;
            PrintButton.Location = new Point(185, 632);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(176, 30);
            PrintButton.TabIndex = 2;
            PrintButton.Text = "Print";
            PrintButton.UseVisualStyleBackColor = true;
            PrintButton.Click += PrintButton_Click;
            // 
            // ExportButton
            // 
            ExportButton.Dock = DockStyle.Fill;
            ExportButton.Location = new Point(367, 632);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(238, 30);
            ExportButton.TabIndex = 2;
            ExportButton.Text = "Export PDF";
            ExportButton.UseVisualStyleBackColor = true;
            ExportButton.Click += ExportButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            tableLayoutPanel2.SetColumnSpan(panel3, 3);
            panel3.Controls.Add(CompanyEmailTextBox);
            panel3.Controls.Add(CompanyAddressTextBox);
            panel3.Controls.Add(CompanyPhoneTextBox);
            panel3.Controls.Add(CompanyNameTextBox);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 10);
            panel3.Margin = new Padding(3, 0, 3, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(602, 80);
            panel3.TabIndex = 3;
            // 
            // CompanyEmailTextBox
            // 
            CompanyEmailTextBox.BackColor = Color.Silver;
            CompanyEmailTextBox.BorderStyle = BorderStyle.None;
            CompanyEmailTextBox.Location = new Point(312, 54);
            CompanyEmailTextBox.Name = "CompanyEmailTextBox";
            CompanyEmailTextBox.Size = new Size(287, 16);
            CompanyEmailTextBox.TabIndex = 4;
            // 
            // CompanyAddressTextBox
            // 
            CompanyAddressTextBox.BackColor = Color.Silver;
            CompanyAddressTextBox.BorderStyle = BorderStyle.None;
            CompanyAddressTextBox.Location = new Point(312, 4);
            CompanyAddressTextBox.Name = "CompanyAddressTextBox";
            CompanyAddressTextBox.Size = new Size(287, 16);
            CompanyAddressTextBox.TabIndex = 3;
            // 
            // CompanyPhoneTextBox
            // 
            CompanyPhoneTextBox.BackColor = Color.Silver;
            CompanyPhoneTextBox.BorderStyle = BorderStyle.None;
            CompanyPhoneTextBox.Location = new Point(312, 29);
            CompanyPhoneTextBox.Name = "CompanyPhoneTextBox";
            CompanyPhoneTextBox.Size = new Size(287, 16);
            CompanyPhoneTextBox.TabIndex = 2;
            // 
            // CompanyNameTextBox
            // 
            CompanyNameTextBox.BackColor = Color.Silver;
            CompanyNameTextBox.BorderStyle = BorderStyle.None;
            CompanyNameTextBox.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CompanyNameTextBox.Location = new Point(3, 5);
            CompanyNameTextBox.Name = "CompanyNameTextBox";
            CompanyNameTextBox.Size = new Size(303, 17);
            CompanyNameTextBox.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            tableLayoutPanel2.SetColumnSpan(panel4, 3);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(InvoiceNumberTextBox);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(InvoiceDateTimePicker);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(InvoiceDueDateTextBox);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(CustomerPhoneTextBox);
            panel4.Controls.Add(CustomerAddressTextBox);
            panel4.Controls.Add(CustomerNameTextBox);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 90);
            panel4.Margin = new Padding(3, 0, 3, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(602, 86);
            panel4.TabIndex = 4;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(18, 62);
            label19.Name = "label19";
            label19.Size = new Size(41, 15);
            label19.TabIndex = 15;
            label19.Text = "Phone";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(10, 42);
            label18.Name = "label18";
            label18.Size = new Size(49, 15);
            label18.TabIndex = 14;
            label18.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 21);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 13;
            label7.Text = "Name";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label17.AutoSize = true;
            label17.Location = new Point(357, 21);
            label17.Name = "label17";
            label17.Size = new Size(92, 15);
            label17.TabIndex = 12;
            label17.Text = "Invoice Number";
            // 
            // InvoiceNumberTextBox
            // 
            InvoiceNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InvoiceNumberTextBox.BorderStyle = BorderStyle.None;
            InvoiceNumberTextBox.Font = new Font("Segoe UI", 8.25F);
            InvoiceNumberTextBox.Location = new Point(455, 17);
            InvoiceNumberTextBox.Name = "InvoiceNumberTextBox";
            InvoiceNumberTextBox.Size = new Size(99, 15);
            InvoiceNumberTextBox.TabIndex = 11;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label16.AutoSize = true;
            label16.Location = new Point(391, 62);
            label16.Name = "label16";
            label16.Size = new Size(58, 15);
            label16.TabIndex = 10;
            label16.Text = "Due Date:";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Location = new Point(374, 42);
            label15.Name = "label15";
            label15.Size = new Size(75, 15);
            label15.TabIndex = 9;
            label15.Text = "Invoice Date:";
            // 
            // InvoiceDateTimePicker
            // 
            InvoiceDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InvoiceDateTimePicker.Format = DateTimePickerFormat.Short;
            InvoiceDateTimePicker.Location = new Point(455, 38);
            InvoiceDateTimePicker.Name = "InvoiceDateTimePicker";
            InvoiceDateTimePicker.Size = new Size(99, 23);
            InvoiceDateTimePicker.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(392, 3);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 7;
            label4.Text = "INVOICE DETAILS";
            // 
            // InvoiceDueDateTextBox
            // 
            InvoiceDueDateTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            InvoiceDueDateTextBox.BorderStyle = BorderStyle.None;
            InvoiceDueDateTextBox.Font = new Font("Segoe UI", 8.25F);
            InvoiceDueDateTextBox.Location = new Point(455, 60);
            InvoiceDueDateTextBox.Name = "InvoiceDueDateTextBox";
            InvoiceDueDateTextBox.Size = new Size(99, 15);
            InvoiceDueDateTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(37, 1);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 3;
            label3.Text = "BILL TO";
            // 
            // CustomerPhoneTextBox
            // 
            CustomerPhoneTextBox.Font = new Font("Segoe UI", 8.25F);
            CustomerPhoneTextBox.Location = new Point(65, 59);
            CustomerPhoneTextBox.Name = "CustomerPhoneTextBox";
            CustomerPhoneTextBox.Size = new Size(125, 22);
            CustomerPhoneTextBox.TabIndex = 2;
            // 
            // CustomerAddressTextBox
            // 
            CustomerAddressTextBox.Font = new Font("Segoe UI", 8.25F);
            CustomerAddressTextBox.Location = new Point(65, 38);
            CustomerAddressTextBox.Name = "CustomerAddressTextBox";
            CustomerAddressTextBox.Size = new Size(125, 22);
            CustomerAddressTextBox.TabIndex = 1;
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Font = new Font("Segoe UI", 8.25F);
            CustomerNameTextBox.Location = new Point(65, 17);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(125, 22);
            CustomerNameTextBox.TabIndex = 0;
            // 
            // ItemsDataGridView
            // 
            ItemsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ItemsDataGridView.BackgroundColor = Color.White;
            ItemsDataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Navy;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ItemsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            ItemsDataGridView.Columns.AddRange(new DataGridViewColumn[] { RemoveColumn });
            tableLayoutPanel2.SetColumnSpan(ItemsDataGridView, 3);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            ItemsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            ItemsDataGridView.Dock = DockStyle.Fill;
            ItemsDataGridView.Location = new Point(3, 176);
            ItemsDataGridView.Margin = new Padding(3, 0, 3, 0);
            ItemsDataGridView.Name = "ItemsDataGridView";
            ItemsDataGridView.RowHeadersVisible = false;
            ItemsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ItemsDataGridView.Size = new Size(602, 241);
            ItemsDataGridView.TabIndex = 5;
            ItemsDataGridView.CellContentClick += ItemsDataGridView_CellContentClick;
            // 
            // RemoveColumn
            // 
            RemoveColumn.FillWeight = 50F;
            RemoveColumn.HeaderText = "Remove";
            RemoveColumn.Name = "RemoveColumn";
            RemoveColumn.Text = "Remove";
            RemoveColumn.ToolTipText = "Remove";
            RemoveColumn.UseColumnTextForButtonValue = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            tableLayoutPanel2.SetColumnSpan(panel5, 3);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(PaymentInfoTextBox);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 497);
            panel5.Margin = new Padding(3, 0, 3, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(602, 72);
            panel5.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 1;
            label5.Text = "Payment Information";
            // 
            // PaymentInfoTextBox
            // 
            PaymentInfoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PaymentInfoTextBox.BorderStyle = BorderStyle.None;
            PaymentInfoTextBox.Location = new Point(3, 18);
            PaymentInfoTextBox.Multiline = true;
            PaymentInfoTextBox.Name = "PaymentInfoTextBox";
            PaymentInfoTextBox.Size = new Size(467, 52);
            PaymentInfoTextBox.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            tableLayoutPanel2.SetColumnSpan(panel6, 3);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(ServicesTextBox);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 569);
            panel6.Margin = new Padding(3, 0, 3, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(602, 60);
            panel6.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(3, -1);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 2;
            label6.Text = "Footer";
            // 
            // ServicesTextBox
            // 
            ServicesTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ServicesTextBox.BorderStyle = BorderStyle.None;
            ServicesTextBox.Location = new Point(3, 17);
            ServicesTextBox.Multiline = true;
            ServicesTextBox.Name = "ServicesTextBox";
            ServicesTextBox.Size = new Size(467, 40);
            ServicesTextBox.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label14);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(TotalTextBox);
            panel7.Controls.Add(SubtotalTextBox);
            panel7.Controls.Add(DiscountTextBox);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(367, 420);
            panel7.Name = "panel7";
            panel7.Size = new Size(238, 74);
            panel7.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(55, 51);
            label14.Name = "label14";
            label14.Size = new Size(32, 15);
            label14.TabIndex = 12;
            label14.Text = "Total";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(33, 31);
            label13.Name = "label13";
            label13.Size = new Size(54, 15);
            label13.TabIndex = 11;
            label13.Text = "Discount";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(33, 10);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 8;
            label12.Text = "Subtotal:";
            // 
            // TotalTextBox
            // 
            TotalTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TotalTextBox.Font = new Font("Segoe UI", 8.25F);
            TotalTextBox.Location = new Point(93, 44);
            TotalTextBox.Name = "TotalTextBox";
            TotalTextBox.Size = new Size(142, 22);
            TotalTextBox.TabIndex = 10;
            // 
            // SubtotalTextBox
            // 
            SubtotalTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SubtotalTextBox.Font = new Font("Segoe UI", 8.25F);
            SubtotalTextBox.Location = new Point(93, 3);
            SubtotalTextBox.Name = "SubtotalTextBox";
            SubtotalTextBox.Size = new Size(142, 22);
            SubtotalTextBox.TabIndex = 8;
            // 
            // DiscountTextBox
            // 
            DiscountTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DiscountTextBox.Font = new Font("Segoe UI", 8.25F);
            DiscountTextBox.Location = new Point(93, 24);
            DiscountTextBox.Name = "DiscountTextBox";
            DiscountTextBox.Size = new Size(142, 22);
            DiscountTextBox.TabIndex = 9;
            // 
            // AddLineutton
            // 
            AddLineutton.Image = Properties.Resources.Add_16x;
            AddLineutton.Location = new Point(3, 420);
            AddLineutton.Name = "AddLineutton";
            AddLineutton.Size = new Size(27, 25);
            AddLineutton.TabIndex = 2;
            AddLineutton.UseVisualStyleBackColor = true;
            AddLineutton.Click += AddLineutton_Click;
            // 
            // InvoicesContextMenuStrip
            // 
            InvoicesContextMenuStrip.Name = "InvoicesContextMenuStrip";
            InvoicesContextMenuStrip.Size = new Size(61, 4);
            // 
            // PrintDocument1
            // 
            PrintDocument1.BeginPrint += PrintDocument1_BeginPrint;
            PrintDocument1.EndPrint += PrintDocument1_EndPrint;
            PrintDocument1.PrintPage += PrintDocument1_PrintPage;
            // 
            // PrintDialog1
            // 
            PrintDialog1.Document = PrintDocument1;
            PrintDialog1.UseEXDialog = true;
            // 
            // PrintPreviewDialog1
            // 
            PrintPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            PrintPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            PrintPreviewDialog1.ClientSize = new Size(400, 300);
            PrintPreviewDialog1.Document = PrintDocument1;
            PrintPreviewDialog1.Enabled = true;
            PrintPreviewDialog1.Icon = (Icon)resources.GetObject("PrintPreviewDialog1.Icon");
            PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            PrintPreviewDialog1.Visible = false;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 198, 220);
            ClientSize = new Size(634, 681);
            Controls.Add(tableLayoutPanel1);
            Name = "Homepage";
            Padding = new Padding(10, 0, 10, 0);
            ShowIcon = false;
            Text = "LIFELINE GLOBAL HEALTH SOLUTION LIMITED - INVOICE MANAGER";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemsDataGridView).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Panel panel2;
        private Button PrintButton;
        private Button ExportButton;
        private Panel panel3;
        private DataGridView ItemsDataGridView;
        private Panel panel5;
        private Panel panel6;
        private TextBox PaymentInfoTextBox;
        private TextBox ServicesTextBox;
        private Label label5;
        private Label label6;
        private Panel panel4;
        private Label label4;
        private Label label3;
        private TextBox CustomerPhoneTextBox;
        private TextBox CustomerAddressTextBox;
        private TextBox CustomerNameTextBox;
        private Panel panel7;
        private TextBox CompanyEmailTextBox;
        private TextBox CompanyAddressTextBox;
        private TextBox CompanyPhoneTextBox;
        private TextBox CompanyNameTextBox;
        private TextBox TotalTextBox;
        private TextBox SubtotalTextBox;
        private TextBox DiscountTextBox;
        private Label label14;
        private Label label13;
        private Label label12;
        private DateTimePicker InvoiceDateTimePicker;
        private TextBox InvoiceDueDateTextBox;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox InvoiceNumberTextBox;
        private Label label19;
        private Label label18;
        private Label label7;
        private Button AddLineutton;
        private ContextMenuStrip InvoicesContextMenuStrip;
        private System.Drawing.Printing.PrintDocument PrintDocument1;
        private PrintDialog PrintDialog1;
        private PrintPreviewDialog PrintPreviewDialog1;
        private DataGridViewButtonColumn RemoveColumn;
    }
}
