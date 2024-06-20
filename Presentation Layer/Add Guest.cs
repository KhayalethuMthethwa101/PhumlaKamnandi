using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhumlaKamnandi.Business;

namespace PhumlaKamnandi.Presentation_Layer
{
    
    public partial class Add_Guest : Form
    {
        private Reserve reserve;
        private Dictionary<int, string> comboSource = new Dictionary<int, string>();

        public Add_Guest(Reserve reserve)
        {

            InitializeComponent();
            this.reserve = reserve;
            SetUpCboCCC();
        }

        private void SetUpCboCCC()
        {
            Debug.WriteLine("Setting up cboccc...");
            comboSource = new Dictionary<int, string>();

         
            Collection<CreditCardCompany> companies = reserve.AllCreditCardCompanies();
            foreach (CreditCardCompany company in companies)
            {
                comboSource.Add(company.CCCID, company.CCCName);
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            DialogResult dialogResult;
            dialogResult = MessageBox.Show("Are you sure you wish to cancel making a new guest?", "Cancel", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(dialogResult==DialogResult.Yes)
            {
                this.Hide();
                homePage.Show();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (isValidInput())
            {   // Create a new Guest object
                Person person = new Person(Role.RoleType.Guest);
                Guest aguest = (Guest)person.role;
                string Name = txtName.Text;
                string Phone = txtPhone.Text;
                string email = txtEmail.Text;
                string personalID = txtPersonalID.Text;
                string address = txtAddress.Text;
                string ccNum = txtCCNum.Text;
                int expirationMonth = Convert.ToInt32(txtExpMonth.Text);
                int expirationYear = Convert.ToInt32(txtExpYear.Text);

                // Set the guest's properties
                person.Name = Name;
                person.Phone = Phone;
                person.Email = email;
                person.PersonalId = personalID;
                aguest.Address = address;
                aguest.CreditCardNu = ccNum;
                MessageBox.Show("Guest information added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BookingDatabase.mdf;Integrated Security=True";


                // SQL query to insert a new guest into the Guest table
                string sqlQuery = "INSERT INTO Guest (Name, PersonalID, Phone, Email, Address, CC_Number ) VALUES (@Name, @PersonalID, @Phone, @Email, @Address, @CC_Number)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        // Add parameters for guest data
                        command.Parameters.AddWithValue("@Name", Name);
                        command.Parameters.AddWithValue("@PersonalID", personalID);
                        command.Parameters.AddWithValue("@Phone", Phone);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@CC_Number", ccNum);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Guest added successfully
                            MessageBox.Show("Guest added to the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Handle the case where the guest could not be added
                            MessageBox.Show("Failed to add guest to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private bool isValidInput()
        {
            if (!isValidName())
            {
                return false;
            }
            else if (!isValidEmail())
            {
                return false;
            }
            else if (!isValidPhone())
            {
                return false;
            }

            else if (!isValidPersonalID())
            {
                return false;
            }

            else if (!isValidAddress()) {
                return false;
            }

            else if (!isValidCreditCardNumber())
            {
                return false;
            }

            else if (!isValidExpirationDate())
            {
                return false;
            }

            return true;
        }

        private bool isValidName()
        {
            string name = txtName.Text.TrimEnd();
            if (name.Length == 0)
            {
                DialogResult dialogResult;
                dialogResult= MessageBox.Show("Full name required\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool isValidEmail()
        {
            string email = txtEmail.Text.TrimEnd();
            if (!IsValidEmail(email))
            {
                DialogResult dialogResult = MessageBox.Show("Email must be valid\n", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool isValidPhone()
        {
            string phone = txtPhone.Text.TrimEnd();

            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Phone required", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (!phone.All(char.IsDigit))
            {
                MessageBox.Show("Phone must contain digits only", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (phone.Length != 10) 
            {
                MessageBox.Show("Phone must be 10 digits in length", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool isValidPersonalID()
        {
            string personalID = txtPersonalID.Text.TrimEnd();

            if (string.IsNullOrEmpty(personalID))
            {
                MessageBox.Show("Personal ID required", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (!personalID.All(char.IsDigit))
            {
                MessageBox.Show("Personal ID must contain digits only", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (personalID.Length != 13)
            {
                MessageBox.Show("Personal ID must be 13 digits in length", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool isValidAddress()
        {
            string address = txtAddress.Text.TrimEnd();

            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address required", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool isValidCreditCardNumber()
        {
            string ccNum = txtCCNum.Text.TrimEnd();

            if (string.IsNullOrEmpty(ccNum))
            {
                MessageBox.Show("Credit card number required", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (!ccNum.All(char.IsDigit))
            {
                MessageBox.Show("Credit card number must contain digits only", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (ccNum.Length != 16)
            {
                MessageBox.Show("Credit card number  must be 16 digits in length", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool isValidExpirationDate()
        {
            string expirationMonth = txtExpMonth.Text.TrimEnd();
            string expirationYear = txtExpYear.Text.TrimEnd();

            if (string.IsNullOrEmpty(expirationMonth))
            {
                MessageBox.Show("Expiration month required", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (!expirationMonth.All(char.IsDigit))
            {
                MessageBox.Show("Expiration month must contain digits only", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (string.IsNullOrEmpty(expirationYear))
            {
                MessageBox.Show("Expiration year required", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (!expirationYear.All(char.IsDigit))
            {
                MessageBox.Show("Expiration year must contain digits only", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            else if (!isNotExpired(expirationMonth, expirationYear))
            {
                MessageBox.Show("Credit card must not have expired", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private bool isNotExpired(String expirationMonth, String expirationYear)
        {
            if (Convert.ToInt32(expirationMonth) <= DateTime.Now.Month && Convert.ToInt32(expirationYear) <= DateTime.Now.Year)
            {
                return false;
            }

            return true;
        }

        private bool IsDigitsOnly(string str)
        {
            return !string.IsNullOrEmpty(str) && str.All(char.IsDigit);
        }

        private bool IsValidEmail(string email)
        {
            if (email.Trim().EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
