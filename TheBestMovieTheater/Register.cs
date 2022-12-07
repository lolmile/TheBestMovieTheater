// <copyright file="Register.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TheBestMovieTheater
{
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

    /// <summary>
    /// This Form takes the input from the client and if the info is alright, stores it in the data base.
    /// </summary>
    public partial class Register : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Register"/> class.
        /// </summary>
        public Register()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Verifies the information then enters the client data in the database.
        /// </summary>
        /// <param name="sender">The button that was clicked.</param>
        /// <param name="e">Additional event arguments.</param>
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Client newClient = new Client();
            int validate = 0;
            DateTime now = DateTime.Now;

            newClient.FirstName = this.firstNameTextBox.Text;
            newClient.LastName = this.lastNameTextBox.Text;
            newClient.EmailAddress = this.emailTextBox.Text;
            newClient.Username = this.newUsernameTextBox.Text;
            newClient.Password = this.newPasswordTextBox.Text;

            // Verify the firstname so it is at least 2 characters.
            if (newClient.FirstName.Length > 2)
            {
                validate++;
                this.firstNameTextBox.BackColor = Color.White;
            }
            else
            {
                this.firstNameTextBox.BackColor = Color.Red;
            }

            // Verify last name so it is at least 2 characters
            if (newClient.LastName.Length > 2)
            {
                validate++;
                this.lastNameTextBox.BackColor = Color.White;
            }
            else
            {
                this.lastNameTextBox.BackColor = Color.Red;
            }

            // Verify email to only accept valid emails
            if (newClient.EmailAddress.Contains("@"))
            {
                string[] email;

                email = newClient.EmailAddress.Split('@', '.');

                if (email[0].Length > 2 && email[1].Length > 2 && email[2].Length > 1)
                {
                    validate++;
                    this.emailTextBox.BackColor = Color.White;
                }
                else
                {
                    this.emailTextBox.BackColor = Color.Red;
                }
            }
            else
            {
                this.emailTextBox.BackColor = Color.Red;
            }

            // Verify new username is at least 2 characters
            if (newClient.Username.Length > 2)
            {
                validate++;
                this.newUsernameTextBox.BackColor = Color.White;
            }
            else
            {
                this.newUsernameTextBox.BackColor = Color.Red;
            }

            // Verify password is at least 2 characters long
            if (newClient.Password.Length > 2)
            {
                validate++;
                this.newPasswordTextBox.BackColor = Color.White;
            }
            else
            {
                this.newPasswordTextBox.BackColor = Color.Red;
            }

            // Verify that the Client did not do any mistakes in his password creation
            if (this.repeatPasswordTextBox.Text == newClient.Password)
            {
                validate++;
                this.repeatPasswordTextBox.BackColor = Color.White;
            }
            else
            {
                this.repeatPasswordTextBox.BackColor = Color.Red;
            }

            // If all verifications are ok, we verify if the name exists in both manager and client table, then we create the enter for the DB table and close the Form
            if (validate == 6)
            {
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\TBMT\\TBMT_DB.mdf;Integrated Security=True;Connect Timeout=30");

                SqlDataAdapter clientCommand = new SqlDataAdapter("SELECT COUNT(*) FROM Client WHERE Username ='" + newClient.Username + "'", conn);
                SqlDataAdapter managerCommand = new SqlDataAdapter("SELECT COUNT(*) FROM Manager WHERE Username ='" + newClient.Username + "'", conn);
                DataTable ct = new DataTable();
                clientCommand.Fill(ct);

                DataTable mt = new DataTable();
                managerCommand.Fill(mt);

                if (ct.Rows[0][0].ToString() == "1" || mt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("'" + newClient.Username + "'" + " already exists, use another username please!");
                }
                else
                {
                TBMT_DBDataSetLocalTableAdapters.ClientTableAdapter clientTableAdapter = new TBMT_DBDataSetLocalTableAdapters.ClientTableAdapter();
                clientTableAdapter.Insert(newClient.FirstName, newClient.LastName, newClient.EmailAddress, newClient.Username, newClient.Password, now, null);

                this.Close();
                }
            }
        }
    }
}
