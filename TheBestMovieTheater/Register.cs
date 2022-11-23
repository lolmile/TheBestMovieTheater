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

        SqlConnection conn = new SqlConnection("Data Source=CRCL-CST-027;Initial Catalog=TBMT_DB;Integrated Security=True");

        private void registerButton_Click(object sender, EventArgs e)
        {
            int validate = 0;
            DateTime now = DateTime.Now;

            // Verify the firstname so it is at least 2 characters.
            if (firstNameTextBox.Text.Length > 2)
            {
                validate++;
                firstNameTextBox.BackColor = Color.White;
            }
            else
            {
                firstNameTextBox.BackColor = Color.Red;
            }

            // Verify last name so it is at least 2 charachters
            if (lastNameTextBox.Text.Length > 2)
            {
                validate++;
                lastNameTextBox.BackColor = Color.White;
            }
            else
            {
                lastNameTextBox.BackColor = Color.Red;
            }

            // Verify email to only accept valid emails
            if (emailTextBox.Text.Contains("@")) {

                string[] email;

                email = emailTextBox.Text.Split('@', '.');

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

            if (newUsernameTextBox.Text.Length > 2)
            {
                validate++;
                newUsernameTextBox.BackColor = Color.White;
            }
            else
            {
                newUsernameTextBox.BackColor = Color.Red;
            }

            if (newPasswordTextBox.Text.Length > 2)
            {
                validate++;
                newPasswordTextBox.BackColor = Color.White;
            }
            else
            {
                newPasswordTextBox.BackColor = Color.Red;
            }

            if (newPasswordTextBox.Text == repeatPasswordTextBox.Text)
            {
                validate++;
                repeatPasswordTextBox.BackColor = Color.White;
            }
            else
            {
                repeatPasswordTextBox.BackColor = Color.Red;
            }

            if (validate == 6)
            {

                TBMT_DBDataSetTableAdapters.ClientTableAdapter clientTableAdapter = new TBMT_DBDataSetTableAdapters.ClientTableAdapter();
                clientTableAdapter.Insert(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, newUsernameTextBox.Text, newPasswordTextBox.Text, now, null);

                this.Close();
            }


        }
    }
}
