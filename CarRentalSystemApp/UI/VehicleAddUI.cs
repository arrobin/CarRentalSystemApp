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

namespace CarRentalSystemApp
{
    public partial class VehicleAddUi : Form
    {
        Vehicle aVehicle = new Vehicle();
        VehicleBLL aVehicleBll = new VehicleBLL();
        public VehicleAddUi()
        {
            InitializeComponent();
            PopulateRegNoComboBox();
        }
        private void PopulateRegNoComboBox()
        {
            vehicleRegNoComboBox.DisplayMember = "RegNO";
            List<Vehicle> vehicles = aVehicleBll.GetAllVehicle();
            vehicleRegNoComboBox.DataSource = vehicles;
            
        }

        
        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                aVehicle.Model = vehicleModelUpdateTextBox.Text;
                aVehicle.OwnerName = ownerNameUpdateTextBox.Text;
                aVehicle.DriverName = driverNameUpdateTextBox.Text;
                aVehicle.Deal = Convert.ToInt32(dealUpdateTextBox.Text);
                aVehicle.Status = statusUpdateComboBox.Text;
                Vehicle selectedVehicle = (Vehicle)vehicleRegNoComboBox.SelectedItem;
                string regNo = selectedVehicle.RegNO;
                string msg = aVehicleBll.UpdateVehicleInformation(regNo, aVehicle.OwnerName, aVehicle.Deal, aVehicle.DriverName, aVehicle.Model, aVehicle.Status);
                MessageBox.Show(msg);
                Refresh();
            }
            catch (FormatException formatException)
            {

                MessageBox.Show("Please Filled Deal Text Box With Digit Only");
            }
            catch (OverflowException overflowException)
            {
                MessageBox.Show("Please Filled Input Should be Less Then 100");
            }
            
           
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                aVehicle.RegNO = carRegNoTextBox.Text;
                aVehicle.Model = vehicleModelTextBox.Text;
                aVehicle.OwnerName = ownerNameTextBox.Text;
                aVehicle.DriverName = driverNameTextBox.Text;
                aVehicle.Deal = Convert.ToInt32(dealTextBox.Text);
                aVehicle.Status = statusTextBox.Text;

                string msg = aVehicleBll.Save(aVehicle.RegNO, aVehicle.Model, aVehicle.OwnerName, aVehicle.DriverName,
                    aVehicle.Deal, aVehicle.Status);
                MessageBox.Show(msg);
                
                PopulateRegNoComboBox();
                Clear();
            }
            catch (FormatException formatException)
            {

                MessageBox.Show("Please Filled Deal Text Box With Digit Only");
            }
            catch (OverflowException overflowException)
            {
                MessageBox.Show("Please Filled Input Should be Less Then 100");
            }
            
        }

        private void Clear()
        {
            carRegNoTextBox.Text = "";
            vehicleModelTextBox.Text = "";
            ownerNameTextBox.Text = "";
            driverNameTextBox.Text = "";
            dealTextBox.Text ="";
        }

        private void vehicleRegNoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vehicle selectedVehicle = (Vehicle)vehicleRegNoComboBox.SelectedItem;
            vehicleModelUpdateTextBox.Text = selectedVehicle.Model;
            ownerNameUpdateTextBox.Text = selectedVehicle.OwnerName;
            driverNameUpdateTextBox.Text = selectedVehicle.DriverName;
            dealUpdateTextBox.Text = selectedVehicle.Deal.ToString();
        }

        
       
    }
}
