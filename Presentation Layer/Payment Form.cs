using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhumlaKamnandi.Business;
using PhumlaKamnandi.Data;

namespace PhumlaKamnandi.Presentation_Layer
{
    
    public partial class Payment_Form : Form
    {
        Booking booking;
        BookingController bookingController;
        Reserve reserve;
        public Payment_Form(Reserve Reserve)
        {
            InitializeComponent();
            reserve = Reserve;
            bookingController = new BookingController();
        }
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you wish to cancel this current booking?\n\n **All changes won't be saved**", "Cancel", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                homePage.Show();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Booking_Form booking_Form = new Booking_Form(reserve);
            this.Hide();
            booking_Form.ShowDialog();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {
           

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
