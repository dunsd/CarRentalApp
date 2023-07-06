﻿namespace HardwareRentalApp
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
            ((System.ComponentModel.ISupportInitialize)(this.dgHardwareList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHardwareList
            // 
            this.dgHardwareList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHardwareList.Location = new System.Drawing.Point(267, 127);
            this.dgHardwareList.Name = "dgHardwareList";
            this.dgHardwareList.Size = new System.Drawing.Size(259, 207);
            this.dgHardwareList.TabIndex = 0;
            // 
            // lblManageListing
            // 
            this.lblManageListing.AutoSize = true;
            this.lblManageListing.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageListing.Location = new System.Drawing.Point(262, 97);
            this.lblManageListing.Name = "lblManageListing";
            this.lblManageListing.Size = new System.Drawing.Size(264, 27);
            this.lblManageListing.TabIndex = 3;
            this.lblManageListing.Text = "Manage Hardware Listing";
            // 
            // btnAddHardware
            // 
            this.btnAddHardware.Location = new System.Drawing.Point(592, 127);
            this.btnAddHardware.Name = "btnAddHardware";
            this.btnAddHardware.Size = new System.Drawing.Size(100, 38);
            this.btnAddHardware.TabIndex = 4;
            this.btnAddHardware.Text = "Add New Hardware";
            this.btnAddHardware.UseVisualStyleBackColor = true;
            this.btnAddHardware.Click += new System.EventHandler(this.btnAddHardware_Click);
            // 
            // btnEditHardware
            // 
            this.btnEditHardware.Location = new System.Drawing.Point(592, 212);
            this.btnEditHardware.Name = "btnEditHardware";
            this.btnEditHardware.Size = new System.Drawing.Size(100, 38);
            this.btnEditHardware.TabIndex = 5;
            this.btnEditHardware.Text = "Edit Hardware";
            this.btnEditHardware.UseVisualStyleBackColor = true;
            this.btnEditHardware.Click += new System.EventHandler(this.btnEditHardware_Click);
            // 
            // btnDelHardware
            // 
            this.btnDelHardware.Location = new System.Drawing.Point(592, 296);
            this.btnDelHardware.Name = "btnDelHardware";
            this.btnDelHardware.Size = new System.Drawing.Size(100, 38);
            this.btnDelHardware.TabIndex = 6;
            this.btnDelHardware.Text = "Delete Hardware";
            this.btnDelHardware.UseVisualStyleBackColor = true;
            this.btnDelHardware.Click += new System.EventHandler(this.btnDelHardware_Click);
            // 
            // ManageHardwareListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelHardware);
            this.Controls.Add(this.btnEditHardware);
            this.Controls.Add(this.btnAddHardware);
            this.Controls.Add(this.lblManageListing);
            this.Controls.Add(this.dgHardwareList);
            this.Name = "ManageHardwareListing";
            this.Text = "ManageHardwareListing";
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
    }
}