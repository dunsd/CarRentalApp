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

        public AddEditHardware()
        {
            InitializeComponent();
            lblTitle.Text = "Add Vehicle";
            isEditMode = false;
            hardwareRentalEntities = new HardwareRentalEntities();
        }

        public AddEditHardware(TypesOfHardware hardwareToEdit)
        {
            InitializeComponent();
            lblTitle.Text = "Edit Vehicle";
            PopulateFields(hardwareToEdit);
            isEditMode = true;
            hardwareRentalEntities = new HardwareRentalEntities();
        }

        private void PopulateFields(TypesOfHardware hardware)
        {
            lblId.Text = hardware.id.ToString();
            lblType.Text = hardware.Type;
            txtSerial.Text = hardware.SerialNumber;
            txtValue.Text = hardware.Value.ToString();
            txtYear.Text = hardware.YearMade.ToString();
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            if(isEditMode)
            {
                var id = int.Parse(lblId.Text);
                var hardware = hardwareRentalEntities.TypesOfHardwares.FirstOrDefault(query => query.id == id);
                hardware.Type = txtType.Text;
                hardware.SerialNumber = txtSerial.Text;
                hardware.Value = int.Parse(txtValue.Text);
                hardware.YearMade = txtYear.Text;

                hardwareRentalEntities.SaveChanges();
            }
            else
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
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
