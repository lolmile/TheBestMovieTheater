using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TheBestMovieTheater
{
    /// <summary>
    /// This is a form to show different sales information selected with movies or showtimes.
    /// </summary>
    public partial class TicketInfoForm : Form
    {
        /// <summary>
        /// SQL connection string.
        /// </summary>
        private readonly SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\TBMT\\TBMT_DB.mdf;Integrated Security=True;Connect Timeout=30");

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketInfoForm"/> class.
        /// </summary>
        public TicketInfoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the form is loaded, each comboBox loads their different values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TicketInfoForm_Load(object sender, EventArgs e)
        {
            this.BindMovies();
            this.BindShowtimes();
        }

        /// <summary>
        /// Binds the movie to the comboBox.
        /// </summary>
        private void BindMovies()
        {
            try
            {
                this.conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT Title from Movie WHERE FirstShowingDate <= GETDATE()", this.conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.movieComboBox.Items.Add(dr[0].ToString());
                }

                this.conn.Close();
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Binds the showtimes to the comboBox.
        /// </summary>
        private void BindShowtimes()
        {
            try
            {
                this.conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT Showtime from Showtime", this.conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.showtimeComboBox.Items.Add(dr[0].ToString());
                }

                dr.Close();
                this.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Whenever a option is changed in the movieComboBox, it displays the amount of tickets bought at this time and the total revenue made.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movieComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> ticketList = new List<string>();
            string[] ticketArray;
            string movie = this.movieComboBox.SelectedItem.ToString();

            this.selectedMovieLabel.Text = this.movieComboBox.SelectedItem.ToString();
            this.conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT COUNT(TicketID) AS TOTAL, sum(case when PriceID = '1' then 1 else 0 end) AS Child, sum(case when PriceID = '2' then 1 else 0 end) AS Adult, sum(case when PriceID = '3' then 1 else 0 end) AS Student, sum(case when PriceId = '4' then 1 else 0 end) AS Elder FROM Ticket T INNER JOIN Movie M ON T.MovieID = M.MovieID Where M.Title = '" + movie + "'", this.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    ticketList.Add(dr[0].ToString());
                    ticketList.Add(dr[1].ToString());
                    ticketList.Add(dr[2].ToString());
                    ticketList.Add(dr[3].ToString());
                    ticketList.Add(dr[4].ToString());
                }
            }
            finally
            {
                dr.Close();
                this.conn.Close();
            }

            ticketArray = ticketList.ToArray();

            this.movieTotalTicketLabel.Text = ticketArray[0] + " Tickets";
            this.movieChildrenTicketLabel.Text = ticketArray[1] + " Tickets";
            this.movieAdultTicketLabel.Text = ticketArray[2] + " Tickets";
            this.movieStudentTicketLabel.Text = ticketArray[3] + " Tickets";
            this.movieElderTicketLabel.Text = ticketArray[4] + " Tickets";

            decimal childTotal = decimal.Parse(ticketArray[1]);
            decimal adultTotal = decimal.Parse(ticketArray[2]);
            decimal studentTotal = decimal.Parse(ticketArray[3]);
            decimal elderTotal = decimal.Parse(ticketArray[4]);

            this.movieTotalRevenueLabel.Text = this.CalculateTotalRevenue(childTotal, adultTotal, studentTotal, elderTotal);
        }

        /// <summary>
        /// Whenever a option is changed in the showtimeComboBox, it displays the amount of tickets bought at this time and the total revenue made.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showtimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string showtime = this.showtimeComboBox.SelectedItem.ToString();
            List<string> ticketList = new List<string>();
            string[] ticketArray;
            this.showtimeTotalRevenueLabel.Text = "";

            this.selectedShowtimeLabel.Text = showtime;

            this.conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(TicketID) AS TOTAL, sum(case when PriceID = '1' then 1 else 0 end) AS Child, sum(case when PriceID = '2' then 1 else 0 end) AS Adult, sum(case when PriceID = '3' then 1 else 0 end) AS Student, sum(case when PriceId = '4' then 1 else 0 end) AS Elder FROM Ticket T INNER JOIN Showtime S ON T.ShowtimeID = S.ShowtimeID Where S.Showtime = '" + showtime + "'", this.conn);
            SqlDataReader dr = cmd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    ticketList.Add(dr[0].ToString());
                    ticketList.Add(dr[1].ToString());
                    ticketList.Add(dr[2].ToString());
                    ticketList.Add(dr[3].ToString());
                    ticketList.Add(dr[4].ToString());
                }
            }
            finally
            {
            dr.Close();
            this.conn.Close();
            }

            ticketArray = ticketList.ToArray();

            this.showtimeTotalTicketSoldLabel.Text = ticketArray[0] + " Tickets";
            this.showtimeChildrenTicketLabel.Text = ticketArray[1] + " Tickets";
            this.showtimeAdultTicketLabel.Text = ticketArray[2] + " Tickets";
            this.showtimeStudentTicketLabel.Text = ticketArray[3] + " Tickets";
            this.showtimeElderTicketLabel.Text = ticketArray[4] + " Tickets";

            try
            {
                decimal childTotal = decimal.Parse(ticketArray[1]);
                decimal adultTotal = decimal.Parse(ticketArray[2]);
                decimal studentTotal = decimal.Parse(ticketArray[3]);
                decimal elderTotal = decimal.Parse(ticketArray[4]);

                this.showtimeTotalRevenueLabel.Text = this.CalculateTotalRevenue(childTotal, adultTotal, studentTotal, elderTotal);
            }
            catch (Exception)
            {
                MessageBox.Show("No ticket available for this showtime");
            }
        }

        /// <summary>
        /// Calculates total revenue for the number of tickets given in each category.
        /// </summary>
        /// <param name="childTotal">Number of tickets bought who were children.</param>
        /// <param name="adultTotal">Number of tickets bought who were adults.</param>
        /// <param name="studentTotal">Number of tickets bought who were students.</param>
        /// <param name="elderTotal">Number of tickets bought who were elders.</param>
        /// <returns>Returns the total revenue for the amount of tickets bought.</returns>
        private string CalculateTotalRevenue(decimal childTotal, decimal adultTotal, decimal studentTotal, decimal elderTotal)
        {
            List<string> priceList = new List<string>();
            string[] priceArray;
            decimal totalRevenue;

            this.conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select Price From Price", this.conn);
            SqlDataReader de = cmd1.ExecuteReader();

            while (de.Read())
            {
                priceList.Add(de[0].ToString());
            }

            de.Close();
            this.conn.Close();

            priceArray = priceList.ToArray();

            decimal childTicketPrice = decimal.Parse(priceArray[0]);
            decimal adultTicketPrice = decimal.Parse(priceArray[1]);
            decimal studentTicketPrice = decimal.Parse(priceArray[2]);
            decimal elderTicketPrice = decimal.Parse(priceArray[3]);

            totalRevenue = (childTotal * childTicketPrice) + (adultTotal * adultTicketPrice) + (studentTotal * studentTicketPrice) + (elderTotal * elderTicketPrice);

            return totalRevenue.ToString("c");
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
    }
}
