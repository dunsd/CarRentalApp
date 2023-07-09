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
    public partial class ManageHardwareListing : Form
    {
        private HardwareRentalEntities hardwareRentalEntities;
        public ManageHardwareListing()
        {
            InitializeComponent();
            hardwareRentalEntities = new HardwareRentalEntities();
        }

        private void ManageHardwareListing_Load(object sender, EventArgs e)
        {
            RefreshGrid();            
        }

        public void RefreshGrid()
        {
            var hardware = hardwareRentalEntities.TypesOfHardwares.Select(query =>
            new
            {
                id = query.id,
                Type = query.Type,
                SerialNumber = query.SerialNumber,
                Value = query.Value,
                YearMade = query.YearMade,
            })
            .ToList();
            dgHardwareList.DataSource = hardware;
            dgHardwareList.Columns[2].HeaderText = "Serial Number";
            dgHardwareList.Columns[0].Visible = true;
        }

        private void btnAddHardware_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.Cast<Form>();
            bool isOpen = openForms.Any(query => query.Name == "AddEditHardware");
            if(!isOpen)
            {
                var addEditHardware = new AddEditHardware(this);
                addEditHardware.MdiParent = this.MdiParent;
                addEditHardware.Show();
            }
            
        }

        private void btnEditHardware_Click(object sender, EventArgs e)
        {
            try
            {
                //Get id of selected row
                var id = (int)dgHardwareList.SelectedRows[0].Cells["id"].Value;

                //query db for row matching id
                var hardware = hardwareRentalEntities.TypesOfHardwares.FirstOrDefault(query => query.id == id);

                //launch with queried row data
                var openForms = Application.OpenForms.Cast<Form>();
                bool isOpen = openForms.Any(query => query.Name == "AddEditHardware");
                if(!isOpen)
                {
                    var addEditHardware = new AddEditHardware(hardware, this);
                    addEditHardware.MdiParent = this.MdiParent;
                    addEditHardware.Show();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void btnDelHardware_Click(object sender, EventArgs e)
        {
            try
            {
                //Get id of selected row
                var id = (int)dgHardwareList.SelectedRows[0].Cells["id"].Value;

                //query db for row matching id
                var hardware = hardwareRentalEntities.TypesOfHardwares.FirstOrDefault(query => query.id == id);

                //delete row from db
                hardwareRentalEntities.TypesOfHardwares.Remove(hardware);
                hardwareRentalEntities.SaveChanges();

                dgHardwareList.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
