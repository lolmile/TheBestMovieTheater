using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBestMovieTheater
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        // database connection string
        private readonly SqlConnection conn = new SqlConnection("Data Source=CRCL-CST-027;Initial Catalog=TBMT_DB;Integrated Security=True");

        /// <summary>
        /// Verifies the information then enters the client data in the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registerButton_Click(object sender, EventArgs e)
        {
            Client newClient = new Client();
            int validate = 0;
            DateTime now = DateTime.Now;

            newClient.firstName = firstNameTextBox.Text;
            newClient.lastName = lastNameTextBox.Text;
            newClient.emailAddress = emailTextBox.Text;
            newClient.username = newUsernameTextBox.Text;
            newClient.password = newPasswordTextBox.Text;

            // Verify the firstname so it is at least 2 characters.
            if (newClient.firstName.Length > 2)
            {
                validate++;
                firstNameTextBox.BackColor = Color.White;
            }
            else
            {
                firstNameTextBox.BackColor = Color.Red;
            }

            // Verify last name so it is at least 2 characters
            if (newClient.lastName.Length > 2)
            {
                validate++;
                lastNameTextBox.BackColor = Color.White;
            }
            else
            {
                lastNameTextBox.BackColor = Color.Red;
            }

            // Verify email to only accept valid emails
            if (newClient.emailAddress.Contains("@")) {

                string[] email;

                email = newClient.emailAddress.Split('@', '.');

                if (email[0].Length > 2 && email[1].Length > 2 && email[2].Length > 1)
                {
                    validate++;
                    emailTextBox.BackColor = Color.White;
                }
                else
                {
                    emailTextBox.BackColor = Color.Red;
                }
            }
            else
            {
                emailTextBox.BackColor = Color.Red;
            }

            // Verify new username is at least 2 characters
            if (newClient.username.Length > 2)
            {
                validate++;
                newUsernameTextBox.BackColor = Color.White;
            }
            else
            {
                newUsernameTextBox.BackColor = Color.Red;
            }

            // Verify password is at least 2 characters long
            if (newClient.password.Length > 2)
            {
                validate++;
                newPasswordTextBox.BackColor = Color.White;
            }
            else
            {
                newPasswordTextBox.BackColor = Color.Red;
            }

            // Verify that the Client did not do any mistakes in his password creation
            if (repeatPasswordTextBox.Text == newClient.password)
            {
                validate++;
                repeatPasswordTextBox.BackColor = Color.White;
            }
            else
            {
                repeatPasswordTextBox.BackColor = Color.Red;
            }

            // If all verifications are ok, we create the enter for the DB table and close the Form
            if (validate == 6)
            {

                TBMT_DBDataSetTableAdapters.ClientTableAdapter clientTableAdapter = new TBMT_DBDataSetTableAdapters.ClientTableAdapter();
                clientTableAdapter.Insert(newClient.firstName, newClient.lastName, newClient.emailAddress, newClient.username, newClient.password, now, null);

                this.Close();
            }


        }
    }
}
