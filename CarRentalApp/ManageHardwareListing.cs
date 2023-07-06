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
            var hardware = hardwareRentalEntities.TypesOfHardwares
                .Select(query => new { ID = query.id, Type = query.Type,
                 Serial = query.SerialNumber, Value = query.Value })
                .ToList();           
       
            //var hardware = hardwareRentalEntities.TypesOfHardwares.ToList();
            dgHardwareList.DataSource = hardware;
            /*dgHardwareList.Columns[0].HeaderText = "ID";
            dgHardwareList.Columns[1].HeaderText = "Name";*/
            

        }

        private void btnAddHardware_Click(object sender, EventArgs e)
        {

        }

        private void btnEditHardware_Click(object sender, EventArgs e)
        {

        }

        private void btnDelHardware_Click(object sender, EventArgs e)
        {

        }
    }
}
