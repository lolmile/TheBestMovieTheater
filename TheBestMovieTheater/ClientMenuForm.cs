using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBestMovieTheater
{
    public partial class ClientMenuForm : Form
    {
        public ClientMenuForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens available movie form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void availableMovieButton_Click(object sender, EventArgs e)
        {
            availableMoviesForm availableMoviesForm= new availableMoviesForm();
            availableMoviesForm.ShowDialog();
        }
    }
}
