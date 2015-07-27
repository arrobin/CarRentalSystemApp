using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalSystemApp.BLL;
using CarRentalSystemApp.DLL.DAO;

namespace CarRentalSystemApp.UI
{
    public partial class RentalInformationUI : Form
    {
        Vehicle aVehicle = new Vehicle();
        VehicleBLL aVehicleBll = new VehicleBLL();
        CustomerInformation aCustomerInformation = new CustomerInformation();
        BookingDetails aBookingDetails = new BookingDetails();
        Billing aBilling = new Billing();
        RentalInformationBLL aRentalInformationBll = new RentalInformationBLL();
        public RentalInformationUI()
        {
            InitializeComponent();
            PopulateComboBox();
            TakingAllCustomerDetails();
            TakingAllBillingDetails();
        }

        private void TakingAllCustomerDetails()
        {
            //List<CustomerInformation> customerInformations = aRentalInformationBll.GetAllCustomer();
        }

        private void TakingAllBillingDetails()
        {
            List<Billing> aBillings = aRentalInformationBll.GetAllBillingDetails();
        }

        private void PopulateComboBox()
        {
            vehicleRegNoComboBox.DisplayMember = "RegNO";
            vehicleRegNoUpdateComboBox.DisplayMember = "RegNO";
            regNoForBillComboBox.DisplayMember = "RegNO";
            List<Vehicle> vehicles = aVehicleBll.GetAllVehicle();
            vehicleRegNoComboBox.DataSource = vehicles;
            vehicleRegNoUpdateComboBox.DataSource = vehicles;
            regNoForBillComboBox.DataSource = vehicles;


        }

       
       
        private void vehicleRegNoComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Vehicle selectedVehicle = (Vehicle)vehicleRegNoComboBox.SelectedItem;
            driverNameTextBox.Text = selectedVehicle.DriverName;
        }

       

        private void bookingDetailsSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                aBookingDetails.Destination = destinationTextBox.Text;
                aBookingDetails.Date = bookingDetailsdateTimePicker.Text;
                aBookingDetails.Time = timeTextBox.Text;
                aBookingDetails.Distance = Convert.ToDouble(distanceTextBox.Text);
                Vehicle selectedVehicle = (Vehicle)vehicleRegNoComboBox.SelectedItem;
                aBookingDetails.VehicleId = selectedVehicle.Id;
                string msg = aRentalInformationBll.SaveBookingDetails(aBookingDetails.Destination, aBookingDetails.Distance, aBookingDetails.Date, aBookingDetails.Time, aBookingDetails.VehicleId);
                MessageBox.Show(msg);
                Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Please Filled \nDistance Text Box , With Digits");
            }
            
        }

        private void Clear()
        {
            destinationTextBox.Text = "";
            bookingDetailsdateTimePicker.Text = "";
            timeTextBox.Text = "";
            distanceTextBox.Text = "";
        }

        private void showButtoon_Click(object sender, EventArgs e)
        {
            Vehicle selectedVehicle = (Vehicle)vehicleRegNoUpdateComboBox.SelectedItem;
            int regId = selectedVehicle.Id;
            aBookingDetails.Date = updateDateTimePicker.Text;
            BookingDetails bookingDetails = aRentalInformationBll.GetBookingInformation(regId,aBookingDetails.Date);
            dateUpdate2TextBox.Text = aBookingDetails.Date;
            destinationUpdateTextBox.Text = bookingDetails.Destination;
            timeUpdateTextBox.Text = bookingDetails.Time;
            distanceUpdateTextBox.Text = bookingDetails.Distance.ToString();
            
        }

        private void vehicleRegNoUpdateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehicle selectedVehicleRegNo = (Vehicle)vehicleRegNoUpdateComboBox.SelectedItem;
            diriverNameUpdateTextBox.Text = selectedVehicleRegNo.DriverName;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicle selectedVehicle = (Vehicle)vehicleRegNoUpdateComboBox.SelectedItem;
                int regId = selectedVehicle.Id;
                aBookingDetails.Date = updateDateTimePicker.Text;
                string updateDate = dateUpdate2TextBox.Text;
                aBookingDetails.Destination = destinationUpdateTextBox.Text;
                aBookingDetails.Time = timeUpdateTextBox.Text;
                aBookingDetails.Distance = Convert.ToDouble(distanceUpdateTextBox.Text);
                string msg = aRentalInformationBll.UpdateBookingDetails(regId, aBookingDetails.Date, aBookingDetails.Destination, aBookingDetails.Distance, aBookingDetails.Time, updateDate);
                MessageBox.Show(msg);
            }
            catch (Exception)
            {

                MessageBox.Show("Please Filled \nDistance Text Box , With Digits");
            }
            

        }

        private void CustomerInfoSavebutton_Click(object sender, EventArgs e)
        {
            try
            {
                aCustomerInformation.Name = customerNameTextBox.Text;
                aCustomerInformation.Address = addressTextBox.Text;
                aCustomerInformation.PhoneNo =phoneNumberTextBox.Text;

                string msg = aRentalInformationBll.SaveCustomerInformation(aCustomerInformation.Name,
                    aCustomerInformation.Address, aCustomerInformation.PhoneNo);
                MessageBox.Show(msg);
            }
            catch (FormatException formatException)
            {
                MessageBox.Show("Please Filled\nPhone Number Text Box With \n11 Digits Valid Phone Number");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please Filled\nPhone Number Text Box With \n11 Digits Valid Phone Number");
            }
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Vehicle selectedVehicle = (Vehicle)regNoForBillComboBox.SelectedItem;
                aBookingDetails.VehicleId = selectedVehicle.Id;
                string phoneNo = phoneNoForBillTextBox.Text;
                CustomerInformation customerInformations = aRentalInformationBll.GetCustomerId(phoneNo);
                BookingDetails bookingDetails = aRentalInformationBll.GetBookingId(aBookingDetails.VehicleId);
                aBilling.BookId = bookingDetails.Id;
                int customerId = customerInformations.Id;
                double bridgeCost = Convert.ToDouble(bridgeCostTextBox.Text);
                double cngOilCost = Convert.ToDouble(cngCostTextBox.Text);
                double otherCost = Convert.ToDouble(otherCostTextBox.Text);
                aBilling.TotalCost = (bridgeCost + cngOilCost + otherCost);
                aBilling.Advance = Convert.ToDouble(advanceTextBox.Text);
                aBilling.Due = (aBilling.TotalCost - aBilling.Advance);
                aBilling.BillingDate = billingDateTextBox.Text;

                string msg = aRentalInformationBll.SaveBillingInformation(aBilling.TotalCost, aBilling.Advance, aBilling.Due, aBilling.BillingDate, aBilling.BookId, customerId);
                MessageBox.Show(msg);
            }
            catch (Exception)
            {

                MessageBox.Show("Please Filled\nPhone Number Text Box With 11 Digits Valid Number\n&\nCNG/Oil Cost, Bridge Cost, Other Cost, Advance Text Box With Digits,");
            }
            



        }
    }
}
