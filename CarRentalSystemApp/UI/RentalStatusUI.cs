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
    public partial class RentalStatusUI : Form
    {
        VehicleBLL aVehicleBll = new VehicleBLL();
        private RentalInformation aRentalInformation;
        RentalInformationBLL  aRentalInformationBll = new RentalInformationBLL();

        public RentalStatusUI()
        {
            InitializeComponent();
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            vehicleRegNocomboBox.DisplayMember = "RegNO";
            vehicleRegNoUpdatecomboBox.DisplayMember = "RegNO";
            List<Vehicle> vehicles = aVehicleBll.GetAllVehicle();
            vehicleRegNocomboBox.DataSource = vehicles;
            vehicleRegNoUpdatecomboBox.DataSource = vehicles;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aRentalInformation = new RentalInformation();
            Vehicle selectedVehicle = (Vehicle)vehicleRegNocomboBox.SelectedItem;
            string regNo = selectedVehicle.RegNO;
            aRentalInformation.RentDate = saveDateTimePicker.Text;
            aRentalInformation.Destination = destinationSaveTextBox.Text;
            aRentalInformation.Payment = Convert.ToDouble(rentCostSaveTextBox.Text);
            aRentalInformation.Cost = Convert.ToDouble(costSaveTextBox.Text);
            aRentalInformation.Profit = Convert.ToDouble(aRentalInformation.Payment-aRentalInformation.Cost);
                aRentalInformation.Commission = ((selectedVehicle.Deal*aRentalInformation.Profit)/100);
            aRentalInformation.PaymentStatus = (string) StatusSaveComboBox.SelectedItem;
            string msg = aRentalInformationBll.SaveRentalInformation(regNo,aRentalInformation.RentDate,aRentalInformation.Destination,
                aRentalInformation.Payment,aRentalInformation.Cost,aRentalInformation.Profit,aRentalInformation.Commission,
            aRentalInformation.PaymentStatus);
            MessageBox.Show(msg);
            saveDateTimePicker.Text = "";
            destinationSaveTextBox.Text = "";
            rentCostSaveTextBox.Text = "";
            costSaveTextBox.Text = "";
            StatusSaveComboBox.Text = "";
            PopulateComboBox();
    

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            aRentalInformation = new RentalInformation();
            aRentalInformation.RegNo = vehicleRegNoUpdatecomboBox.Text;
            aRentalInformation.RentDate = updateDateTimePicker.Text;
            aRentalInformation.Destination = destinationUpdateTextBox.Text;
            aRentalInformation.Payment = Convert.ToDouble(rentalCostUpdateTextBox.Text);
            aRentalInformation.Cost = Convert.ToDouble(costUpdateTextBox.Text);
            aRentalInformation.Profit = Convert.ToDouble(aRentalInformation.Payment - aRentalInformation.Cost);
            Vehicle selectedVehicle = (Vehicle)vehicleRegNocomboBox.SelectedItem;
            aRentalInformation.Commission = ((selectedVehicle.Deal * aRentalInformation.Profit) / 100);
            aRentalInformation.PaymentStatus = (string)StatusUpdateComboBox.SelectedItem;
            string msg = aRentalInformationBll.UpdateRentalInformation(aRentalInformation.RegNo, aRentalInformation.RentDate, aRentalInformation.Destination,
                aRentalInformation.Payment, aRentalInformation.Cost, aRentalInformation.Profit, aRentalInformation.Commission,
            aRentalInformation.PaymentStatus);
            MessageBox.Show(msg);


        }

        
        private void showButton_Click(object sender, EventArgs e)
        {
            Vehicle selectedVehicle = (Vehicle)vehicleRegNoUpdatecomboBox.SelectedItem;
            string regNo = selectedVehicle.RegNO;
            string rentDate = updateDateTimePicker.Text;
            RentalInformation rentalsInformations = aRentalInformationBll.GetRentalInformation(regNo, rentDate);

            destinationUpdateTextBox.Text = rentalsInformations.Destination;
            rentalCostUpdateTextBox.Text = rentalsInformations.Payment.ToString();
            costUpdateTextBox.Text = rentalsInformations.Cost.ToString();
            profitUpdateTextBox.Text = rentalsInformations.Profit.ToString();
            commitionUpdateTextBox.Text = rentalsInformations.Commission.ToString();
            StatusUpdateComboBox.Text = rentalsInformations.PaymentStatus;

        }

        
    }
}
