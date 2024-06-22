using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LifelineGlobalInvoicingApp
{
    internal class CompanyInfo : INotifyPropertyChanged
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

        string companyName;
        string companyAddress;
        string companyPhone;
        string companyEmail;
        string[] paymentInfo;
        string[] services;

        public string CompanyName { get => companyName; set => SetProperty(value, ref companyName); }
        public string CompanyAddress { get => companyAddress; set => SetProperty(value, ref companyAddress); }
        public string CompanyEmail { get => companyEmail; set => SetProperty(value, ref companyEmail); }
        public string CompanyPhone { get => companyPhone; set => SetProperty(value, ref companyPhone); }
        public string[] PaymentInfo { get => paymentInfo; set => SetProperty(value, ref paymentInfo); }
        public string[] Services { get => services; set => SetProperty(value, ref services); }
        public CompanyInfo()
        {
            if (File.Exists("invoiceNumber.txt"))
            {
                var fileContent = File.ReadLines("invoiceNumber.txt").ToArray();
                companyName = fileContent[1];
                companyAddress = fileContent[2];
                companyEmail = fileContent[3];
                companyPhone = fileContent[4];
                paymentInfo = fileContent[5].Split(';');
                services = fileContent[6].Split(';');
            }
            else
            {
                companyName = "";
                companyAddress = "";
                companyEmail = "";
                companyPhone = "";
                paymentInfo = [];
                services = [];
            }
        }
    }
}
