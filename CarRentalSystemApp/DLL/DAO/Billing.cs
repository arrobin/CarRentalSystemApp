using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystemApp.DLL.DAO
{
    class Billing
    {
        public int Id { get; set; }
        public double TotalCost { get; set; }
        public double Advance { get; set; }
        public double Due { get; set; }
        public string BillingDate { get; set; }
        public int BookId { get; set; }
        public int CustomerId { get; set; }

        
    }
}
