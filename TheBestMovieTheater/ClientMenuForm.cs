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
    /// <summary>
    /// This is the base menu form for clients.
    /// </summary>
    public partial class ClientMenuForm : Form
    {
        /// <summary>
        /// SQL connection string.
        /// </summary>
        private readonly SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\TBMT\\TBMT_DB.mdf;Integrated Security=True;Connect Timeout=30");

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMenuForm"/> class.
        /// </summary>
        public ClientMenuForm()
        {
            InitializeComponent();
            BindPrices();
        }

        /// <summary>
        /// Opens available movie form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void availableMovieButton_Click(object sender, EventArgs e)
        {
            AvailableMoviesForm availableMoviesForm= new AvailableMoviesForm();
            availableMoviesForm.ShowDialog();
        }

        /// <summary>
        /// Logs out the client back to the login Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logoutButton_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();

            this.Close();
        }

        /// <summary>
        /// Opens the Upcoming movies form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upcomingMoviesButton_Click(object sender, EventArgs e)
        {
            UpcomingMoviesForm upcomingMoviesForm = new UpcomingMoviesForm();
            upcomingMoviesForm.ShowDialog();
        }

        /// <summary>
        /// Binds prices to price lables.
        /// </summary>
        private void BindPrices()
        {
            List<string> priceList = new List<string>();
            string[] priceArray;

            this.conn.Open();

            SqlCommand cmd = new SqlCommand("Select Price From Price", this.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    priceList.Add(dr[0].ToString());
                }
            }
            finally
            {
                dr.Close();
                this.conn.Close();
            }

            priceArray = priceList.ToArray();

            this.price1Label.Text = priceArray[0] + "$";
            this.price2Label.Text = priceArray[1] + "$";
            this.price3Label.Text = priceArray[2] + "$";
            this.price4Label.Text = priceArray[3] + "$";
        }
    }
}
