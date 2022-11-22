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
    public partial class ManagerMenuForm : Form
    {
        private string consultSelection;
        private string modifySelection;

        public ManagerMenuForm()
        {
            InitializeComponent();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            switch (this.viewsComboBox.SelectedIndex)
            {
                case 0:
                    this.consultSelection = this.viewsComboBox.SelectedItem.ToString();
                    MessageBox.Show(this.consultSelection);
                    break;
                case 1:
                    this.consultSelection = this.viewsComboBox.SelectedItem.ToString();
                    MessageBox.Show(this.consultSelection);
                    break;
                case 2:
                    this.consultSelection = this.viewsComboBox.SelectedItem.ToString();
                    MessageBox.Show(this.consultSelection);
                    break;
                default:
                    // No selection do nothing.
                    break;    
            } 
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            switch (this.modifyComboBox.SelectedIndex)
            {
                case 0:
                    this.modifySelection = this.modifyComboBox.SelectedItem.ToString();
                    MessageBox.Show(this.modifySelection);
                    break;
                case 1:
                    this.modifySelection = this.modifyComboBox.SelectedItem.ToString();
                    MessageBox.Show(this.modifySelection);
                    break;
                case 2:
                    this.modifySelection = this.modifyComboBox.SelectedItem.ToString();
                    MessageBox.Show(this.modifySelection);
                    break;
                case 3:
                    this.modifySelection = this.modifyComboBox.SelectedItem.ToString();
                    MessageBox.Show(this.modifySelection);
                    break;
                default:
                    // Do Nothing
                    break;
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
