namespace TheBestMovieTheater
{
    partial class AvailableMoviesForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.availableMoviesTableAdapter = new TheBestMovieTheater.TBMT_DBDataSetLocalTableAdapters.MovieTableAdapter();
            this.availableMoviesListView = new System.Windows.Forms.ListView();
            this.moviesComboBox = new System.Windows.Forms.ComboBox();
            this.showtimeComboBox = new System.Windows.Forms.ComboBox();
            this.movieLabel = new System.Windows.Forms.Label();
            this.showtimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MovieTheatreLabel
            // 
            this.MovieTheatreLabel.AutoSize = true;
            this.MovieTheatreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTheatreLabel.Location = new System.Drawing.Point(152, 10);
            this.MovieTheatreLabel.Name = "MovieTheatreLabel";
            this.MovieTheatreLabel.Size = new System.Drawing.Size(325, 31);
            this.MovieTheatreLabel.TabIndex = 2;
            this.MovieTheatreLabel.Text = "The Best Movie Theater";
            this.MovieTheatreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserTitleLabel
            // 
            this.UserTitleLabel.AutoSize = true;
            this.UserTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTitleLabel.Location = new System.Drawing.Point(237, 50);
            this.UserTitleLabel.Name = "UserTitleLabel";
            this.UserTitleLabel.Size = new System.Drawing.Size(160, 25);
            this.UserTitleLabel.TabIndex = 6;
            this.UserTitleLabel.Text = "Available Movies";
            this.UserTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(272, 522);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // availableMoviesTableAdapter
            // 
            this.availableMoviesTableAdapter.ClearBeforeFill = true;
            // 
            // availableMoviesListView
            // 
            this.availableMoviesListView.HideSelection = false;
            this.availableMoviesListView.Location = new System.Drawing.Point(12, 78);
            this.availableMoviesListView.Name = "availableMoviesListView";
            this.availableMoviesListView.Size = new System.Drawing.Size(602, 223);
            this.availableMoviesListView.TabIndex = 9;
            this.availableMoviesListView.UseCompatibleStateImageBehavior = false;
            this.availableMoviesListView.View = System.Windows.Forms.View.Details;
            // 
            // moviesComboBox
            // 
            this.moviesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moviesComboBox.FormattingEnabled = true;
            this.moviesComboBox.Location = new System.Drawing.Point(59, 340);
            this.moviesComboBox.Name = "moviesComboBox";
            this.moviesComboBox.Size = new System.Drawing.Size(195, 24);
            this.moviesComboBox.TabIndex = 10;
            this.moviesComboBox.SelectedIndexChanged += new System.EventHandler(this.moviesComboBox_SelectedIndexChanged);
            // 
            // showtimeComboBox
            // 
            this.showtimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showtimeComboBox.FormattingEnabled = true;
            this.showtimeComboBox.Location = new System.Drawing.Point(360, 340);
            this.showtimeComboBox.Name = "showtimeComboBox";
            this.showtimeComboBox.Size = new System.Drawing.Size(195, 24);
            this.showtimeComboBox.TabIndex = 11;
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Location = new System.Drawing.Point(128, 321);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(44, 16);
            this.movieLabel.TabIndex = 12;
            this.movieLabel.Text = "Movie";
            // 
            // showtimeLabel
            // 
            this.showtimeLabel.AutoSize = true;
            this.showtimeLabel.Location = new System.Drawing.Point(431, 321);
            this.showtimeLabel.Name = "showtimeLabel";
            this.showtimeLabel.Size = new System.Drawing.Size(65, 16);
            this.showtimeLabel.TabIndex = 13;
            this.showtimeLabel.Text = "Showtime";
            // 
            // AvailableMoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 560);
            this.Controls.Add(this.showtimeLabel);
            this.Controls.Add(this.movieLabel);
            this.Controls.Add(this.showtimeComboBox);
            this.Controls.Add(this.moviesComboBox);
            this.Controls.Add(this.availableMoviesListView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.UserTitleLabel);
            this.Controls.Add(this.MovieTheatreLabel);
            this.Name = "AvailableMoviesForm";
            this.Text = "AvailableMoviesForm";
            this.Load += new System.EventHandler(this.AvailableMoviesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MovieTheatreLabel;
        private System.Windows.Forms.Label UserTitleLabel;
        private System.Windows.Forms.Button backButton;
        private TBMT_DBDataSetLocalTableAdapters.MovieTableAdapter availableMoviesTableAdapter;
        private System.Windows.Forms.ListView availableMoviesListView;
        private System.Windows.Forms.ComboBox moviesComboBox;
        private System.Windows.Forms.ComboBox showtimeComboBox;
        private System.Windows.Forms.Label movieLabel;
        private System.Windows.Forms.Label showtimeLabel;
    }
}