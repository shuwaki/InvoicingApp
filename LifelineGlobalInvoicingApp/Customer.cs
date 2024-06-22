using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LifelineGlobalInvoicingApp
{
    internal class Customer(string name, string address = "", string phone = "") : INotifyPropertyChanged
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

        public override bool Equals(object? obj) => obj is Customer customer &&
                   Name == customer.Name;

        public override int GetHashCode() => HashCode.Combine(Name);

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Name { get => name; set => SetProperty(value, ref name); }
        public string Address { get => address; set => SetProperty(value, ref address); }
        public string Phone { get => phone; set => SetProperty(value, ref phone); }


    }
}
