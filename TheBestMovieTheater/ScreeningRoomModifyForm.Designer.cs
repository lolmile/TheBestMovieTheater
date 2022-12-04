namespace TheBestMovieTheater
{
    partial class ScreeningRoomModifyForm
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
            this.ScreeningRoomListView = new System.Windows.Forms.ListView();
            this.tbmT_DBDataSetLocal = new TheBestMovieTheater.TBMT_DBDataSetLocal();
            this.screeningRoomTableAdapter = new TheBestMovieTheater.TBMT_DBDataSetLocalTableAdapters.ScreeningRoomTableAdapter();
            this.roomIDLabel = new System.Windows.Forms.Label();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.capacityLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.roomIDTextBox = new System.Windows.Forms.TextBox();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.capacityTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbmT_DBDataSetLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(380, 251);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 32);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ScreeningRoomListView
            // 
            this.ScreeningRoomListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.ScreeningRoomListView.FullRowSelect = true;
            this.ScreeningRoomListView.HideSelection = false;
            this.ScreeningRoomListView.Location = new System.Drawing.Point(0, 0);
            this.ScreeningRoomListView.Name = "ScreeningRoomListView";
            this.ScreeningRoomListView.Size = new System.Drawing.Size(275, 290);
            this.ScreeningRoomListView.TabIndex = 1;
            this.ScreeningRoomListView.UseCompatibleStateImageBehavior = false;
            this.ScreeningRoomListView.View = System.Windows.Forms.View.Details;
            // 
            // tbmT_DBDataSetLocal
            // 
            this.tbmT_DBDataSetLocal.DataSetName = "TBMT_DBDataSetLocal";
            this.tbmT_DBDataSetLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // screeningRoomTableAdapter
            // 
            this.screeningRoomTableAdapter.ClearBeforeFill = true;
            // 
            // roomIDLabel
            // 
            this.roomIDLabel.AutoSize = true;
            this.roomIDLabel.Location = new System.Drawing.Point(286, 9);
            this.roomIDLabel.Name = "roomIDLabel";
            this.roomIDLabel.Size = new System.Drawing.Size(63, 16);
            this.roomIDLabel.TabIndex = 9;
            this.roomIDLabel.Text = "RoomID :";
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Location = new System.Drawing.Point(289, 36);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(60, 16);
            this.roomNumberLabel.TabIndex = 10;
            this.roomNumberLabel.Text = "Room # :";
            // 
            // capacityLabel
            // 
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.Location = new System.Drawing.Point(283, 64);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(66, 16);
            this.capacityLabel.TabIndex = 11;
            this.capacityLabel.Text = "Capacity :";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(283, 98);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(96, 16);
            this.errorLabel.TabIndex = 12;
            this.errorLabel.Text = "Error message";
            this.errorLabel.Visible = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(286, 251);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 32);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(286, 213);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(75, 32);
            this.ModifyButton.TabIndex = 5;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(286, 175);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 32);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(380, 175);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 70);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // roomIDTextBox
            // 
            this.roomIDTextBox.Location = new System.Drawing.Point(355, 6);
            this.roomIDTextBox.Name = "roomIDTextBox";
            this.roomIDTextBox.ReadOnly = true;
            this.roomIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.roomIDTextBox.TabIndex = 22;
            this.roomIDTextBox.TabStop = false;
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.Location = new System.Drawing.Point(355, 33);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.roomNumberTextBox.TabIndex = 2;
            // 
            // capacityTextBox
            // 
            this.capacityTextBox.Location = new System.Drawing.Point(355, 61);
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.Size = new System.Drawing.Size(100, 22);
            this.capacityTextBox.TabIndex = 3;
            // 
            // ScreeningRoomModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 290);
            this.ControlBox = false;
            this.Controls.Add(this.capacityTextBox);
            this.Controls.Add(this.roomNumberTextBox);
            this.Controls.Add(this.roomIDTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.capacityLabel);
            this.Controls.Add(this.roomNumberLabel);
            this.Controls.Add(this.roomIDLabel);
            this.Controls.Add(this.ScreeningRoomListView);
            this.Controls.Add(this.BackButton);
            this.Name = "ScreeningRoomModifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScreeningRoomModifyForm";
            this.Load += new System.EventHandler(this.ScreeningRoomModifyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbmT_DBDataSetLocal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListView ScreeningRoomListView;
        private TBMT_DBDataSetLocal tbmT_DBDataSetLocal;
        private TBMT_DBDataSetLocalTableAdapters.ScreeningRoomTableAdapter screeningRoomTableAdapter;
        private System.Windows.Forms.Label roomIDLabel;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.Label capacityLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox roomIDTextBox;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.TextBox capacityTextBox;
    }
}