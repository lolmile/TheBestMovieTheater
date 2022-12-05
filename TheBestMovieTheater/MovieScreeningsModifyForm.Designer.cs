namespace TheBestMovieTheater
{
    partial class MovieScreeningsModifyForm
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
            this.errorLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.movieScreeningIDTextBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.screeningRoomIDTextBox = new System.Windows.Forms.TextBox();
            this.showtimeIDTextBox = new System.Windows.Forms.TextBox();
            this.movieIDTextBox = new System.Windows.Forms.TextBox();
            this.screeningRoomLabel = new System.Windows.Forms.Label();
            this.showtimeIDLabel = new System.Windows.Forms.Label();
            this.movieIDLabel = new System.Windows.Forms.Label();
            this.movieScreeningIDLabel = new System.Windows.Forms.Label();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.movieInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieScreeningListView = new System.Windows.Forms.ListView();
            this.MovieListView = new System.Windows.Forms.ListView();
            this.ShowtimeListView = new System.Windows.Forms.ListView();
            this.ScreeningRoomListView = new System.Windows.Forms.ListView();
            this.tbmT_DBDataSetLocal = new TheBestMovieTheater.TBMT_DBDataSetLocal();
            this.movieInfoBridgeTableAdapter = new TheBestMovieTheater.TBMT_DBDataSetLocalTableAdapters.MovieInfoBridgeTableAdapter();
            this.movieTableAdapter = new TheBestMovieTheater.TBMT_DBDataSetLocalTableAdapters.MovieTableAdapter();
            this.showtimeTableAdapter = new TheBestMovieTheater.TBMT_DBDataSetLocalTableAdapters.ShowtimeTableAdapter();
            this.screeningRoomTableAdapter = new TheBestMovieTheater.TBMT_DBDataSetLocalTableAdapters.ScreeningRoomTableAdapter();
            this.movieInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbmT_DBDataSetLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(6, 136);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(96, 16);
            this.errorLabel.TabIndex = 27;
            this.errorLabel.Text = "Error message";
            this.errorLabel.Visible = false;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(139, 289);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(124, 86);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // movieScreeningIDTextBox
            // 
            this.movieScreeningIDTextBox.Location = new System.Drawing.Point(148, 18);
            this.movieScreeningIDTextBox.Name = "movieScreeningIDTextBox";
            this.movieScreeningIDTextBox.ReadOnly = true;
            this.movieScreeningIDTextBox.Size = new System.Drawing.Size(56, 22);
            this.movieScreeningIDTextBox.TabIndex = 25;
            this.movieScreeningIDTextBox.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(139, 381);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(124, 40);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // screeningRoomIDTextBox
            // 
            this.screeningRoomIDTextBox.Location = new System.Drawing.Point(148, 102);
            this.screeningRoomIDTextBox.MaxLength = 3;
            this.screeningRoomIDTextBox.Name = "screeningRoomIDTextBox";
            this.screeningRoomIDTextBox.Size = new System.Drawing.Size(56, 22);
            this.screeningRoomIDTextBox.TabIndex = 3;
            // 
            // showtimeIDTextBox
            // 
            this.showtimeIDTextBox.Location = new System.Drawing.Point(148, 74);
            this.showtimeIDTextBox.Name = "showtimeIDTextBox";
            this.showtimeIDTextBox.Size = new System.Drawing.Size(56, 22);
            this.showtimeIDTextBox.TabIndex = 2;
            // 
            // movieIDTextBox
            // 
            this.movieIDTextBox.Location = new System.Drawing.Point(148, 46);
            this.movieIDTextBox.Name = "movieIDTextBox";
            this.movieIDTextBox.Size = new System.Drawing.Size(56, 22);
            this.movieIDTextBox.TabIndex = 1;
            // 
            // screeningRoomLabel
            // 
            this.screeningRoomLabel.AutoSize = true;
            this.screeningRoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screeningRoomLabel.Location = new System.Drawing.Point(61, 103);
            this.screeningRoomLabel.Name = "screeningRoomLabel";
            this.screeningRoomLabel.Size = new System.Drawing.Size(72, 18);
            this.screeningRoomLabel.TabIndex = 14;
            this.screeningRoomLabel.Text = "RoomID :";
            // 
            // showtimeIDLabel
            // 
            this.showtimeIDLabel.AutoSize = true;
            this.showtimeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showtimeIDLabel.Location = new System.Drawing.Point(37, 75);
            this.showtimeIDLabel.Name = "showtimeIDLabel";
            this.showtimeIDLabel.Size = new System.Drawing.Size(96, 18);
            this.showtimeIDLabel.TabIndex = 13;
            this.showtimeIDLabel.Text = "ShowtimeID :";
            // 
            // movieIDLabel
            // 
            this.movieIDLabel.AutoSize = true;
            this.movieIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieIDLabel.Location = new System.Drawing.Point(63, 47);
            this.movieIDLabel.Name = "movieIDLabel";
            this.movieIDLabel.Size = new System.Drawing.Size(70, 18);
            this.movieIDLabel.TabIndex = 12;
            this.movieIDLabel.Text = "MovieID :";
            // 
            // movieScreeningIDLabel
            // 
            this.movieScreeningIDLabel.AutoSize = true;
            this.movieScreeningIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieScreeningIDLabel.Location = new System.Drawing.Point(37, 18);
            this.movieScreeningIDLabel.Name = "movieScreeningIDLabel";
            this.movieScreeningIDLabel.Size = new System.Drawing.Size(96, 18);
            this.movieScreeningIDLabel.TabIndex = 11;
            this.movieScreeningIDLabel.Text = "ScreeningID :";
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(9, 335);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(124, 40);
            this.ModifyButton.TabIndex = 8;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(9, 289);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(124, 40);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(9, 381);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(124, 40);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // movieInfoGroupBox
            // 
            this.movieInfoGroupBox.Controls.Add(this.errorLabel);
            this.movieInfoGroupBox.Controls.Add(this.ClearButton);
            this.movieInfoGroupBox.Controls.Add(this.movieScreeningIDTextBox);
            this.movieInfoGroupBox.Controls.Add(this.BackButton);
            this.movieInfoGroupBox.Controls.Add(this.screeningRoomIDTextBox);
            this.movieInfoGroupBox.Controls.Add(this.showtimeIDTextBox);
            this.movieInfoGroupBox.Controls.Add(this.movieIDTextBox);
            this.movieInfoGroupBox.Controls.Add(this.screeningRoomLabel);
            this.movieInfoGroupBox.Controls.Add(this.showtimeIDLabel);
            this.movieInfoGroupBox.Controls.Add(this.movieIDLabel);
            this.movieInfoGroupBox.Controls.Add(this.movieScreeningIDLabel);
            this.movieInfoGroupBox.Controls.Add(this.ModifyButton);
            this.movieInfoGroupBox.Controls.Add(this.AddButton);
            this.movieInfoGroupBox.Controls.Add(this.DeleteButton);
            this.movieInfoGroupBox.Location = new System.Drawing.Point(444, 4);
            this.movieInfoGroupBox.Name = "movieInfoGroupBox";
            this.movieInfoGroupBox.Size = new System.Drawing.Size(277, 434);
            this.movieInfoGroupBox.TabIndex = 11;
            this.movieInfoGroupBox.TabStop = false;
            // 
            // MovieScreeningListView
            // 
            this.MovieScreeningListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.MovieScreeningListView.FullRowSelect = true;
            this.MovieScreeningListView.HideSelection = false;
            this.MovieScreeningListView.Location = new System.Drawing.Point(0, 0);
            this.MovieScreeningListView.MultiSelect = false;
            this.MovieScreeningListView.Name = "MovieScreeningListView";
            this.MovieScreeningListView.Size = new System.Drawing.Size(438, 450);
            this.MovieScreeningListView.TabIndex = 1;
            this.MovieScreeningListView.UseCompatibleStateImageBehavior = false;
            this.MovieScreeningListView.View = System.Windows.Forms.View.Details;
            this.MovieScreeningListView.SelectedIndexChanged += new System.EventHandler(this.MovieScreeningListView_SelectedIndexChanged);
            // 
            // MovieListView
            // 
            this.MovieListView.FullRowSelect = true;
            this.MovieListView.HideSelection = false;
            this.MovieListView.Location = new System.Drawing.Point(941, 0);
            this.MovieListView.MultiSelect = false;
            this.MovieListView.Name = "MovieListView";
            this.MovieListView.Size = new System.Drawing.Size(258, 239);
            this.MovieListView.TabIndex = 12;
            this.MovieListView.TabStop = false;
            this.MovieListView.UseCompatibleStateImageBehavior = false;
            this.MovieListView.View = System.Windows.Forms.View.Details;
            // 
            // ShowtimeListView
            // 
            this.ShowtimeListView.FullRowSelect = true;
            this.ShowtimeListView.HideSelection = false;
            this.ShowtimeListView.HoverSelection = true;
            this.ShowtimeListView.Location = new System.Drawing.Point(727, 0);
            this.ShowtimeListView.MultiSelect = false;
            this.ShowtimeListView.Name = "ShowtimeListView";
            this.ShowtimeListView.Size = new System.Drawing.Size(208, 450);
            this.ShowtimeListView.TabIndex = 13;
            this.ShowtimeListView.TabStop = false;
            this.ShowtimeListView.UseCompatibleStateImageBehavior = false;
            this.ShowtimeListView.View = System.Windows.Forms.View.Details;
            // 
            // ScreeningRoomListView
            // 
            this.ScreeningRoomListView.FullRowSelect = true;
            this.ScreeningRoomListView.HideSelection = false;
            this.ScreeningRoomListView.Location = new System.Drawing.Point(941, 245);
            this.ScreeningRoomListView.MultiSelect = false;
            this.ScreeningRoomListView.Name = "ScreeningRoomListView";
            this.ScreeningRoomListView.Size = new System.Drawing.Size(258, 205);
            this.ScreeningRoomListView.TabIndex = 14;
            this.ScreeningRoomListView.TabStop = false;
            this.ScreeningRoomListView.UseCompatibleStateImageBehavior = false;
            this.ScreeningRoomListView.View = System.Windows.Forms.View.Details;
            // 
            // tbmT_DBDataSetLocal
            // 
            this.tbmT_DBDataSetLocal.DataSetName = "TBMT_DBDataSetLocal";
            this.tbmT_DBDataSetLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieInfoBridgeTableAdapter
            // 
            this.movieInfoBridgeTableAdapter.ClearBeforeFill = true;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // showtimeTableAdapter
            // 
            this.showtimeTableAdapter.ClearBeforeFill = true;
            // 
            // screeningRoomTableAdapter
            // 
            this.screeningRoomTableAdapter.ClearBeforeFill = true;
            // 
            // MovieScreeningsModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ScreeningRoomListView);
            this.Controls.Add(this.ShowtimeListView);
            this.Controls.Add(this.MovieListView);
            this.Controls.Add(this.movieInfoGroupBox);
            this.Controls.Add(this.MovieScreeningListView);
            this.Name = "MovieScreeningsModifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyMovieScreeningsForm";
            this.Load += new System.EventHandler(this.MovieScreeningsModifyForm_Load);
            this.movieInfoGroupBox.ResumeLayout(false);
            this.movieInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbmT_DBDataSetLocal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox movieScreeningIDTextBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox screeningRoomIDTextBox;
        private System.Windows.Forms.TextBox showtimeIDTextBox;
        private System.Windows.Forms.TextBox movieIDTextBox;
        private System.Windows.Forms.Label screeningRoomLabel;
        private System.Windows.Forms.Label showtimeIDLabel;
        private System.Windows.Forms.Label movieIDLabel;
        private System.Windows.Forms.Label movieScreeningIDLabel;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private TBMT_DBDataSetLocal tbmT_DBDataSetLocal;
        private System.Windows.Forms.GroupBox movieInfoGroupBox;
        private System.Windows.Forms.ListView MovieScreeningListView;
        private TBMT_DBDataSetLocalTableAdapters.MovieInfoBridgeTableAdapter movieInfoBridgeTableAdapter;
        private TBMT_DBDataSetLocalTableAdapters.MovieTableAdapter movieTableAdapter;
        private TBMT_DBDataSetLocalTableAdapters.ShowtimeTableAdapter showtimeTableAdapter;
        private TBMT_DBDataSetLocalTableAdapters.ScreeningRoomTableAdapter screeningRoomTableAdapter;
        private System.Windows.Forms.ListView MovieListView;
        private System.Windows.Forms.ListView ShowtimeListView;
        private System.Windows.Forms.ListView ScreeningRoomListView;
    }
}