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
    public partial class MovieModifyForm : Form
    {
        public MovieModifyForm()
        {
            InitializeComponent();
        }

        private void movieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tBMT_DBDataSet);

        }

        private void MovieModifyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tBMT_DBDataSet.Movie' table. You can move, or remove it, as needed.
            //this.movieTableAdapter.Fill(this.tBMT_DBDataSet.Movie);

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ManagerMenuForm managerForm = new ManagerMenuForm();
            managerForm.Show();
        }
    }
}
