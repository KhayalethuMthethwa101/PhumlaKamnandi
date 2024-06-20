
namespace PhumlaKamnandi.Presentation_Layer
{
    partial class HomePage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnNotification = new System.Windows.Forms.Button();
            this.btnMonthlyReports = new System.Windows.Forms.Button();
            this.btnGuests = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnAddGuest);
            this.panel1.Controls.Add(this.btnBooking);
            this.panel1.Controls.Add(this.btnMonthlyReports);
            this.panel1.Location = new System.Drawing.Point(-11, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 86);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhumlaKamnandi.Properties.Resources.PKLogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, -71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 170);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(693, 23);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(86, 33);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGuest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGuest.ForeColor = System.Drawing.Color.Navy;
            this.btnAddGuest.Location = new System.Drawing.Point(271, 23);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(101, 39);
            this.btnAddGuest.TabIndex = 7;
            this.btnAddGuest.Text = "New Guest";
            this.btnAddGuest.UseVisualStyleBackColor = false;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(472, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 29);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtGuestID
            // 
            this.txtGuestID.BackColor = System.Drawing.Color.Red;
            this.txtGuestID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestID.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtGuestID.Location = new System.Drawing.Point(254, 109);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(212, 29);
            this.txtGuestID.TabIndex = 7;
            this.txtGuestID.Text = "Enter Guest ID";
            this.txtGuestID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuestID.TextChanged += new System.EventHandler(this.txtGuestID_TextChanged);
            this.txtGuestID.Enter += new System.EventHandler(this.txtGuestID_Enter);
            this.txtGuestID.Leave += new System.EventHandler(this.txtGuestID_Leave);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBooking.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.Black;
            this.btnBooking.Location = new System.Drawing.Point(395, 23);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(101, 36);
            this.btnBooking.TabIndex = 4;
            this.btnBooking.Text = "Bookings";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnNotification
            // 
            this.btnNotification.BackColor = System.Drawing.Color.Transparent;
            this.btnNotification.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotification.ForeColor = System.Drawing.Color.Black;
            this.btnNotification.Location = new System.Drawing.Point(370, 163);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(116, 28);
            this.btnNotification.TabIndex = 5;
            this.btnNotification.Text = "Notifications";
            this.btnNotification.UseVisualStyleBackColor = false;
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // btnMonthlyReports
            // 
            this.btnMonthlyReports.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMonthlyReports.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlyReports.ForeColor = System.Drawing.Color.Black;
            this.btnMonthlyReports.Location = new System.Drawing.Point(502, 25);
            this.btnMonthlyReports.Name = "btnMonthlyReports";
            this.btnMonthlyReports.Size = new System.Drawing.Size(101, 34);
            this.btnMonthlyReports.TabIndex = 6;
            this.btnMonthlyReports.Text = "Monthy Reports";
            this.btnMonthlyReports.UseVisualStyleBackColor = false;
            this.btnMonthlyReports.Click += new System.EventHandler(this.btnMonthlyReports_Click);
            // 
            // btnGuests
            // 
            this.btnGuests.BackColor = System.Drawing.Color.Transparent;
            this.btnGuests.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuests.ForeColor = System.Drawing.Color.Black;
            this.btnGuests.Location = new System.Drawing.Point(261, 161);
            this.btnGuests.Name = "btnGuests";
            this.btnGuests.Size = new System.Drawing.Size(85, 30);
            this.btnGuests.TabIndex = 8;
            this.btnGuests.Text = "Guests";
            this.btnGuests.UseVisualStyleBackColor = false;
            this.btnGuests.Click += new System.EventHandler(this.btnGuests_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PhumlaKamnandi.Properties.Resources.hotel_1___Copy;
            this.pictureBox2.Location = new System.Drawing.Point(33, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(199, 271);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnNotification);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtGuestID);
            this.Controls.Add(this.btnGuests);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.Button btnMonthlyReports;
        private System.Windows.Forms.Button btnGuests;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}