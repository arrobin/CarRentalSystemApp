using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystemApp.DLL.DAO;
using CarRentalSystemApp.DLL.Gateway;

namespace CarRentalSystemApp.BLL
{
    internal class RentalInformationBLL
    {
        private RentalInformationGateway aRentalInformationGateway;

        public RentalInformationBLL()
        {
            aRentalInformationGateway = new RentalInformationGateway();
        }

        public List<Billing> GetAllBillingDetails()
        {
            return aRentalInformationGateway.GetAllBillingDetails();
        }

        public CustomerInformation GetCustomerId(string phoneNo)
        {
             
                return aRentalInformationGateway.GetCustomerId(phoneNo);
        }


        public string SaveRentalInformation(string regNo, string rentDate, string destination, double payment,
            double cost, double profit, double commission, string paymentStatus)
        {

            if ((regNo == "" || rentDate == "" || destination == "" || paymentStatus == ""))
            {
                string info = "";

                if (regNo == "")
                {
                    info += "Please Filled Car Registration Number\n";
                }
                if (rentDate == "")
                {
                    info += "Please Filled Rent Date\n";
                }
                if (destination == "")
                {
                    info += "Please Filled Destination\n";
                }
                if (paymentStatus == "")
                {
                    info += "Please Filled Payment Status\n";
                }

                return info;
            }
            else
            {
                if ((aRentalInformationGateway.IsVehicleAlreadySaved(regNo)) &&
                    (aRentalInformationGateway.IsVehicleAlreadySaveInThisDate(rentDate)))
                {
                    return "This Vehicle Already Booked In this Date";
                }
                else
                {
                    if (RentalInformationGateway.SaveRentalInformation(regNo, rentDate, destination, payment, cost,
                        profit,
                        commission, paymentStatus))
                    {
                        return "Data Save Successfully";
                    }
                    else
                    {
                        return "Faild";
                    }
                }

            }


        }

    


        public List<RentalInformation> GetAllRentalDetails(string regNo)
        {
            return aRentalInformationGateway.GetAllRentalDetails(regNo);
        }

        public string SaveBookingDetails(string destination, double distance, string date, string time, int vehicleId)
        {
            if ((destination == "" || date == "" || time == "" ))
            {
                string info = "";

                if (destination == "")
                {
                    info += "Please Filled Destination\n";
                }
                if (date == "")
                {
                    info += "Please Filled Rent Date\n";
                }
                if (time == "")
                {
                    info += "Please Filled Time\n";
                }
                

                return info;
            }
            else
            {
                if ((aRentalInformationGateway.IsDateAlreadyBooked(date)) && (aRentalInformationGateway.IsVehicleAlreadyBooked(vehicleId)))
                {
                    return "This Vehicle Already Booked In this Date";
                }
                else
                {
                    if (aRentalInformationGateway.SaveBookingDetails(destination, distance, date, time, vehicleId))
                    {
                        return "Data Save Successfully";
                    }

                    return "Faild";

                }
            }
            
        }

        public RentalInformation GetRentalInformation(string regNo, string rentDate)
        {
            return aRentalInformationGateway.GetRentalInformation(regNo,rentDate);
        }

        public string UpdateRentalInformation(string regNo, string rentDate, string destination, double payment, double cost, double profit, double commission, string paymentStatus)
        {
            if ((regNo == "" || rentDate == "" || destination == "" || paymentStatus == ""))
            {
                string info = "";

                if (regNo == "")
                {
                    info += "Please Filled Car Registration Number\n";
                }
                if (rentDate == "")
                {
                    info += "Please Filled Rent Date\n";
                }
                if (destination == "")
                {
                    info += "Please Filled Destination\n";
                }
                if (paymentStatus == "")
                {
                    info += "Please Filled Payment Status\n";
                }

                return info;
            }
            else
            {
                if (RentalInformationGateway.UpdateRentalInformation(regNo, rentDate, destination, payment, cost, profit,
                commission, paymentStatus))
                {
                    return "Data Update Successfully";
                }
                else
                {
                    return "Faild";
                }
            }
            
            
        }

        public BookingDetails GetBookingInformation(int regId, string date)
        {
            return aRentalInformationGateway.GetBookingInformation(regId,date);
        }

        public string UpdateBookingDetails(int regId, string date, string destination, double distance, string time, string updateDate)
        {
            if ((destination == "" || date == "" || time == ""))
            {
                string info = "";

                if (destination == "")
                {
                    info += "Please Filled Destination\n";
                }
                if (date == "")
                {
                    info += "Please Filled Rent Date\n";
                }
                if (time == "")
                {
                    info += "Please Filled Time\n";
                }


                return info;
            }
            else
            {
                if (aRentalInformationGateway.UpdateBookingDetails(regId, date, destination, distance, time, updateDate))
                {
                    return "Data Update Successfully";
                }
                else
                {
                    return "Faild";
                }
            }


        }

        public string SaveCustomerInformation(string name, string address, string phoneNo)
        {

            
            if ((name == "" || address == "" || phoneNo == "" || phoneNo.Length > 11))
            {
                string info = "";

                if (name == "")
                {
                    info += "Please Filled Customer Name\n";
                }
                if (address == "")
                {
                    info += "Please Filled Address\n";
                }
                if (phoneNo.Length > 11)
                {
                    info += "Please Enter 11 degits Valid Phone Number ";
                }
                if (phoneNo == "")
                {
                    info += "Please Filled Phone Number\n";
                }
                

                return info;
            }
            else
            {
                if (aRentalInformationGateway.SaveCustomerInformation(name, address, phoneNo))
                {
                    return "Data Save Successfully";
                }
                else
                {
                    return "Faild";
                }
            }
            
        }

        public BookingDetails GetBookingId(int vehicleId)
        {
            return aRentalInformationGateway.GetBookingId(vehicleId);
        }

        public string SaveBillingInformation(double totalCost, double advance, double due, string billingDate, int bookId, int customerId)
        {
            if ((billingDate == ""))
            {
                string info = "";

                info += "Please Filled Billing Date\n";

                return info;
            }
            else
            {
                if (aRentalInformationGateway.SaveBillingInformation(totalCost, advance, due, billingDate, bookId, customerId))
                {
                    return "Data Save Successfully";
                }
                else
                {
                    return "Faild";
                } 
            }

            
        }
    }
    }


