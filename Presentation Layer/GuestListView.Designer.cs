
namespace PhumlaKamnandi.Presentation_Layer
{
    partial class GuestListView
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
            this.listViewGuests = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CCnoLbl = new System.Windows.Forms.Label();
            this.txtCCNumber = new System.Windows.Forms.TextBox();
            this.brnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.Addresslbl = new System.Windows.Forms.Label();
            this.Phonelbl = new System.Windows.Forms.Label();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.GuestIDlbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewGuests
            // 
            this.listViewGuests.HideSelection = false;
            this.listViewGuests.Location = new System.Drawing.Point(2, 88);
            this.listViewGuests.Name = "listViewGuests";
            this.listViewGuests.Size = new System.Drawing.Size(786, 203);
            this.listViewGuests.TabIndex = 0;
            this.listViewGuests.UseCompatibleStateImageBehavior = false;
            this.listViewGuests.SelectedIndexChanged += new System.EventHandler(this.listViewGuests_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.CCnoLbl);
            this.groupBox1.Controls.Add(this.txtCCNumber);
            this.groupBox1.Controls.Add(this.brnCancel);
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtGuestID);
            this.groupBox1.Controls.Add(this.Addresslbl);
            this.groupBox1.Controls.Add(this.Phonelbl);
            this.groupBox1.Controls.Add(this.Emaillbl);
            this.groupBox1.Controls.Add(this.GuestIDlbl);
            this.groupBox1.Controls.Add(this.Namelbl);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(2, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 262);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guest Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CCnoLbl
            // 
            this.CCnoLbl.AutoSize = true;
            this.CCnoLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCnoLbl.Location = new System.Drawing.Point(409, 130);
            this.CCnoLbl.Name = "CCnoLbl";
            this.CCnoLbl.Size = new System.Drawing.Size(142, 20);
            this.CCnoLbl.TabIndex = 51;
            this.CCnoLbl.Text = "Credit Card Number";
            // 
            // txtCCNumber
            // 
            this.txtCCNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCNumber.Location = new System.Drawing.Point(571, 125);
            this.txtCCNumber.Name = "txtCCNumber";
            this.txtCCNumber.Size = new System.Drawing.Size(187, 25);
            this.txtCCNumber.TabIndex = 50;
            // 
            // brnCancel
            // 
            this.brnCancel.BackColor = System.Drawing.Color.Transparent;
            this.brnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnCancel.ForeColor = System.Drawing.Color.Black;
            this.brnCancel.Location = new System.Drawing.Point(182, 200);
            this.brnCancel.Name = "brnCancel";
            this.brnCancel.Size = new System.Drawing.Size(133, 39);
            this.brnCancel.TabIndex = 19;
            this.brnCancel.Text = "Cancel";
            this.brnCancel.UseVisualStyleBackColor = false;
            this.brnCancel.Click += new System.EventHandler(this.brnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(475, 200);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(133, 39);
            this.btnConfirm.TabIndex = 18;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(158, 130);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(187, 25);
            this.txtAddress.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(507, 69);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(187, 25);
            this.txtPhone.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(475, 25);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 25);
            this.txtEmail.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(158, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 25);
            this.txtName.TabIndex = 6;
            // 
            // txtGuestID
            // 
            this.txtGuestID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestID.Location = new System.Drawing.Point(158, 41);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(100, 25);
            this.txtGuestID.TabIndex = 5;
            // 
            // Addresslbl
            // 
            this.Addresslbl.AutoSize = true;
            this.Addresslbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addresslbl.Location = new System.Drawing.Point(10, 121);
            this.Addresslbl.Name = "Addresslbl";
            this.Addresslbl.Size = new System.Drawing.Size(62, 20);
            this.Addresslbl.TabIndex = 4;
            this.Addresslbl.Text = "Address";
            // 
            // Phonelbl
            // 
            this.Phonelbl.AutoSize = true;
            this.Phonelbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonelbl.Location = new System.Drawing.Point(409, 69);
            this.Phonelbl.Name = "Phonelbl";
            this.Phonelbl.Size = new System.Drawing.Size(78, 20);
            this.Phonelbl.TabIndex = 3;
            this.Phonelbl.Text = "Telephone";
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.Location = new System.Drawing.Point(409, 25);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(46, 20);
            this.Emaillbl.TabIndex = 2;
            this.Emaillbl.Text = "Email";
            // 
            // GuestIDlbl
            // 
            this.GuestIDlbl.AutoSize = true;
            this.GuestIDlbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestIDlbl.Location = new System.Drawing.Point(10, 46);
            this.GuestIDlbl.Name = "GuestIDlbl";
            this.GuestIDlbl.Size = new System.Drawing.Size(61, 20);
            this.GuestIDlbl.TabIndex = 1;
            this.GuestIDlbl.Text = "GuestID";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(10, 80);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(76, 20);
            this.Namelbl.TabIndex = 0;
            this.Namelbl.Text = "Full Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(410, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "All Guests";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhumlaKamnandi.Properties.Resources.PKLogo;
            this.pictureBox1.Location = new System.Drawing.Point(2, -72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 154);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // GuestListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(783, 607);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewGuests);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "GuestListView";
            this.Text = "Guest View";
            this.Activated += new System.EventHandler(this.GuestListView_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GuestListView_FormClosed);
            this.Load += new System.EventHandler(this.GuestListView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewGuests;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Phonelbl;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.Label GuestIDlbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Label Addresslbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button brnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label CCnoLbl;
        private System.Windows.Forms.TextBox txtCCNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}