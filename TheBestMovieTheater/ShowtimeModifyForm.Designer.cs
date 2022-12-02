namespace TheBestMovieTheater
{
    partial class ShowtimeModifyForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.ShowtimeListView = new System.Windows.Forms.ListView();
            this.showtimeIdLabel = new System.Windows.Forms.Label();
            this.showtimeLabel = new System.Windows.Forms.Label();
            this.showTimeIDTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.showTimeTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tbmT_DBDataSetLocal = new TheBestMovieTheater.TBMT_DBDataSetLocal();
            this.showtimeTableAdapter = new TheBestMovieTheater.TBMT_DBDataSetLocalTableAdapters.ShowtimeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbmT_DBDataSetLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(347, 182);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 32);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ShowtimeListView
            // 
            this.ShowtimeListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.ShowtimeListView.FullRowSelect = true;
            this.ShowtimeListView.HideSelection = false;
            this.ShowtimeListView.Location = new System.Drawing.Point(0, 0);
            this.ShowtimeListView.Name = "ShowtimeListView";
            this.ShowtimeListView.Size = new System.Drawing.Size(244, 230);
            this.ShowtimeListView.TabIndex = 8;
            this.ShowtimeListView.UseCompatibleStateImageBehavior = false;
            this.ShowtimeListView.View = System.Windows.Forms.View.Details;
            this.ShowtimeListView.SelectedIndexChanged += new System.EventHandler(this.ShowtimeListView_SelectedIndexChanged);
            // 
            // showtimeIdLabel
            // 
            this.showtimeIdLabel.AutoSize = true;
            this.showtimeIdLabel.Location = new System.Drawing.Point(302, 15);
            this.showtimeIdLabel.Name = "showtimeIdLabel";
            this.showtimeIdLabel.Size = new System.Drawing.Size(29, 16);
            this.showtimeIdLabel.TabIndex = 9;
            this.showtimeIdLabel.Text = "ID : ";
            // 
            // showtimeLabel
            // 
            this.showtimeLabel.AutoSize = true;
            this.showtimeLabel.Location = new System.Drawing.Point(257, 43);
            this.showtimeLabel.Name = "showtimeLabel";
            this.showtimeLabel.Size = new System.Drawing.Size(74, 16);
            this.showtimeLabel.TabIndex = 10;
            this.showtimeLabel.Text = "Showtime : ";
            // 
            // showTimeIDTextBox
            // 
            this.showTimeIDTextBox.Location = new System.Drawing.Point(347, 12);
            this.showTimeIDTextBox.Name = "showTimeIDTextBox";
            this.showTimeIDTextBox.ReadOnly = true;
            this.showTimeIDTextBox.Size = new System.Drawing.Size(53, 22);
            this.showTimeIDTextBox.TabIndex = 11;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(347, 106);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 70);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(253, 106);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 32);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(253, 144);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(75, 32);
            this.ModifyButton.TabIndex = 15;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(253, 182);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 32);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(250, 74);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(96, 16);
            this.errorLabel.TabIndex = 17;
            this.errorLabel.Text = "Error Message";
            this.errorLabel.Visible = false;
            // 
            // showTimeTimePicker
            // 
            this.showTimeTimePicker.CustomFormat = "HH:mm";
            this.showTimeTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.showTimeTimePicker.Location = new System.Drawing.Point(347, 40);
            this.showTimeTimePicker.Name = "showTimeTimePicker";
            this.showTimeTimePicker.ShowUpDown = true;
            this.showTimeTimePicker.Size = new System.Drawing.Size(75, 22);
            this.showTimeTimePicker.TabIndex = 18;
            this.showTimeTimePicker.Value = new System.DateTime(2022, 12, 2, 0, 0, 0, 0);
            // 
            // tbmT_DBDataSetLocal
            // 
            this.tbmT_DBDataSetLocal.DataSetName = "TBMT_DBDataSetLocal";
            this.tbmT_DBDataSetLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showtimeTableAdapter
            // 
            this.showtimeTableAdapter.ClearBeforeFill = true;
            // 
            // ShowtimeModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(431, 230);
            this.ControlBox = false;
            this.Controls.Add(this.showTimeTimePicker);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.showTimeIDTextBox);
            this.Controls.Add(this.showtimeLabel);
            this.Controls.Add(this.showtimeIdLabel);
            this.Controls.Add(this.ShowtimeListView);
            this.Controls.Add(this.BackButton);
            this.Name = "ShowtimeModifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowtimeModifyForm";
            this.Load += new System.EventHandler(this.ShowtimeModifyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbmT_DBDataSetLocal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListView ShowtimeListView;
        private TBMT_DBDataSetLocal tbmT_DBDataSetLocal;
        private TBMT_DBDataSetLocalTableAdapters.ShowtimeTableAdapter showtimeTableAdapter;
        private System.Windows.Forms.Label showtimeIdLabel;
        private System.Windows.Forms.Label showtimeLabel;
        private System.Windows.Forms.TextBox showTimeIDTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.DateTimePicker showTimeTimePicker;
    }
}