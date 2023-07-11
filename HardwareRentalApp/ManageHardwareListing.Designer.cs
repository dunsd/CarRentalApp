namespace HardwareRentalApp
{
    partial class ManageHardwareListing
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
            this.dgHardwareList = new System.Windows.Forms.DataGridView();
            this.lblManageListing = new System.Windows.Forms.Label();
            this.btnAddHardware = new System.Windows.Forms.Button();
            this.btnEditHardware = new System.Windows.Forms.Button();
            this.btnDelHardware = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHardwareList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHardwareList
            // 
            this.dgHardwareList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHardwareList.Location = new System.Drawing.Point(59, 126);
            this.dgHardwareList.Name = "dgHardwareList";
            this.dgHardwareList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHardwareList.Size = new System.Drawing.Size(544, 207);
            this.dgHardwareList.TabIndex = 0;
            // 
            // lblManageListing
            // 
            this.lblManageListing.AutoSize = true;
            this.lblManageListing.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageListing.Location = new System.Drawing.Point(54, 96);
            this.lblManageListing.Name = "lblManageListing";
            this.lblManageListing.Size = new System.Drawing.Size(264, 27);
            this.lblManageListing.TabIndex = 3;
            this.lblManageListing.Text = "Manage Hardware Listing";
            // 
            // btnAddHardware
            // 
            this.btnAddHardware.Location = new System.Drawing.Point(628, 126);
            this.btnAddHardware.Name = "btnAddHardware";
            this.btnAddHardware.Size = new System.Drawing.Size(100, 38);
            this.btnAddHardware.TabIndex = 4;
            this.btnAddHardware.Text = "Add New Hardware";
            this.btnAddHardware.UseVisualStyleBackColor = true;
            this.btnAddHardware.Click += new System.EventHandler(this.btnAddHardware_Click);
            // 
            // btnEditHardware
            // 
            this.btnEditHardware.Location = new System.Drawing.Point(628, 211);
            this.btnEditHardware.Name = "btnEditHardware";
            this.btnEditHardware.Size = new System.Drawing.Size(100, 38);
            this.btnEditHardware.TabIndex = 5;
            this.btnEditHardware.Text = "Edit Hardware";
            this.btnEditHardware.UseVisualStyleBackColor = true;
            this.btnEditHardware.Click += new System.EventHandler(this.btnEditHardware_Click);
            // 
            // btnDelHardware
            // 
            this.btnDelHardware.Location = new System.Drawing.Point(628, 295);
            this.btnDelHardware.Name = "btnDelHardware";
            this.btnDelHardware.Size = new System.Drawing.Size(100, 38);
            this.btnDelHardware.TabIndex = 6;
            this.btnDelHardware.Text = "Delete Hardware";
            this.btnDelHardware.UseVisualStyleBackColor = true;
            this.btnDelHardware.Click += new System.EventHandler(this.btnDelHardware_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(59, 368);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ManageHardwareListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 477);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelHardware);
            this.Controls.Add(this.btnEditHardware);
            this.Controls.Add(this.btnAddHardware);
            this.Controls.Add(this.lblManageListing);
            this.Controls.Add(this.dgHardwareList);
            this.Name = "ManageHardwareListing";
            this.Text = "Manage Hardware Listing";
            this.Load += new System.EventHandler(this.ManageHardwareListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHardwareList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHardwareList;
        private System.Windows.Forms.Label lblManageListing;
        private System.Windows.Forms.Button btnAddHardware;
        private System.Windows.Forms.Button btnEditHardware;
        private System.Windows.Forms.Button btnDelHardware;
        private System.Windows.Forms.Button btnRefresh;
    }
}