using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhumlaKamnandi.Business;

namespace PhumlaKamnandi.Presentation_Layer
{
    public partial class HomePage : Form
    {
        private Collection<Guest> guests = new Collection<Guest>();
        private Reserve guest;
        private BookingController bookingcontroller;
        private PersonController personController;
        GuestListView guestListView;
        BookingsListView bookingsListView;
      
        public HomePage()
        {
            InitializeComponent();
            guest = new Reserve();
            personController = new PersonController();
            bookingcontroller = new BookingController();
            
            
        }
       

        private void HomePage_Load(object sender, EventArgs e)
        {
        }

        private void existingBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exsitingBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        #region New Booking
        private void txtGuestID_Enter(object sender, EventArgs e)
        {
            if (txtGuestID.Text == "Enter Guest ID")
            {
                txtGuestID.Text = "";
                txtGuestID.ForeColor = Color.White;
            }
        }
        private void txtGuestID_Leave(object sender, EventArgs e)
        {
            if (txtGuestID.Text == "")
            {
                txtGuestID.Text = "Enter Guest ID";
                txtGuestID.ForeColor = Color.White;
            }
        }

       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Person person;
            Guest aguest;
            
            GuestDetails guestDetails = new GuestDetails();
            try
            {
                string id = txtGuestID.Text;
                person = guest.FindGuest(id);
                 aguest = (Guest)person.role;
                if(id==null)
                {
                    MessageBox.Show("Please enter a GuestID to search", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (guest.FindGuest(id)==null||aguest==null||person==null)
                {
                    MessageBox.Show("Unfortunately Guest does not exist in Phumla Kamnandi's System", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                
                    this.Hide();
                    guestDetails.ShowDialog();
                }
            }catch(FormatException)
            {
                MessageBox.Show("Ensure that all fields are filled in", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }


            
        }
        #endregion

        private void btnNotification_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You currently have 2 unread notifications.", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #region Add Guest
        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            Add_Guest add_Guest = new Add_Guest(guest);
            this.Hide();
            add_Guest.ShowDialog();
        }
        #endregion

        #region Guest Listform
        private void CreatnewGuestForm()
        {
            guestListView = new GuestListView(personController);

        }


        private void btnGuests_Click(object sender, EventArgs e)
        {
            // Check if the GuestsListView form hasn't been created or has been closed.
            if (guestListView==null)
            {
                CreatnewGuestForm();
            }
            if(guestListView.listformClosed)
            {
                // Create a new instance of the form if needed.
                CreatnewGuestForm();
            }
            // Set the role for the GuestsListView form to guest.
            guestListView.role = Role.RoleType.Guest;
            // Set up and display the GuestsListView form for managing guest information.
            guestListView.setGuestListview();
            guestListView.Show();
        }
        #endregion

        #region Booking ListForm
        private void CreatenewBookingForm()
        {
            bookingsListView = new BookingsListView(guest);
        }
        private void btnBooking_Click(object sender, EventArgs e)
        {
            // Check if the BookingsListView form hasn't been created or has been closed.
            if (bookingsListView==null)
            {
                CreatenewBookingForm(); // Create a new instance of the form if needed.
            }
            if(bookingsListView.listformclosed)
            {
                CreatenewBookingForm();
            }
            // Set up and display the BookingsListView form for managing bookings.
            bookingsListView.setupBookingsListview();
            bookingsListView.Show();
        }
        #endregion

        /// <summary>
        /// Event handler for the button click event that allows the user to log out.
        /// </summary>
 
        #region Logout
        private void button3_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you wish to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                login.Show();
            }
        }
        #endregion

        private void txtGuestID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMonthlyReports_Click(object sender, EventArgs e)
        {
            Hotel_Services monthlyReports = new Hotel_Services();
            this.Hide();
            monthlyReports.ShowDialog();
        }
    }
}
