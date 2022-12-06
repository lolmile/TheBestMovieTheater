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
        /// Readonly SQL connection string.
        /// </summary>
        private readonly SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\TBMT\\TBMT_DB.mdf;Integrated Security=True;Connect Timeout=30");

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
            SqlDataAdapter command = new SqlDataAdapter("SELECT Title,Genre,Minutes,Year from Movie WHERE FirstShowingDate <= GETDATE()", this.conn);
            DataTable movieTable = new DataTable();
            command.Fill(movieTable);

            ListViewHelper.ListViewHeaders(movieTable, this.availableMoviesListView);
            ListViewHelper.ListViewData(movieTable, this.availableMoviesListView);
            ListViewHelper.ListViewColumnAutoSize(movieTable, this.availableMoviesListView);
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
            this.showtimeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Binds movie titles from DB to the comboBox.
        /// </summary>
        private void BindMovieComboBox()
        {
            try
            {
                this.conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT Title from Movie WHERE FirstShowingDate <= GETDATE()", this.conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.moviesComboBox.Items.Add(dr[0].ToString());
                }

                dr.Close();
                this.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.moviesComboBox.SelectedIndex = 0;
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
                conn.Close();
                stId = showtimeId.ToArray();

                if (stId.Length == 0)
                {
                    this.showtimeComboBox.Items.Add("No showtime available");
                }
                else
                {
                    this.showtimeComboBox.Items.AddRange(stId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.showtimeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Purchase button takes the movie selected with the selected showtime and creates a message to validate the ticket bought. Also handles errors if a non-available movie is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void purchaseButton_Click(object sender, EventArgs e)
        {
            decimal cost = 0;
            string movie = this.moviesComboBox.SelectedItem.ToString();
            string showtime = this.showtimeComboBox.SelectedItem.ToString();

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

            if (this.childRadioButton.Checked == true)
            {
                cost = decimal.Parse(priceArray[0]);
            }

            if (this.adultRadioButton.Checked == true)
            {
                cost = decimal.Parse(priceArray[1]);
            }

            if (this.studentRadioButton.Checked == true)
            {
                cost = decimal.Parse(priceArray[2]);
            }

            if (this.elderRadioButton.Checked == true)
            {
                cost = decimal.Parse(priceArray[3]);
            }

            if (this.showtimeComboBox.SelectedItem.ToString() == "No showtime available")
            {
                MessageBox.Show("Sorry the Movie is not available yet");
            }
            else
            {
                MessageBox.Show("Thank you for buying a ticket for " + movie + "\n" + "Cost: " + cost + "$" + "\n" + "Time: " + showtime);
            }
        }
    }
}
