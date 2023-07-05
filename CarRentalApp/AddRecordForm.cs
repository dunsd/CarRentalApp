using HardwareRentalApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class AddRecordForm : Form       
    {
        private readonly HardwareRentalEntities hardwareRentalEntities;
        public AddRecordForm()
        {
            InitializeComponent();
            hardwareRentalEntities = new HardwareRentalEntities();
        }

        //Handle submit of form
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string custName = txtCustName.Text;
                DateTime dateRented = dtpDateRented.Value;
                DateTime dateReturned = dtpDateReturned.Value;
                var hardwareType = cmbEquipList.Text;
                decimal cost = Convert.ToDecimal(txtCost.Text);
                var errorMsg = "";

                bool formValid = true;

                if (string.IsNullOrWhiteSpace(custName) || string.IsNullOrWhiteSpace(hardwareType))
                {
                    errorMsg += "Error: Please enter all the required fields.\n\r";
                    formValid = false;
                }

                if (dateRented > dateReturned)
                {
                    errorMsg += "Error: Please enter a return date after the rental date.\n\r";
                    formValid = false;
                }

                if (formValid == true)
                {
                    var rentalRecord = new HardwareRentalRecord();
                    rentalRecord.CustName = custName;
                    rentalRecord.DateRented = dateRented;
                    rentalRecord.DateReturned = dateReturned;
                    rentalRecord.Cost = cost;
                    rentalRecord.TypeOfHardwareId = (int)cmbEquipList.SelectedValue;

                    hardwareRentalEntities.HardwareRentalRecords.Add(rentalRecord);
                    hardwareRentalEntities.SaveChanges();

                    MessageBox.Show($"Thank you for renting {custName}!\n\r" +
                                    $"You have rented a {hardwareType} from {dateRented}\n\r" +
                                    $"Please return this by {dateReturned}\n\r" +
                                    $"Your cost is: {cost}");
                }
                else
                {
                    MessageBox.Show(errorMsg);
                }
            }

            //catch errors and display in a message box
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);            
                //throw;
            }
            
                      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //select all from types of hardware table
            var hardware = hardwareRentalEntities.TypesOfHardwares.ToList();
            cmbEquipList.DisplayMember = "Name";
            cmbEquipList.ValueMember = "id";
            cmbEquipList.DataSource = hardware;
        }
    }
}
