using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LifelineGlobalInvoicingApp
{
    internal class InvoiceLine : INotifyPropertyChanged
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

        string description;
        decimal rate;
        decimal quantity;
        decimal total;
        
        public string Description { get => description; set => SetProperty(value, ref description); }
        public decimal Rate
        {
            get => rate;
            set
            {
                SetProperty(value, ref rate);
                UpdateTotal();
            }

        }
        public decimal Quantity
        {
            get => quantity;
            set
            {
                SetProperty(value, ref quantity);
                UpdateTotal();
            }
        }
        public decimal Total { get => total; set => SetProperty(value, ref total); }

        public InvoiceLine(string description, decimal rate = 0, decimal quantity = 1)
        {
            this.description = description;
            this.rate = rate;
            this.quantity = quantity;
            total = rate * quantity;
        }

        private void UpdateTotal() => Total = rate * quantity;

        public override bool Equals(object? obj) => obj is InvoiceLine line &&
                   description == line.Description;

        public override int GetHashCode() => HashCode.Combine(description);


    }
}
