using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystemApp.DLL.DAO
{
    internal class Vehicle
    {
        public int Id { get; set; }
        public string RegNO { get; set; }
        public string Model { get; set; }
        public string OwnerName { get; set; }
        public string DriverName { get; set; }
        public int Deal { get; set; }
        public string Status { get; set; }
    }
}