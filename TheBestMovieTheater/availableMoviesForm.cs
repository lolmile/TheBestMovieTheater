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
using TheBestMovieTheater.TBMT_DBDataSetLocalTableAdapters;

namespace TheBestMovieTheater
{
    /// <summary>
    /// This Form will show available movies for clients and let them buy tickets.
    /// </summary>
    public partial class AvailableMoviesForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableMoviesForm"/> class.
        /// </summary>
        public AvailableMoviesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Converts the DB data to put into a listview.
        /// </summary>
        public void ConvertToList()
        {
            DataTable availableMovies = this.availableMoviesTableAdapter.GetData();

            ListViewHelper.ListViewHeaders(availableMovies, this.availableMoviesListView);
            ListViewHelper.ListViewData(availableMovies, this.availableMoviesListView);
        }

        /// <summary>
        /// Activates the Convert to List method whenever the form is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AvailableMoviesForm_Load(object sender, EventArgs e)
        {
            this.ConvertToList();
            this.BindMovieComboBox();
        }

        /// <summary>
        /// Binds movie titles from DB to the comboBox.
        /// </summary>
        private void BindMovieComboBox()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\TBMT\\TBMT_DB.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT Title from Movie", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                this.moviesComboBox.Items.Add(dr[0].ToString());
            }

            dr.Close();
            conn.Close();
        }

        /// <summary>
        /// Closes the Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Loades the right showtimes for any movie that is selected in the movieComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void moviesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.showtimeComboBox.Items.Clear();
            List<string> showtimeId = new List<string>();
            string[] stId= new string[2];
            string movieName = this.moviesComboBox.SelectedItem.ToString();

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\TBMT\\TBMT_DB.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("Select showtime From Showtime Where ShowtimeID IN (Select ShowtimeID From MovieInfoBridge Where MovieID IN (Select MovieID From Movie Where Title = '" + movieName + "'))", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    showtimeId.Add(dr[0].ToString());
                }

                dr.Close();
                stId = showtimeId.ToArray();
                this.showtimeComboBox.Items.AddRange(stId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void purchaseButton_Click(object sender, EventArgs e)
        {
            double cost = 0;

            string movie = this.moviesComboBox.SelectedItem.ToString();
            string showtime = this.showtimeComboBox.SelectedItem.ToString();

            if (this.childRadioButton.Checked == true)
            {
                cost = 4;
            }

            if (this.adultRadioButton.Checked == true)
            {
                cost = 15;
            }

            if (this.studentRadioButton.Checked == true)
            {
                cost = 10;
            }

            if (this.elderRadioButton.Checked == true)
            {
                cost = 10;
            }

            MessageBox.Show("Thank you for bying a ticket for " + movie + "\n" + "Cost: " + cost + "$" + "\n" + "Time: " + showtime);
        }
    }
}
