namespace DesktopApp
{
    partial class ViewShippers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboShippers = new System.Windows.Forms.ComboBox();
            this.btnLookupShippers = new System.Windows.Forms.Button();
            this.ShipperID = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnAdShipper = new System.Windows.Forms.Button();
            this.btnUpdateShipper = new System.Windows.Forms.Button();
            this.btnDeleteShipper = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shippers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shipper ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Company Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // cboShippers
            // 
            this.cboShippers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShippers.FormattingEnabled = true;
            this.cboShippers.Location = new System.Drawing.Point(77, 1);
            this.cboShippers.Name = "cboShippers";
            this.cboShippers.Size = new System.Drawing.Size(121, 21);
            this.cboShippers.TabIndex = 5;
            // 
            // btnLookupShippers
            // 
            this.btnLookupShippers.Location = new System.Drawing.Point(205, 1);
            this.btnLookupShippers.Name = "btnLookupShippers";
            this.btnLookupShippers.Size = new System.Drawing.Size(121, 23);
            this.btnLookupShippers.TabIndex = 6;
            this.btnLookupShippers.Text = "Lookup Shippers";
            this.btnLookupShippers.UseVisualStyleBackColor = true;
            this.btnLookupShippers.Click += new System.EventHandler(this.btnLookupShippers_Click);
            // 
            // ShipperID
            // 
            this.ShipperID.AutoSize = true;
            this.ShipperID.Location = new System.Drawing.Point(163, 39);
            this.ShipperID.Name = "ShipperID";
            this.ShipperID.Size = new System.Drawing.Size(35, 13);
            this.ShipperID.TabIndex = 7;
            this.ShipperID.Text = "label5";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(98, 66);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(98, 99);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 9;
            // 
            // btnAdShipper
            // 
            this.btnAdShipper.Location = new System.Drawing.Point(15, 144);
            this.btnAdShipper.Name = "btnAdShipper";
            this.btnAdShipper.Size = new System.Drawing.Size(75, 23);
            this.btnAdShipper.TabIndex = 10;
            this.btnAdShipper.Text = "Add Shipper";
            this.btnAdShipper.UseVisualStyleBackColor = true;
            this.btnAdShipper.Click += new System.EventHandler(this.btnAdShipper_Click);
            // 
            // btnUpdateShipper
            // 
            this.btnUpdateShipper.Location = new System.Drawing.Point(123, 144);
            this.btnUpdateShipper.Name = "btnUpdateShipper";
            this.btnUpdateShipper.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateShipper.TabIndex = 11;
            this.btnUpdateShipper.Text = "Update Shipper";
            this.btnUpdateShipper.UseVisualStyleBackColor = true;
            this.btnUpdateShipper.Click += new System.EventHandler(this.btnUpdateShipper_Click);
            // 
            // btnDeleteShipper
            // 
            this.btnDeleteShipper.Location = new System.Drawing.Point(219, 144);
            this.btnDeleteShipper.Name = "btnDeleteShipper";
            this.btnDeleteShipper.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteShipper.TabIndex = 12;
            this.btnDeleteShipper.Text = "Delete Shipper";
            this.btnDeleteShipper.UseVisualStyleBackColor = true;
            this.btnDeleteShipper.Click += new System.EventHandler(this.btnDeleteShipper_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(314, 144);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(75, 23);
            this.btnClearForm.TabIndex = 13;
            this.btnClearForm.Text = "Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // ViewShippers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 416);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnDeleteShipper);
            this.Controls.Add(this.btnUpdateShipper);
            this.Controls.Add(this.btnAdShipper);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.ShipperID);
            this.Controls.Add(this.btnLookupShippers);
            this.Controls.Add(this.cboShippers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ViewShippers";
            this.Text = "ViewShippers";
            this.Load += new System.EventHandler(this.ViewShippers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboShippers;
        private System.Windows.Forms.Button btnLookupShippers;
        private System.Windows.Forms.Label ShipperID;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnAdShipper;
        private System.Windows.Forms.Button btnUpdateShipper;
        private System.Windows.Forms.Button btnDeleteShipper;
        private System.Windows.Forms.Button btnClearForm;
    }
}