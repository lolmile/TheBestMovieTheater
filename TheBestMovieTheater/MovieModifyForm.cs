using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace TheBestMovieTheater
{
    public partial class MovieModifyForm : Form
    {
        public MovieModifyForm()
        {
            InitializeComponent();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MovieModifyForm_Load(object sender, EventArgs e)
        {
            ListViewItem movieInfo;
            DataTable movie = this.movieTableAdapter.GetData();
            int movieRow = movie.Rows.Count;
            int movieColumn = movie.Columns.Count;
            string[] movieArray = new string[movieRow];


            for (int column = 0; column < movieColumn; column++)
            {
                this.MovieListView.Columns.Add(movie.Columns[column].ToString());

                for (int row = 0; row < movieRow; row++)
                {
                    movieArray[row] = movie.Rows[row][column].ToString();
                }

                movieInfo = new ListViewItem(movieArray);
                this.MovieListView.Items.Add(movieInfo);
            }
        }
    }
}
