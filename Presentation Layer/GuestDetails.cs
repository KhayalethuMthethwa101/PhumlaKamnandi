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

namespace PhumlaKamnandi.Presentation_Layer
{
    public partial class GuestDetails : Form

    {
       
        Reserve reserve;
        Booking_Form booking_Form;
        public GuestDetails()
        {
            InitializeComponent();
            reserve = new Reserve();
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();
        }

        private void GuestDetails_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Booking_Form newForm = new Booking_Form(reserve);
            newForm.ShowDialog();
        }
    }
}
