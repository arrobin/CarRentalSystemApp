using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalSystemApp.DLL.DAO;
using CarRentalSystemApp.DLL.Gateway;

namespace CarRentalSystemApp.BLL
{
    class CustomerDetailsBLL
    {
        private CustomerDetailsGateway aCustomerDetailsGateway;

        public CustomerDetailsBLL()
        {
            aCustomerDetailsGateway = new CustomerDetailsGateway();
        }

        public CustomerInformation GetCustomerInformation(double customerPhoneNo)
        {
            return aCustomerDetailsGateway.GetCustomerInformation(customerPhoneNo);
        }

        public Billing GetBillingDetails(int id)
        {
            return aCustomerDetailsGateway.GetBillingDetails(id);
        }

        public BookingDetails GetBookingDetails(int bookId)
        {
            return aCustomerDetailsGateway.GetBookingDetails(bookId);
        }

        public Vehicle GetVehicleDetails(int vehicleId)
        {
            return aCustomerDetailsGateway.GetVehicleDetails(vehicleId);
        }
    }
}
