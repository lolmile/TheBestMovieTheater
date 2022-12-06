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
    /// The upcoming movie form will show movies that have firstShowingDates later than the current date.
    /// </summary>
    public partial class UpcomingMoviesForm : Form
    {
        public UpcomingMoviesForm()
        {
            InitializeComponent();
            BindMovieListView();
        }

        /// <summary>
        /// Binds the movies that have a first showing date later than the current date to the list view.
        /// </summary>
        private void BindMovieListView()
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\TBMT\\TBMT_DB.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter command = new SqlDataAdapter("SELECT Title,Genre,Minutes,Year from Movie WHERE FirstShowingDate > GETDATE()", conn);
            DataTable movieTable = new DataTable();
            command.Fill(movieTable);

            ListViewHelper.ListViewHeaders(movieTable, this.upcomingMovieListView);
            ListViewHelper.ListViewData(movieTable, this.upcomingMovieListView);
            ListViewHelper.ListViewColumnAutoSize(movieTable, this.upcomingMovieListView);
        }

        /// <summary>
        /// Closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
