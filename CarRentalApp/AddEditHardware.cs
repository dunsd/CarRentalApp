using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareRentalApp
{
    public partial class AddEditHardware : Form
    {
        private bool isEditMode;
        private HardwareRentalEntities hardwareRentalEntities;
        private ManageHardwareListing _manageHardwareListing;

        public AddEditHardware(ManageHardwareListing manageHardwareListing = null)
        {
            InitializeComponent();
            lblTitle.Text = "Add Vehicle";
            isEditMode = false;
            hardwareRentalEntities = new HardwareRentalEntities();
            _manageHardwareListing = manageHardwareListing;
        }

        public AddEditHardware(TypesOfHardware hardwareToEdit, ManageHardwareListing manageHardwareListing = null)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Vehicle";
            PopulateFields(hardwareToEdit);
            isEditMode = true;
            hardwareRentalEntities = new HardwareRentalEntities();
            _manageHardwareListing = manageHardwareListing;
        }

        private void PopulateFields(TypesOfHardware hardware)
        {
            lblId.Text = hardware.id.ToString();
            txtType.Text = hardware.Type;
            txtSerial.Text = hardware.SerialNumber;
            txtValue.Text = hardware.Value.ToString();
            txtYear.Text = hardware.YearMade.ToString();
        }

       

        private void btnSaveChange_Click(object sender, EventArgs e)
        {       
                try
                {
                    //initialise error checks
                    var errorMsg = "";
                    bool formValid = true;
                                        
                    if(string.IsNullOrWhiteSpace(txtType.Text) 
                        || string.IsNullOrWhiteSpace(txtSerial.Text))
                    {
                        formValid = false;
                        errorMsg += "Error: Please fill out all required fields. \n\r";

                    }
                    //Handle submit in edit mode
                    if(isEditMode)
                    {
                        var id = int.Parse(lblId.Text);

                        if (formValid)
                        {
                            //Update row matching id
                            var hardware = hardwareRentalEntities.TypesOfHardwares.FirstOrDefault(query => query.id == id);
                            hardware.Type = txtType.Text;
                            hardware.SerialNumber = txtSerial.Text;
                            hardware.Value = int.Parse(txtValue.Text);
                            hardware.YearMade = txtYear.Text;
                            hardwareRentalEntities.SaveChanges();
                            MessageBox.Show("Record edited successfully\n\r" +
                            "Please refresh to show the changes");
                        }
                        else
                        {
                            MessageBox.Show(errorMsg);
                        }
                    }
                    else
                    {
                        //Handle new record
                        if(formValid)
                        {
                            //Create new row of hardware type and add to table
                            var newHardware = new TypesOfHardware
                            {
                                Type = txtType.Text,
                                SerialNumber = txtSerial.Text,
                                Value = int.Parse(txtValue.Text),
                                YearMade = txtYear.Text,
                            };

                            hardwareRentalEntities.TypesOfHardwares.Add(newHardware);
                            hardwareRentalEntities.SaveChanges();
                            MessageBox.Show("Record added successfully\n\r" +
                            "Please refresh to show the changes");
                        }
                        else 
                        { 
                            MessageBox.Show(errorMsg); 
                        }                        
                    }
                _manageHardwareListing.RefreshGrid();
                Close();
                }                                       
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
