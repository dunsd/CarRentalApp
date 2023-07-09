using CarRentalApp;
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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditRecord addRecordForm = new AddEditRecord();
            addRecordForm.MdiParent = this;
            addRecordForm.Show();
        }

        private void manageHardwareListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var hardwareListing = new ManageHardwareListing();
            hardwareListing.MdiParent = this;
            hardwareListing.Show();
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var manageRentalRecords = new ManageRentalRecords();
            manageRentalRecords.MdiParent = this;
            manageRentalRecords.Show();
        }
    }
}
