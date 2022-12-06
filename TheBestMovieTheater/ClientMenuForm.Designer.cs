namespace TheBestMovieTheater
{
    partial class ClientMenuForm
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
            this.priceGroupBox = new System.Windows.Forms.GroupBox();
            this.elderPriceLabel = new System.Windows.Forms.Label();
            this.studentPriceLabel = new System.Windows.Forms.Label();
            this.adultPriceLabel = new System.Windows.Forms.Label();
            this.kidPriceLabel = new System.Windows.Forms.Label();
            this.availableMovieButton = new System.Windows.Forms.Button();
            this.upcomingMoviesButton = new System.Windows.Forms.Button();
            this.UserTitleLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.priceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovieTheatreLabel
            // 
            this.MovieTheatreLabel.AutoSize = true;
            this.MovieTheatreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTheatreLabel.Location = new System.Drawing.Point(207, 9);
            this.MovieTheatreLabel.Name = "MovieTheatreLabel";
            this.MovieTheatreLabel.Size = new System.Drawing.Size(325, 31);
            this.MovieTheatreLabel.TabIndex = 1;
            this.MovieTheatreLabel.Text = "The Best Movie Theater";
            this.MovieTheatreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceGroupBox
            // 
            this.priceGroupBox.Controls.Add(this.elderPriceLabel);
            this.priceGroupBox.Controls.Add(this.studentPriceLabel);
            this.priceGroupBox.Controls.Add(this.adultPriceLabel);
            this.priceGroupBox.Controls.Add(this.kidPriceLabel);
            this.priceGroupBox.Location = new System.Drawing.Point(12, 70);
            this.priceGroupBox.Name = "priceGroupBox";
            this.priceGroupBox.Size = new System.Drawing.Size(206, 296);
            this.priceGroupBox.TabIndex = 2;
            this.priceGroupBox.TabStop = false;
            this.priceGroupBox.Text = "Ticket Price";
            // 
            // elderPriceLabel
            // 
            this.elderPriceLabel.AutoSize = true;
            this.elderPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elderPriceLabel.Location = new System.Drawing.Point(19, 219);
            this.elderPriceLabel.Name = "elderPriceLabel";
            this.elderPriceLabel.Size = new System.Drawing.Size(147, 25);
            this.elderPriceLabel.TabIndex = 3;
            this.elderPriceLabel.Text = "Elder : 10.00$";
            // 
            // studentPriceLabel
            // 
            this.studentPriceLabel.AutoSize = true;
            this.studentPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentPriceLabel.Location = new System.Drawing.Point(19, 166);
            this.studentPriceLabel.Name = "studentPriceLabel";
            this.studentPriceLabel.Size = new System.Drawing.Size(172, 25);
            this.studentPriceLabel.TabIndex = 2;
            this.studentPriceLabel.Text = "Student : 10.00$";
            // 
            // adultPriceLabel
            // 
            this.adultPriceLabel.AutoSize = true;
            this.adultPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultPriceLabel.Location = new System.Drawing.Point(19, 113);
            this.adultPriceLabel.Name = "adultPriceLabel";
            this.adultPriceLabel.Size = new System.Drawing.Size(147, 25);
            this.adultPriceLabel.TabIndex = 1;
            this.adultPriceLabel.Text = "Adult : 15.00$";
            // 
            // kidPriceLabel
            // 
            this.kidPriceLabel.AutoSize = true;
            this.kidPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kidPriceLabel.Location = new System.Drawing.Point(19, 61);
            this.kidPriceLabel.Name = "kidPriceLabel";
            this.kidPriceLabel.Size = new System.Drawing.Size(135, 25);
            this.kidPriceLabel.TabIndex = 0;
            this.kidPriceLabel.Text = "Child : 4.00$";
            // 
            // availableMovieButton
            // 
            this.availableMovieButton.Location = new System.Drawing.Point(293, 113);
            this.availableMovieButton.Name = "availableMovieButton";
            this.availableMovieButton.Size = new System.Drawing.Size(281, 67);
            this.availableMovieButton.TabIndex = 3;
            this.availableMovieButton.Text = "Available Movies !";
            this.availableMovieButton.UseVisualStyleBackColor = true;
            this.availableMovieButton.Click += new System.EventHandler(this.availableMovieButton_Click);
            // 
            // upcomingMoviesButton
            // 
            this.upcomingMoviesButton.Location = new System.Drawing.Point(293, 218);
            this.upcomingMoviesButton.Name = "upcomingMoviesButton";
            this.upcomingMoviesButton.Size = new System.Drawing.Size(281, 67);
            this.upcomingMoviesButton.TabIndex = 4;
            this.upcomingMoviesButton.Text = "Coming Soon !";
            this.upcomingMoviesButton.UseVisualStyleBackColor = true;
            this.upcomingMoviesButton.Click += new System.EventHandler(this.upcomingMoviesButton_Click);
            // 
            // UserTitleLabel
            // 
            this.UserTitleLabel.AutoSize = true;
            this.UserTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTitleLabel.Location = new System.Drawing.Point(308, 40);
            this.UserTitleLabel.Name = "UserTitleLabel";
            this.UserTitleLabel.Size = new System.Drawing.Size(113, 25);
            this.UserTitleLabel.TabIndex = 5;
            this.UserTitleLabel.Text = "Client Page";
            this.UserTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(576, 322);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(108, 44);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // ClientMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 393);
            this.ControlBox = false;
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.UserTitleLabel);
            this.Controls.Add(this.upcomingMoviesButton);
            this.Controls.Add(this.availableMovieButton);
            this.Controls.Add(this.priceGroupBox);
            this.Controls.Add(this.MovieTheatreLabel);
            this.Name = "ClientMenuForm";
            this.Text = "ClientMenuForm";
            this.priceGroupBox.ResumeLayout(false);
            this.priceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MovieTheatreLabel;
        private System.Windows.Forms.GroupBox priceGroupBox;
        private System.Windows.Forms.Label elderPriceLabel;
        private System.Windows.Forms.Label studentPriceLabel;
        private System.Windows.Forms.Label adultPriceLabel;
        private System.Windows.Forms.Label kidPriceLabel;
        private System.Windows.Forms.Button availableMovieButton;
        private System.Windows.Forms.Button upcomingMoviesButton;
        private System.Windows.Forms.Label UserTitleLabel;
        private System.Windows.Forms.Button logoutButton;
    }
}