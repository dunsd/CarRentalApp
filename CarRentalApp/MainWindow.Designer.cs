namespace HardwareRentalApp
{
    partial class MainWindow
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
            this.lblMainWindow = new System.Windows.Forms.Label();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageHardwareListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRentalRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRentalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewArchiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRentalRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMainWindow
            // 
            this.lblMainWindow.AutoSize = true;
            this.lblMainWindow.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainWindow.Location = new System.Drawing.Point(485, 28);
            this.lblMainWindow.Name = "lblMainWindow";
            this.lblMainWindow.Size = new System.Drawing.Size(211, 31);
            this.lblMainWindow.TabIndex = 1;
            this.lblMainWindow.Text = "Main Window";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRecord.Location = new System.Drawing.Point(63, 125);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(146, 64);
            this.btnAddRecord.TabIndex = 2;
            this.btnAddRecord.Text = "Add Rental Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageHardwareListingToolStripMenuItem,
            this.manageRentalRecordsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1133, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageHardwareListingToolStripMenuItem
            // 
            this.manageHardwareListingToolStripMenuItem.Name = "manageHardwareListingToolStripMenuItem";
            this.manageHardwareListingToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.manageHardwareListingToolStripMenuItem.Text = "Manage Hardware Listing";
            this.manageHardwareListingToolStripMenuItem.Click += new System.EventHandler(this.manageHardwareListingToolStripMenuItem_Click);
            // 
            // manageRentalRecordsToolStripMenuItem
            // 
            this.manageRentalRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRentalRecordToolStripMenuItem,
            this.viewArchiveToolStripMenuItem,
            this.editRentalRecordToolStripMenuItem});
            this.manageRentalRecordsToolStripMenuItem.Name = "manageRentalRecordsToolStripMenuItem";
            this.manageRentalRecordsToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.manageRentalRecordsToolStripMenuItem.Text = "Manage Rental Records";
            // 
            // addRentalRecordToolStripMenuItem
            // 
            this.addRentalRecordToolStripMenuItem.Name = "addRentalRecordToolStripMenuItem";
            this.addRentalRecordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addRentalRecordToolStripMenuItem.Text = "Add Rental Record";
            this.addRentalRecordToolStripMenuItem.Click += new System.EventHandler(this.addRentalRecordToolStripMenuItem_Click);
            // 
            // viewArchiveToolStripMenuItem
            // 
            this.viewArchiveToolStripMenuItem.Name = "viewArchiveToolStripMenuItem";
            this.viewArchiveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewArchiveToolStripMenuItem.Text = "View Archive";
            // 
            // editRentalRecordToolStripMenuItem
            // 
            this.editRentalRecordToolStripMenuItem.Name = "editRentalRecordToolStripMenuItem";
            this.editRentalRecordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editRentalRecordToolStripMenuItem.Text = "Edit Rental Record";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 565);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.lblMainWindow);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Computer Hardware Rental";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainWindow;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageHardwareListingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRentalRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRentalRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewArchiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRentalRecordToolStripMenuItem;
    }
}