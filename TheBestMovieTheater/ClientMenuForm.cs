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
    /// <summary>
    /// This is the base menu form for clients.
    /// </summary>
    public partial class ClientMenuForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMenuForm"/> class.
        /// </summary>
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
    }
}
