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
    public partial class ShowtimeModifyForm : Form
    {
        public ShowtimeModifyForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowtimeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.showtimeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tBMT_DBDataSetLocal);

        }

        private void ShowtimeModifyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tBMT_DBDataSetLocal.Showtime' table. You can move, or remove it, as needed.
            this.showtimeTableAdapter.Fill(this.tBMT_DBDataSetLocal.Showtime);

        }
    }
}
