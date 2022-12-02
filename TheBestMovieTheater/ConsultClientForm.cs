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
    /// This form will show the manager the list of client registered.
    /// </summary>
    public partial class ConsultClientForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultClientForm"/> class.
        /// </summary>
        public ConsultClientForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method happens when the form is loaded, it will activate the binding method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsultClientForm_Load(object sender, EventArgs e)
        {
            this.BindListView();
        }

        /// <summary>
        /// This method will load the data from the Client table in the DB and bind it to the listview.
        /// </summary>
        private void BindListView()
        {
            DataTable clientTable = this.clientTableAdapter.GetData();

            ListViewHelper.ListViewHeaders(clientTable, this.clientListView);
            ListViewHelper.ListViewData(clientTable, this.clientListView);
            ListViewHelper.ListViewColumnAutoSize(clientTable, this.clientListView);
        }

        /// <summary>
        /// This button closes the Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
