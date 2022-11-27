using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            DataTable movie = this.movieTableAdapter.GetData();

            ListViewHelper.ListViewHeaders(movie, this.MovieListView);

            ListViewHelper.ListViewData(movie, this.MovieListView);
        }
    }
}
