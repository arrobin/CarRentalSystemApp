using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystemApp.DLL.DAO;
using CarRentalSystemApp.DLL.Gateway;

namespace CarRentalSystemApp.BLL
{
    internal class VehicleBLL
    {
        private VehicleGateway aVehicleGateway;
        private Vehicle aVehicle;

        public VehicleBLL()
        {
            aVehicleGateway = new VehicleGateway();
            aVehicle = new Vehicle();
        }

        public string Save(string regNo, string model, string ownerName, string driverName, int deal,string status)
        {

            if ((regNo == "" || model == "" || ownerName == "" || driverName == "" ||status == "" ))
            {
                string info = "";

                if (regNo == "")
                {
                    info += "Please Filled Car Registration Number Name\n";
                }
                if (model == "")
                {
                    info += "Please Filled Vehicle Model\n";
                }
                if (ownerName == "")
                {
                    info += "Please Filled Owner Name\n";
                }
                if (driverName == "")
                {
                    info += "Please Filled Driver Name\n";
                }
                
                if (status == "")
                {
                    info += "Please Filled Status\n";
                }
               
                return info;
            }
        
            else
            {
                if (aVehicleGateway.HasthisVehicleAlrady(regNo))
                {
                    return "This Vehicle Alrady In System";
                }
                else
                {
                    if (aVehicleGateway.Save(regNo, model, ownerName, driverName, deal, status))
                    {
                        return "Data Saved Successfully";
                    }
                    else
                    {
                        return "Problem";
                    }
                }
            }
            


        }

        public List<Vehicle> GetAllVehicle()
        {
            return aVehicleGateway.GetAllVehicle();
        }


        public string UpdateVehicleInformation(string regNo, string ownerName, int deal, string driverName, string model,string status)
        {
            if ((regNo == "" || model == "" || ownerName == "" || driverName == "" || status == ""))
            {
                string info = "";

                if (regNo == "")
                {
                    info += "Please Filled Car Registration Number Name\n";
                }
                if (model == "")
                {
                    info += "Please Filled Vehicle Model\n";
                }
                if (ownerName == "")
                {
                    info += "Please Filled Owner Name\n";
                }
                if (driverName == "")
                {
                    info += "Please Filled Driver Name\n";
                }

                if (status == "")
                {
                    info += "Please Filled Status\n";
                }

                return info;
            }
            else
            {
                if (aVehicleGateway.UpdateVehicleInformation(regNo, ownerName, deal, driverName, model, status))
                {
                    return "Data Updated Successfully";
                }
                else
                {
                    return "Problem";
                }
            }
            
            
        }
    }
}
