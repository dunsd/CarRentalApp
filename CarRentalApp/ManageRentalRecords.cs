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
    public partial class ManageRentalRecords : Form
    {
        private HardwareRentalEntities hardwareRentalEntities; 
        public ManageRentalRecords()
        {
            InitializeComponent();
            hardwareRentalEntities = new HardwareRentalEntities();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            var addEditRecord = new AddEditRecord();
            addEditRecord.Show();
            addEditRecord.MdiParent = this.MdiParent;
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //Get id of selected row
                var id = (int)dgRecordList.SelectedRows[0].Cells["id"].Value;

                //query db for row matching id
                var record = hardwareRentalEntities.HardwareRentalRecords.FirstOrDefault(query => query.id == id);

                //launch with queried row data
                var addEditRecord = new AddEditRecord(record);                
                addEditRecord.Show();
                addEditRecord.MdiParent = this.MdiParent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }; 
        }

        private void btnDelRecord_Click(object sender, EventArgs e)
        {
            try
            {
                //Get id of selected row
                var id = (int)dgRecordList.SelectedRows[0].Cells["id"].Value;

                //query db for row matching id
                var record = hardwareRentalEntities.HardwareRentalRecords.FirstOrDefault(query => query.id == id);

                //delete row from db
                hardwareRentalEntities.HardwareRentalRecords.Remove(record);
                hardwareRentalEntities.SaveChanges();

                PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ManageRentalRecords_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        private void PopulateGrid()
        {
            var records = hardwareRentalEntities.HardwareRentalRecords.Select(query => new
            {
                //Get details of record and the hardware from linked table
                Customer = query.CustName,
                DateOut = query.DateRented,
                DateIn = query.DateReturned,
                id = query.id,
                Cost = query.Cost,
                Hardware = query.TypesOfHardware.Type
            }).ToList();
            dgRecordList.DataSource = records;
            dgRecordList.Columns["DateOut"].HeaderText = "Date Out";
            dgRecordList.Columns["DateIn"].HeaderText = "Date In";
            dgRecordList.Columns["id"].Visible = false;
        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
    }
}
