namespace TheBestMovieTheater
{
    partial class TicketInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MovieTheatreLabel = new System.Windows.Forms.Label();
            this.UserTitleLabel = new System.Windows.Forms.Label();
            this.movieComboBox = new System.Windows.Forms.ComboBox();
            this.showtimeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mTitleLabel2 = new System.Windows.Forms.Label();
            this.mTitleLabel1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mTitleLabel3 = new System.Windows.Forms.Label();
            this.mTitleLabel4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mTitleLabel5 = new System.Windows.Forms.Label();
            this.showtimeInfoLabel4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.showtimeInfoLabel3 = new System.Windows.Forms.Label();
            this.showtimeInfoLabel2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.showtimeLabel = new System.Windows.Forms.Label();
            this.showtimeInfoLabel1 = new System.Windows.Forms.Label();
            this.selectedMovieLabel = new System.Windows.Forms.Label();
            this.selectedShowtimeLabel = new System.Windows.Forms.Label();
            this.showtimeChildrenTicketLabel = new System.Windows.Forms.Label();
            this.showtimeAdultTicketLabel = new System.Windows.Forms.Label();
            this.showtimeStudentTicketLabel = new System.Windows.Forms.Label();
            this.showtimeElderTicketLabel = new System.Windows.Forms.Label();
            this.showtimeTotalTicketSoldLabel = new System.Windows.Forms.Label();
            this.showtimeTotalRevenueLabel = new System.Windows.Forms.Label();
            this.movieChildrenTicketLabel = new System.Windows.Forms.Label();
            this.movieAdultTicketLabel = new System.Windows.Forms.Label();
            this.movieStudentTicketLabel = new System.Windows.Forms.Label();
            this.movieElderTicketLabel = new System.Windows.Forms.Label();
            this.movieTotalTicketLabel = new System.Windows.Forms.Label();
            this.movieTotalRevenueLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MovieTheatreLabel
            // 
            this.MovieTheatreLabel.AutoSize = true;
            this.MovieTheatreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTheatreLabel.Location = new System.Drawing.Point(219, 9);
            this.MovieTheatreLabel.Name = "MovieTheatreLabel";
            this.MovieTheatreLabel.Size = new System.Drawing.Size(325, 31);
            this.MovieTheatreLabel.TabIndex = 1;
            this.MovieTheatreLabel.Text = "The Best Movie Theater";
            this.MovieTheatreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserTitleLabel
            // 
            this.UserTitleLabel.AutoSize = true;
            this.UserTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTitleLabel.Location = new System.Drawing.Point(120, 69);
            this.UserTitleLabel.Name = "UserTitleLabel";
            this.UserTitleLabel.Size = new System.Drawing.Size(204, 25);
            this.UserTitleLabel.TabIndex = 2;
            this.UserTitleLabel.Text = "Tickets Sold by Movie";
            this.UserTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieComboBox
            // 
            this.movieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.movieComboBox.FormattingEnabled = true;
            this.movieComboBox.Location = new System.Drawing.Point(138, 97);
            this.movieComboBox.Name = "movieComboBox";
            this.movieComboBox.Size = new System.Drawing.Size(176, 24);
            this.movieComboBox.TabIndex = 3;
            this.movieComboBox.SelectedIndexChanged += new System.EventHandler(this.movieComboBox_SelectedIndexChanged);
            // 
            // showtimeComboBox
            // 
            this.showtimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showtimeComboBox.FormattingEnabled = true;
            this.showtimeComboBox.Location = new System.Drawing.Point(477, 97);
            this.showtimeComboBox.Name = "showtimeComboBox";
            this.showtimeComboBox.Size = new System.Drawing.Size(176, 24);
            this.showtimeComboBox.TabIndex = 5;
            this.showtimeComboBox.SelectedIndexChanged += new System.EventHandler(this.showtimeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tickets Sold by Showtime";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mTitleLabel2
            // 
            this.mTitleLabel2.AutoSize = true;
            this.mTitleLabel2.Location = new System.Drawing.Point(107, 184);
            this.mTitleLabel2.Name = "mTitleLabel2";
            this.mTitleLabel2.Size = new System.Drawing.Size(59, 16);
            this.mTitleLabel2.TabIndex = 6;
            this.mTitleLabel2.Text = "Children:";
            // 
            // mTitleLabel1
            // 
            this.mTitleLabel1.AutoSize = true;
            this.mTitleLabel1.Location = new System.Drawing.Point(89, 135);
            this.mTitleLabel1.Name = "mTitleLabel1";
            this.mTitleLabel1.Size = new System.Drawing.Size(107, 16);
            this.mTitleLabel1.TabIndex = 7;
            this.mTitleLabel1.Text = "Movie Selected :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Revenue:";
            // 
            // mTitleLabel3
            // 
            this.mTitleLabel3.AutoSize = true;
            this.mTitleLabel3.Location = new System.Drawing.Point(107, 213);
            this.mTitleLabel3.Name = "mTitleLabel3";
            this.mTitleLabel3.Size = new System.Drawing.Size(40, 16);
            this.mTitleLabel3.TabIndex = 9;
            this.mTitleLabel3.Text = "Adult:";
            // 
            // mTitleLabel4
            // 
            this.mTitleLabel4.AutoSize = true;
            this.mTitleLabel4.Location = new System.Drawing.Point(107, 242);
            this.mTitleLabel4.Name = "mTitleLabel4";
            this.mTitleLabel4.Size = new System.Drawing.Size(55, 16);
            this.mTitleLabel4.TabIndex = 10;
            this.mTitleLabel4.Text = "Student:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total Ticket Sold:";
            // 
            // mTitleLabel5
            // 
            this.mTitleLabel5.AutoSize = true;
            this.mTitleLabel5.Location = new System.Drawing.Point(107, 270);
            this.mTitleLabel5.Name = "mTitleLabel5";
            this.mTitleLabel5.Size = new System.Drawing.Size(42, 16);
            this.mTitleLabel5.TabIndex = 12;
            this.mTitleLabel5.Text = "Elder:";
            // 
            // showtimeInfoLabel4
            // 
            this.showtimeInfoLabel4.AutoSize = true;
            this.showtimeInfoLabel4.Location = new System.Drawing.Point(462, 270);
            this.showtimeInfoLabel4.Name = "showtimeInfoLabel4";
            this.showtimeInfoLabel4.Size = new System.Drawing.Size(42, 16);
            this.showtimeInfoLabel4.TabIndex = 19;
            this.showtimeInfoLabel4.Text = "Elder:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(431, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Total Ticket Sold:";
            // 
            // showtimeInfoLabel3
            // 
            this.showtimeInfoLabel3.AutoSize = true;
            this.showtimeInfoLabel3.Location = new System.Drawing.Point(462, 242);
            this.showtimeInfoLabel3.Name = "showtimeInfoLabel3";
            this.showtimeInfoLabel3.Size = new System.Drawing.Size(55, 16);
            this.showtimeInfoLabel3.TabIndex = 17;
            this.showtimeInfoLabel3.Text = "Student:";
            // 
            // showtimeInfoLabel2
            // 
            this.showtimeInfoLabel2.AutoSize = true;
            this.showtimeInfoLabel2.Location = new System.Drawing.Point(462, 213);
            this.showtimeInfoLabel2.Name = "showtimeInfoLabel2";
            this.showtimeInfoLabel2.Size = new System.Drawing.Size(40, 16);
            this.showtimeInfoLabel2.TabIndex = 16;
            this.showtimeInfoLabel2.Text = "Adult:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(444, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 16);
            this.label13.TabIndex = 15;
            this.label13.Text = "Total Revenue:";
            // 
            // showtimeLabel
            // 
            this.showtimeLabel.AutoSize = true;
            this.showtimeLabel.Location = new System.Drawing.Point(431, 135);
            this.showtimeLabel.Name = "showtimeLabel";
            this.showtimeLabel.Size = new System.Drawing.Size(128, 16);
            this.showtimeLabel.TabIndex = 14;
            this.showtimeLabel.Text = "Showtime Selected :";
            // 
            // showtimeInfoLabel1
            // 
            this.showtimeInfoLabel1.AutoSize = true;
            this.showtimeInfoLabel1.Location = new System.Drawing.Point(462, 184);
            this.showtimeInfoLabel1.Name = "showtimeInfoLabel1";
            this.showtimeInfoLabel1.Size = new System.Drawing.Size(59, 16);
            this.showtimeInfoLabel1.TabIndex = 13;
            this.showtimeInfoLabel1.Text = "Children:";
            // 
            // selectedMovieLabel
            // 
            this.selectedMovieLabel.AutoSize = true;
            this.selectedMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedMovieLabel.Location = new System.Drawing.Point(202, 135);
            this.selectedMovieLabel.Name = "selectedMovieLabel";
            this.selectedMovieLabel.Size = new System.Drawing.Size(0, 16);
            this.selectedMovieLabel.TabIndex = 20;
            // 
            // selectedShowtimeLabel
            // 
            this.selectedShowtimeLabel.AutoSize = true;
            this.selectedShowtimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedShowtimeLabel.Location = new System.Drawing.Point(565, 135);
            this.selectedShowtimeLabel.Name = "selectedShowtimeLabel";
            this.selectedShowtimeLabel.Size = new System.Drawing.Size(0, 16);
            this.selectedShowtimeLabel.TabIndex = 21;
            // 
            // showtimeChildrenTicketLabel
            // 
            this.showtimeChildrenTicketLabel.AutoSize = true;
            this.showtimeChildrenTicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimeChildrenTicketLabel.Location = new System.Drawing.Point(527, 184);
            this.showtimeChildrenTicketLabel.Name = "showtimeChildrenTicketLabel";
            this.showtimeChildrenTicketLabel.Size = new System.Drawing.Size(0, 16);
            this.showtimeChildrenTicketLabel.TabIndex = 22;
            // 
            // showtimeAdultTicketLabel
            // 
            this.showtimeAdultTicketLabel.AutoSize = true;
            this.showtimeAdultTicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimeAdultTicketLabel.Location = new System.Drawing.Point(508, 213);
            this.showtimeAdultTicketLabel.Name = "showtimeAdultTicketLabel";
            this.showtimeAdultTicketLabel.Size = new System.Drawing.Size(0, 16);
            this.showtimeAdultTicketLabel.TabIndex = 23;
            // 
            // showtimeStudentTicketLabel
            // 
            this.showtimeStudentTicketLabel.AutoSize = true;
            this.showtimeStudentTicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimeStudentTicketLabel.Location = new System.Drawing.Point(523, 242);
            this.showtimeStudentTicketLabel.Name = "showtimeStudentTicketLabel";
            this.showtimeStudentTicketLabel.Size = new System.Drawing.Size(0, 16);
            this.showtimeStudentTicketLabel.TabIndex = 24;
            // 
            // showtimeElderTicketLabel
            // 
            this.showtimeElderTicketLabel.AutoSize = true;
            this.showtimeElderTicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimeElderTicketLabel.Location = new System.Drawing.Point(507, 270);
            this.showtimeElderTicketLabel.Name = "showtimeElderTicketLabel";
            this.showtimeElderTicketLabel.Size = new System.Drawing.Size(0, 16);
            this.showtimeElderTicketLabel.TabIndex = 25;
            // 
            // showtimeTotalTicketSoldLabel
            // 
            this.showtimeTotalTicketSoldLabel.AutoSize = true;
            this.showtimeTotalTicketSoldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimeTotalTicketSoldLabel.Location = new System.Drawing.Point(549, 313);
            this.showtimeTotalTicketSoldLabel.Name = "showtimeTotalTicketSoldLabel";
            this.showtimeTotalTicketSoldLabel.Size = new System.Drawing.Size(0, 16);
            this.showtimeTotalTicketSoldLabel.TabIndex = 26;
            // 
            // showtimeTotalRevenueLabel
            // 
            this.showtimeTotalRevenueLabel.AutoSize = true;
            this.showtimeTotalRevenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimeTotalRevenueLabel.Location = new System.Drawing.Point(549, 340);
            this.showtimeTotalRevenueLabel.Name = "showtimeTotalRevenueLabel";
            this.showtimeTotalRevenueLabel.Size = new System.Drawing.Size(0, 16);
            this.showtimeTotalRevenueLabel.TabIndex = 27;
            // 
            // movieChildrenTicketLabel
            // 
            this.movieChildrenTicketLabel.AutoSize = true;
            this.movieChildrenTicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieChildrenTicketLabel.Location = new System.Drawing.Point(172, 184);
            this.movieChildrenTicketLabel.Name = "movieChildrenTicketLabel";
            this.movieChildrenTicketLabel.Size = new System.Drawing.Size(0, 16);
            this.movieChildrenTicketLabel.TabIndex = 28;
            // 
            // movieAdultTicketLabel
            // 
            this.movieAdultTicketLabel.AutoSize = true;
            this.movieAdultTicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieAdultTicketLabel.Location = new System.Drawing.Point(153, 213);
            this.movieAdultTicketLabel.Name = "movieAdultTicketLabel";
            this.movieAdultTicketLabel.Size = new System.Drawing.Size(0, 16);
            this.movieAdultTicketLabel.TabIndex = 29;
            // 
            // movieStudentTicketLabel
            // 
            this.movieStudentTicketLabel.AutoSize = true;
            this.movieStudentTicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieStudentTicketLabel.Location = new System.Drawing.Point(168, 242);
            this.movieStudentTicketLabel.Name = "movieStudentTicketLabel";
            this.movieStudentTicketLabel.Size = new System.Drawing.Size(0, 16);
            this.movieStudentTicketLabel.TabIndex = 30;
            // 
            // movieElderTicketLabel
            // 
            this.movieElderTicketLabel.AutoSize = true;
            this.movieElderTicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieElderTicketLabel.Location = new System.Drawing.Point(152, 270);
            this.movieElderTicketLabel.Name = "movieElderTicketLabel";
            this.movieElderTicketLabel.Size = new System.Drawing.Size(0, 16);
            this.movieElderTicketLabel.TabIndex = 31;
            // 
            // movieTotalTicketLabel
            // 
            this.movieTotalTicketLabel.AutoSize = true;
            this.movieTotalTicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTotalTicketLabel.Location = new System.Drawing.Point(194, 313);
            this.movieTotalTicketLabel.Name = "movieTotalTicketLabel";
            this.movieTotalTicketLabel.Size = new System.Drawing.Size(0, 16);
            this.movieTotalTicketLabel.TabIndex = 32;
            // 
            // movieTotalRevenueLabel
            // 
            this.movieTotalRevenueLabel.AutoSize = true;
            this.movieTotalRevenueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTotalRevenueLabel.Location = new System.Drawing.Point(194, 340);
            this.movieTotalRevenueLabel.Name = "movieTotalRevenueLabel";
            this.movieTotalRevenueLabel.Size = new System.Drawing.Size(0, 16);
            this.movieTotalRevenueLabel.TabIndex = 33;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(371, 400);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 34;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // TicketInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.movieTotalRevenueLabel);
            this.Controls.Add(this.movieTotalTicketLabel);
            this.Controls.Add(this.movieElderTicketLabel);
            this.Controls.Add(this.movieStudentTicketLabel);
            this.Controls.Add(this.movieAdultTicketLabel);
            this.Controls.Add(this.movieChildrenTicketLabel);
            this.Controls.Add(this.showtimeTotalRevenueLabel);
            this.Controls.Add(this.showtimeTotalTicketSoldLabel);
            this.Controls.Add(this.showtimeElderTicketLabel);
            this.Controls.Add(this.showtimeStudentTicketLabel);
            this.Controls.Add(this.showtimeAdultTicketLabel);
            this.Controls.Add(this.showtimeChildrenTicketLabel);
            this.Controls.Add(this.selectedShowtimeLabel);
            this.Controls.Add(this.selectedMovieLabel);
            this.Controls.Add(this.showtimeInfoLabel4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.showtimeInfoLabel3);
            this.Controls.Add(this.showtimeInfoLabel2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.showtimeLabel);
            this.Controls.Add(this.showtimeInfoLabel1);
            this.Controls.Add(this.mTitleLabel5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mTitleLabel4);
            this.Controls.Add(this.mTitleLabel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mTitleLabel1);
            this.Controls.Add(this.mTitleLabel2);
            this.Controls.Add(this.showtimeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movieComboBox);
            this.Controls.Add(this.UserTitleLabel);
            this.Controls.Add(this.MovieTheatreLabel);
            this.Name = "TicketInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketInfoForm";
            this.Load += new System.EventHandler(this.TicketInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MovieTheatreLabel;
        private System.Windows.Forms.Label UserTitleLabel;
        private System.Windows.Forms.ComboBox movieComboBox;
        private System.Windows.Forms.ComboBox showtimeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mTitleLabel2;
        private System.Windows.Forms.Label mTitleLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label mTitleLabel3;
        private System.Windows.Forms.Label mTitleLabel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label mTitleLabel5;
        private System.Windows.Forms.Label showtimeInfoLabel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label showtimeInfoLabel3;
        private System.Windows.Forms.Label showtimeInfoLabel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label showtimeLabel;
        private System.Windows.Forms.Label showtimeInfoLabel1;
        private System.Windows.Forms.Label selectedMovieLabel;
        private System.Windows.Forms.Label selectedShowtimeLabel;
        private System.Windows.Forms.Label showtimeChildrenTicketLabel;
        private System.Windows.Forms.Label showtimeAdultTicketLabel;
        private System.Windows.Forms.Label showtimeStudentTicketLabel;
        private System.Windows.Forms.Label showtimeElderTicketLabel;
        private System.Windows.Forms.Label showtimeTotalTicketSoldLabel;
        private System.Windows.Forms.Label showtimeTotalRevenueLabel;
        private System.Windows.Forms.Label movieChildrenTicketLabel;
        private System.Windows.Forms.Label movieAdultTicketLabel;
        private System.Windows.Forms.Label movieStudentTicketLabel;
        private System.Windows.Forms.Label movieElderTicketLabel;
        private System.Windows.Forms.Label movieTotalTicketLabel;
        private System.Windows.Forms.Label movieTotalRevenueLabel;
        private System.Windows.Forms.Button backButton;
    }
}