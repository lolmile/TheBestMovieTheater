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
    public partial class availableMoviesForm : Form
    {
        public availableMoviesForm()
        {
            InitializeComponent();
        }

        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\TBMT\\TBMT_DB.mdf;Integrated Security=True;Connect Timeout=30";

        /// <summary>
        /// Converts the DB data to put into a listbox.
        /// </summary>
        public void ConvertToList()
        {
            using (SqlConnection dbconn = new SqlConnection(this.conn)) {

                dbconn.Open();
                string cmdString = "SELECT";

                SqlCommand cmd = new SqlCommand(cmdString, dbconn);

                SqlDataReader reader = cmd.ExecuteReader();

            }

        }
    }
}
