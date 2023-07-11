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
        private Login _login;
        public MainWindow(Login login)
        {
            InitializeComponent();
            _login = login;
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.Cast<Form>();
            bool isOpen = openForms.Any(query => query.Name == "AddEditRecord");
            if(!isOpen)
            {
                AddEditRecord addRecordForm = new AddEditRecord();
                addRecordForm.MdiParent = this;
                addRecordForm.Show();
            }
        }

        private void manageHardwareListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.Cast<Form>();
            bool isOpen = openForms.Any(query => query.Name == "ManageHardwareListing");
            if(!isOpen)
            {
                var hardwareListing = new ManageHardwareListing();
                hardwareListing.MdiParent = this;
                hardwareListing.Show();
            }            
        }

        private void viewArchiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.Cast<Form>();
            bool isOpen = openForms.Any(query => query.Name == "ManageRentalRecords");
            if(!isOpen)
            {
                var manageRentalRecords = new ManageRentalRecords();
                manageRentalRecords.MdiParent = this;
                manageRentalRecords.Show();
            }
            
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }
    }
}
