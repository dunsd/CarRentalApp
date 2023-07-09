namespace HardwareRentalApp
{
    partial class ManageRentalRecords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelRecord = new System.Windows.Forms.Button();
            this.btnEditHardware = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.lblManageRecords = new System.Windows.Forms.Label();
            this.dgRecordList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecordList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(77, 363);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelRecord
            // 
            this.btnDelRecord.Location = new System.Drawing.Point(624, 290);
            this.btnDelRecord.Name = "btnDelRecord";
            this.btnDelRecord.Size = new System.Drawing.Size(100, 38);
            this.btnDelRecord.TabIndex = 12;
            this.btnDelRecord.Text = "Delete Record";
            this.btnDelRecord.UseVisualStyleBackColor = true;
            this.btnDelRecord.Click += new System.EventHandler(this.btnDelRecord_Click);
            // 
            // btnEditHardware
            // 
            this.btnEditHardware.Location = new System.Drawing.Point(624, 206);
            this.btnEditHardware.Name = "btnEditHardware";
            this.btnEditHardware.Size = new System.Drawing.Size(100, 38);
            this.btnEditHardware.TabIndex = 11;
            this.btnEditHardware.Text = "Edit Record";
            this.btnEditHardware.UseVisualStyleBackColor = true;
            this.btnEditHardware.Click += new System.EventHandler(this.btnEditRecord_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(624, 121);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(100, 38);
            this.btnAddRecord.TabIndex = 10;
            this.btnAddRecord.Text = "Add New Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // lblManageRecords
            // 
            this.lblManageRecords.AutoSize = true;
            this.lblManageRecords.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageRecords.Location = new System.Drawing.Point(72, 91);
            this.lblManageRecords.Name = "lblManageRecords";
            this.lblManageRecords.Size = new System.Drawing.Size(243, 27);
            this.lblManageRecords.TabIndex = 9;
            this.lblManageRecords.Text = "Manage Rental Records";
            // 
            // dgRecordList
            // 
            this.dgRecordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecordList.Location = new System.Drawing.Point(77, 121);
            this.dgRecordList.Name = "dgRecordList";
            this.dgRecordList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRecordList.Size = new System.Drawing.Size(518, 207);
            this.dgRecordList.TabIndex = 8;
            // 
            // ManageRentalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelRecord);
            this.Controls.Add(this.btnEditHardware);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.lblManageRecords);
            this.Controls.Add(this.dgRecordList);
            this.Name = "ManageRentalRecords";
            this.Text = "Manage Rental Records";
            this.Load += new System.EventHandler(this.ManageRentalRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRecordList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelRecord;
        private System.Windows.Forms.Button btnEditHardware;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Label lblManageRecords;
        private System.Windows.Forms.DataGridView dgRecordList;
    }
}