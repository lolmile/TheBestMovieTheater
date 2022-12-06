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
            this.purchaseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.elderRadioButton = new System.Windows.Forms.RadioButton();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.adultRadioButton = new System.Windows.Forms.RadioButton();
            this.childRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovieTheatreLabel
            // 
            this.MovieTheatreLabel.AutoSize = true;
            this.MovieTheatreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTheatreLabel.Location = new System.Drawing.Point(197, 9);
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
            this.UserTitleLabel.Location = new System.Drawing.Point(282, 49);
            this.UserTitleLabel.Name = "UserTitleLabel";
            this.UserTitleLabel.Size = new System.Drawing.Size(160, 25);
            this.UserTitleLabel.TabIndex = 6;
            this.UserTitleLabel.Text = "Available Movies";
            this.UserTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(324, 525);
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
            this.availableMoviesListView.Size = new System.Drawing.Size(704, 223);
            this.availableMoviesListView.TabIndex = 9;
            this.availableMoviesListView.UseCompatibleStateImageBehavior = false;
            this.availableMoviesListView.View = System.Windows.Forms.View.Details;
            // 
            // moviesComboBox
            // 
            this.moviesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moviesComboBox.FormattingEnabled = true;
            this.moviesComboBox.Location = new System.Drawing.Point(108, 337);
            this.moviesComboBox.Name = "moviesComboBox";
            this.moviesComboBox.Size = new System.Drawing.Size(195, 24);
            this.moviesComboBox.TabIndex = 10;
            this.moviesComboBox.SelectedIndexChanged += new System.EventHandler(this.moviesComboBox_SelectedIndexChanged);
            // 
            // showtimeComboBox
            // 
            this.showtimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showtimeComboBox.FormattingEnabled = true;
            this.showtimeComboBox.Location = new System.Drawing.Point(414, 337);
            this.showtimeComboBox.Name = "showtimeComboBox";
            this.showtimeComboBox.Size = new System.Drawing.Size(195, 24);
            this.showtimeComboBox.TabIndex = 11;
            // 
            // movieLabel
            // 
            this.movieLabel.AutoSize = true;
            this.movieLabel.Location = new System.Drawing.Point(182, 318);
            this.movieLabel.Name = "movieLabel";
            this.movieLabel.Size = new System.Drawing.Size(44, 16);
            this.movieLabel.TabIndex = 12;
            this.movieLabel.Text = "Movie";
            // 
            // showtimeLabel
            // 
            this.showtimeLabel.AutoSize = true;
            this.showtimeLabel.Location = new System.Drawing.Point(485, 318);
            this.showtimeLabel.Name = "showtimeLabel";
            this.showtimeLabel.Size = new System.Drawing.Size(65, 16);
            this.showtimeLabel.TabIndex = 13;
            this.showtimeLabel.Text = "Showtime";
            // 
            // purchaseButton
            // 
            this.purchaseButton.Location = new System.Drawing.Point(469, 468);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(195, 63);
            this.purchaseButton.TabIndex = 14;
            this.purchaseButton.Text = "Purchase";
            this.purchaseButton.UseVisualStyleBackColor = true;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.elderRadioButton);
            this.groupBox1.Controls.Add(this.studentRadioButton);
            this.groupBox1.Controls.Add(this.adultRadioButton);
            this.groupBox1.Controls.Add(this.childRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(26, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 171);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Age";
            // 
            // elderRadioButton
            // 
            this.elderRadioButton.AutoSize = true;
            this.elderRadioButton.Location = new System.Drawing.Point(35, 117);
            this.elderRadioButton.Name = "elderRadioButton";
            this.elderRadioButton.Size = new System.Drawing.Size(92, 20);
            this.elderRadioButton.TabIndex = 3;
            this.elderRadioButton.TabStop = true;
            this.elderRadioButton.Text = "Elder (65+)";
            this.elderRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Location = new System.Drawing.Point(35, 91);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(73, 20);
            this.studentRadioButton.TabIndex = 2;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Text = "Student";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            // 
            // adultRadioButton
            // 
            this.adultRadioButton.AutoSize = true;
            this.adultRadioButton.Checked = true;
            this.adultRadioButton.Location = new System.Drawing.Point(35, 65);
            this.adultRadioButton.Name = "adultRadioButton";
            this.adultRadioButton.Size = new System.Drawing.Size(107, 20);
            this.adultRadioButton.TabIndex = 1;
            this.adultRadioButton.TabStop = true;
            this.adultRadioButton.Text = "Adult (12 - 65)";
            this.adultRadioButton.UseVisualStyleBackColor = true;
            // 
            // childRadioButton
            // 
            this.childRadioButton.AutoSize = true;
            this.childRadioButton.Location = new System.Drawing.Point(35, 39);
            this.childRadioButton.Name = "childRadioButton";
            this.childRadioButton.Size = new System.Drawing.Size(100, 20);
            this.childRadioButton.TabIndex = 0;
            this.childRadioButton.TabStop = true;
            this.childRadioButton.Text = "Child (2 - 12)";
            this.childRadioButton.UseVisualStyleBackColor = true;
            // 
            // AvailableMoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 560);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.purchaseButton);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton elderRadioButton;
        private System.Windows.Forms.RadioButton studentRadioButton;
        private System.Windows.Forms.RadioButton adultRadioButton;
        private System.Windows.Forms.RadioButton childRadioButton;
    }
}