using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class GuestListView : Form
    {
        public bool listformClosed;
        private FormStates state;
        private Collection<Person> persons;
        private Person person;
        private PersonController personController;
        private Role.RoleType rolevalue;
        public enum FormStates
        {
            View = 0,
            Edit = 1,
            Delete = 2,
        }
        public Role.RoleType role
        {
            set { rolevalue = value; }
        }
        public GuestListView(PersonController personcontroller)
        {
            InitializeComponent();
        
            personController = personcontroller;
            this.Load += GuestListView_Load;
            this.Activated += GuestListView_Activated;
            this.FormClosed += GuestListView_FormClosed;
            state = FormStates.View;


        }
        private void GuestListView_FormClosed(object sender, FormClosedEventArgs e)
        {
            listformClosed = true;
        }
        private void GuestListView_Load(object sender, EventArgs e)
        {
            listViewGuests.View = View.Details;
        }
        private void GuestListView_Activated(object sender, EventArgs e)
        {
            listViewGuests.View = View.Details;
            setGuestListview();
            Showall(false);
        }



        #region Utillity Methods
        private void Showall(bool value)
        {
            GuestIDlbl.Visible = value;
            Namelbl.Visible = value;
            //lblPersonalID.Visible = value;
            Emaillbl.Visible = value;
            Phonelbl.Visible = value;
            Addresslbl.Visible = value;
            CCnoLbl.Visible = value;
                   
            txtGuestID.Visible = value;
            txtName.Visible = value;
            //txtPersonalID.Visible = value;
            txtPhone.Visible = value;
            txtCCNumber.Visible = value;
            txtAddress.Visible = value;
            txtEmail.Visible = value;
            if(state==FormStates.Delete)
            {
                btnConfirm.Visible=! value;
                brnCancel.Visible = !value;
                
            }
            else
            {
                btnConfirm.Visible = value;
                brnCancel.Visible = value;
            }
           // deleteButton.Visible = value;
            //editButton.Visible = value;
        }
        private void EnableEntries(bool value)
        {
            if(state==FormStates.Edit)
            {
                txtGuestID.Enabled = !value;
               // txtPersonalID.Enabled = !value;
            }
            else
            {
                txtGuestID.Enabled = value;
               // txtPersonalID.Enabled = value;
            }
            txtAddress.Enabled = value;
            txtEmail.Enabled = value;
            txtName.Enabled = value;
            txtPhone.Enabled = value;
            txtCCNumber.Enabled = value;
            
            if (state == FormStates.Delete)
            {
                btnConfirm.Visible = !value;
                brnCancel.Visible = !value;
            }
            else
            {
                btnConfirm.Visible = value;
                brnCancel.Visible = value;
            }
        
    }
        private void ClearAll()
        {
            txtAddress.Text = "";
            //txtPersonalID.Text = "";
            txtEmail.Text = "";
            txtGuestID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtCCNumber.Text = "";

        }


        private void Populatetextboxes(Person person)
        {
            Guest guest;
             txtGuestID.Text = person.ID;
            //txtPersonalID.Text = person.PersonalId;
             txtName.Text= person.Name;
             txtEmail.Text= person.Email;
             txtPhone.Text = person.Phone;

            if(person.role.getRoleValue==Role.RoleType.Guest)
            {
                guest = (Guest)(person.role);
                txtAddress.Text = guest.Address;
                txtCCNumber.Text = guest.CreditCardNu;

            }
            

        }
       
        private void PopulateObject(Role.RoleType roleType)
        {
            Guest guest;
            person = new Person(roleType);
            person.ID = txtGuestID.Text;
            person.Name = txtName.Text;
           // person.PersonalId = txtPersonalID.Text;
            person.Phone = txtPhone.Text;
            person.Email = txtEmail.Text;

            if(person.role.getRoleValue==Role.RoleType.Guest)
            {
                guest = (Guest)(person.role);
                guest.Address = txtAddress.Text;
                guest.CreditCardNu = txtCCNumber.Text;
            }


        }
        public void setGuestListview()
        {
            ListViewItem guestDetails;
            Guest guest;
            listViewGuests.Clear();

            listViewGuests.Columns.Insert(0, "GuestID", 120, HorizontalAlignment.Left);
            listViewGuests.Columns.Insert(1, "Full Name", 120, HorizontalAlignment.Left);
            listViewGuests.Columns.Insert(2, "Personal ID", 120, HorizontalAlignment.Left);
            listViewGuests.Columns.Insert(3, "Phone", 120, HorizontalAlignment.Left);
            listViewGuests.Columns.Insert(4, "Email", 120, HorizontalAlignment.Left);
            listViewGuests.Columns.Insert(5, "Address", 120, HorizontalAlignment.Left);
            listViewGuests.Columns.Insert(6, "Credit Card Number", 120, HorizontalAlignment.Left);
            persons = personController.AllPeople;

            foreach(Person aperson in persons)
            {   if(aperson.role.getRoleValue == Role.RoleType.Guest)
                {
                    guestDetails = new ListViewItem();
                    guestDetails.Text = aperson.ID.ToString();
                    guestDetails.SubItems.Add(aperson.Name.ToString());
                    guestDetails.SubItems.Add(aperson.PersonalId.ToString());
                    guestDetails.SubItems.Add(aperson.Phone.ToString());
                    guestDetails.SubItems.Add(aperson.Email.ToString());
                    if (aperson.role.getRoleValue == Role.RoleType.Guest)
                    {
                        guest = (Guest)aperson.role;
                        guestDetails.SubItems.Add(guest.Address);
                        guestDetails.SubItems.Add(guest.CreditCardNu);
                    }

                    listViewGuests.Items.Add(guestDetails);
                }
            }

            listViewGuests.Refresh();
            listViewGuests.GridLines = true;

        }
        private void listViewGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            Showall(true);
            state = FormStates.View;
            EnableEntries(false);
            if (listViewGuests.SelectedItems.Count > 0)
            {
                person = personController.Find(listViewGuests.SelectedItems[0].Text);

                Populatetextboxes(person);
            }


        }
        private void editButton_Click(object sender, EventArgs e)
        {
            state = FormStates.Edit;
            EnableEntries(true);
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            PopulateObject(rolevalue);
            Data.PersonDB.DBOperation operation;
            if (txtGuestID.Text == " " || txtAddress.Text == "" || txtCCNumber.Text == "" || txtEmail.Text == "" || txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Please make sure all fields are completed before committing changes", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if(txtPhone.Text.Length != 10)
            {
                MessageBox.Show("Invalid phone number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(txtCCNumber.Text.Length != 16)
            {
                MessageBox.Show("Invalid Credit Card Number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (state == FormStates.Edit)
                {
                    operation = Data.PersonDB.DBOperation.Edit;
                    personController.DataMaintenance(person, operation);
                    personController.FinalizeChanges(person, operation);

                }
                else if(state==FormStates.Delete)
                {
                    operation = Data.PersonDB.DBOperation.Delete;
                    personController.DataMaintenance(person, Data.PersonDB.DBOperation.Delete);
                    personController.FinalizeChanges(person, Data.PersonDB.DBOperation.Delete); ;
                }
              
                ClearAll();
                state = FormStates.View;
                setGuestListview();
            }


        }


        private void brnCancel_Click(object sender, EventArgs e)
        {
            
            ClearAll();
            state = FormStates.View;
            Showall(false);
            setGuestListview();


        }
       
        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            state = FormStates.Delete;
            EnableEntries(false);
           
        }

      
    }
}
