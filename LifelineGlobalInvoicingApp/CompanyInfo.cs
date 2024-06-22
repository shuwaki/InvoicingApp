using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifelineGlobalInvoicingApp
{
    internal static class CompanyInfo
    {
        public static string CompanyName = "Lifeline Global Health Solutions Limited";
        public static string CompanyAddress = "No A5, Bill Plaza, Ibrahim Shema, Way Katsina";
        public static string CompanyEmail = "contactlifelineghs@gmail.com";
        public static string CompanyPhone = "08063428363, 08074333707, 08093600080";
        public static string[] PaymentInfo = [ "(UBA) ACCOUNT: 1027137821 Lifeline Global Health Solution",
            "(Moniepoint) ACCOUNT: 8315041209 Lifeline Global Health Solutions",
            "(Access Bank) ACCOUNT: 0033785151 Aliyu Musa"];
        public static string[] Services = ["Pharmacy, sales and supply of hospital equipment, Health education and promotion",
            "construction and renovation of healthcare facilities, supply of agricultural and other products"];
        static CompanyInfo()
        {
            //retrieve companyinfo
        }
    }
}
