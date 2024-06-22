using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace LifelineGlobalInvoicingApp
{
    internal class Invoice : INotifyPropertyChanged
    {
        protected bool SetProperty<T>(T value, ref T storage, [CallerMemberName] string propertyName = "")
        {
            if (Equals(storage, value)) return false;
            else
            {
                storage = value;
                NotifyPropertyChanged(propertyName);
                return true;
            }
        }
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public event PropertyChangedEventHandler? PropertyChanged;

        int invoiceNumber = 1;
        DateTime invoiceDate = DateTime.Now;
        string dueDate = "Due on receipt";
        decimal subtotal;
        decimal discount;
        decimal total;
        Customer customer;
        BindingList<InvoiceLine> items = new();

        public string InvoiceNumber => "INV000" + invoiceNumber.ToString();
        public Customer Customer { get => customer; set => SetProperty(value, ref customer); }
        public DateTime InvoiceDate { get => invoiceDate; set => SetProperty(value, ref invoiceDate); }
        public string DueDate { get => dueDate; set => SetProperty(value, ref dueDate); }
        public decimal Subtotal { get => subtotal; set => SetProperty(value, ref subtotal); }
        public decimal Discount { get => discount; set => SetProperty(value, ref discount); }
        public decimal Total { get => total; set => SetProperty(value, ref total); }
        public BindingList<InvoiceLine> Items { get => items; set => SetProperty(value, ref items); }

        public Invoice(Customer customer)
        {
            this.customer = customer;
            PropertyChanged += Invoice_PropertyChanged;
            Items.ListChanged += Items_ListChanged;
        }

        private void Items_ListChanged(object? sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                var ct = Items[e.NewIndex];
                ct.PropertyChanged += CartItem_PropertyChanged;

            }
            Subtotal = items.Select((x) => x.Total).Sum();
            Total = items.Select((x) => x.Total).Sum() - Discount;
        }

        private void Invoice_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Discount))
            {
                Total = items.Select((x) => x.Total).Sum() - Discount;
            }
        }

        public void CartItem_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            Subtotal = items.Select((x) => x.Total).Sum();
            Total = items.Select((x) => x.Total).Sum() - Discount;
        }

        public int RaiseNumber()
        {
            invoiceNumber += 1;
            NotifyPropertyChanged(nameof(InvoiceNumber));
            return invoiceNumber;
        }
        public int GetNumber() => invoiceNumber;
        public void SetNumber(int number) => invoiceNumber = number;
    }
}
