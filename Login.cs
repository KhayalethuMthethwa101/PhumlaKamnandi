using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhumlaKamnandi.Presentation_Layer;
using PhumlaKamnandi.Business;

namespace PhumlaKamnandi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        HomePage homePage = new HomePage();
        Reserve reserve = new Reserve();
        

        private void Login_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void UserNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if ((UserNametxt.Text != "") && (Passwordtxt.Text != ""))
            {
               
                // Replace with your actual authentication logic here
                string enteredUsername = UserNametxt.Text;
                string enteredPassword = Passwordtxt.Text;

                // Example: Check if the entered username and password match some predefined values
                if (enteredUsername == "samu" && enteredPassword == "samu")
                {
                   
                    // Create an instance of the homepage form
                    HomePage homepageForm = new HomePage();

                    // Hide the login form
                    this.Hide();

                    // Show the homepage form
                    homepageForm.Show();


                }
                else
                {
                    MessageBox.Show("Login failed. Please check your credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            else
            {
                MessageBox.Show("Please complete all fields before proceeding", "Incomplete Login", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                Loginbtn.PerformClick();
            }
        }
    }
}
