using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystemApp.DLL.DAO
{
    class RentalInformation
    {
        public string RegNo { get; set; }
        public string RentDate { get; set; }
        public string Destination { get; set; }
        public double Payment { get; set; }
        public double Cost { get; set; }
        public double Profit { get; set; }
        public double Commission { get; set; }
        public string PaymentStatus { get; set; }
        
    }
}
