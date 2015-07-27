using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystemApp.DLL.DAO
{
    class BookingDetails
    {
        public int Id { get; set; }
        public string Destination { get; set; }
        public double Distance { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int VehicleId { get; set; }
        
    }
}
