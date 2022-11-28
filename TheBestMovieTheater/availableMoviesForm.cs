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

        private void BindShowtimeComboBox()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\TBMT\\TBMT_DB.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT Showtime from Showtime", conn);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                this.showtimeComboBox.Items.Add(dr[0].ToString());
            }

            dr.Close();
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

        private void moviesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string movieId = null;

            string movie = this.moviesComboBox.SelectedItem.ToString();

            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\TBMT\\TBMT_DB.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT MovieID from Movie WHERE Title = '" + movie + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                movieId = dr[0].ToString();
            }

            SqlCommand getShowtimeId = new SqlCommand("SELECT ShowtimeID from MovieInfoBridge WHERE MovieID = '" + movieId + "'", conn);
            dr = getShowtimeId.ExecuteReader();

            while (dr.Read())
            {
                string showtimeId = dr[0].ToString();

                SqlCommand getShowtime = new SqlCommand("SELECT Showtime from Showtime WHERE ShowtimeID = '" + showtimeId + "'", conn);
                dr = getShowtime.ExecuteReader();

            }


            while (dr.Read())
            {
                this.showtimeComboBox.Items.Add(dr[0].ToString());

            }
            dr.Close();

        }
    }
}
