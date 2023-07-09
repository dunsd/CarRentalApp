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
    public partial class AddEditRecord : Form       
    {
        private readonly HardwareRentalEntities hardwareRentalEntities;
        bool isEditMode;
        public AddEditRecord()
        {            
            InitializeComponent();
            lblTitle.Text = "Add New Record";
            hardwareRentalEntities = new HardwareRentalEntities();
            isEditMode = false;
        }
        public AddEditRecord(HardwareRentalRecord hardwareRentalRecord)
        {
            hardwareRentalEntities = new HardwareRentalEntities();
            InitializeComponent();
            lblTitle.Text = "Edit Record";
            PopulateFields(hardwareRentalRecord);
            isEditMode = true;
            
        }

        private void PopulateFields(HardwareRentalRecord record)
        {
            lblId.Text = record.id.ToString();
            txtCustName.Text = record.CustName;
            txtCost.Text = record.Cost.ToString();
            dtpDateRented.Value = (DateTime) record.DateRented;
            dtpDateReturned.Value = (DateTime) record.DateReturned;
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

                //Check for errors in form entry
                if (string.IsNullOrWhiteSpace(txtCustName.Text) || string.IsNullOrWhiteSpace(cmbEquipList.Text))
                {
                    errorMsg += "Error: Please enter all the required fields.\n\r";
                    formValid = false;
                }

                if (dtpDateRented.Value > dtpDateReturned.Value)
                {
                    errorMsg += "Error: Please enter a return date after the rental date.\n\r";
                    formValid = false;
                }
                if(isEditMode)
                {
                    //Get id of record
                    var id = int.Parse(lblId.Text);

                    //if form is valid then update record
                    if (formValid)
                    {
                        var record = hardwareRentalEntities.HardwareRentalRecords.FirstOrDefault(query => query.id == id);
                        record.CustName = custName;
                        record.DateReturned = dateReturned;
                        record.Cost = cost;
                        record.DateRented = dateRented;
                        record.TypeOfHardwareId = (int)cmbEquipList.SelectedValue;

                        hardwareRentalEntities.SaveChanges();
                        MessageBox.Show("Successfully updated record.");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(errorMsg);
                    }
                }
                else
                {
                    //If in add mode, then create new record
                    if (formValid == true)
                    {
                        var rentalRecord = new HardwareRentalRecord
                        {
                            CustName = custName,
                            DateRented = dateRented,
                            DateReturned = dateReturned,
                            Cost = cost,
                            TypeOfHardwareId = (int)cmbEquipList.SelectedValue,
                        };


                        hardwareRentalEntities.HardwareRentalRecords.Add(rentalRecord);
                        hardwareRentalEntities.SaveChanges();

                        MessageBox.Show($"Thank you for renting {custName}!\n\r" +
                                        $"You have rented a {hardwareType} from {dateRented}\n\r" +
                                        $"Please return this by {dateReturned}\n\r" +
                                        $"Your cost is: {cost}");
                        Close();                     
                    }
                    else
                    {
                        MessageBox.Show(errorMsg);
                    }
                }               
            }

            //catch errors and display in a message box
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);            
            }            
                      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //select all from types of hardware table

            var hardware = hardwareRentalEntities.TypesOfHardwares
                .Select(query => new { id = query.id, Type = query.Type })
                .ToList();
            cmbEquipList.DisplayMember = "Type";
            cmbEquipList.ValueMember = "id";
            cmbEquipList.DataSource = hardware;
        }
    }
}
