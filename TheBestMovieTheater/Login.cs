using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TheBestMovieTheater
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Verifies that the entered username and password match the database information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            int verif = 0;
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\TBMT\\TBMT_DB.mdf;Integrated Security=True;Connect Timeout=30");

                SqlDataAdapter command = new SqlDataAdapter("SELECT COUNT(*) FROM Manager WHERE Username ='" + usernameTextBox.Text + "' AND Password='" + passwordTextBox.Text + "'", conn);
                DataTable mt = new DataTable();
                command.Fill(mt);

                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Client WHERE Username ='" + usernameTextBox.Text + "' AND Password='" + passwordTextBox.Text + "'", conn);
                DataTable ct = new DataTable();
                sda.Fill(ct);
                if (ct.Rows[0][0].ToString() == "1")
                {
                    ClientMenuForm clientMenu = new ClientMenuForm();

                    verif++;


                    this.Hide();
                    clientMenu.ShowDialog();
                }

                if (mt.Rows[0][0].ToString() == "1")
                {
                    ManagerMenuForm managerMenu = new ManagerMenuForm();

                    verif++;

                    this.Hide();
                    managerMenu.ShowDialog();
                }

                if (verif != 1)
                {
                    MessageBox.Show("Wrong username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Opens the register form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void registerButton_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();

            registerForm.ShowDialog();
        }
    }
}
