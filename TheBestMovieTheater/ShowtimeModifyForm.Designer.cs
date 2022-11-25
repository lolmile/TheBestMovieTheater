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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowtimeModifyForm));
            this.BackButton = new System.Windows.Forms.Button();
            this.tBMT_DBDataSetLocal = new TheBestMovieTheater.TBMT_DBDataSetLocal();
            this.vManager_ShowtimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vManager_ShowtimesTableAdapter = new TheBestMovieTheater.TBMT_DBDataSetLocalTableAdapters.vManager_ShowtimesTableAdapter();
            this.tableAdapterManager = new TheBestMovieTheater.TBMT_DBDataSetLocalTableAdapters.TableAdapterManager();
            this.vManager_ShowtimesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.vManager_ShowtimesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vManager_ShowtimesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tBMT_DBDataSetLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vManager_ShowtimesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vManager_ShowtimesBindingNavigator)).BeginInit();
            this.vManager_ShowtimesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vManager_ShowtimesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 256);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 32);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // tBMT_DBDataSetLocal
            // 
            this.tBMT_DBDataSetLocal.DataSetName = "TBMT_DBDataSetLocal";
            this.tBMT_DBDataSetLocal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vManager_ShowtimesBindingSource
            // 
            this.vManager_ShowtimesBindingSource.DataMember = "vManager_Showtimes";
            this.vManager_ShowtimesBindingSource.DataSource = this.tBMT_DBDataSetLocal;
            // 
            // vManager_ShowtimesTableAdapter
            // 
            this.vManager_ShowtimesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientMovieShowtimeTableAdapter = null;
            this.tableAdapterManager.ClientTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ManagerTableAdapter = null;
            this.tableAdapterManager.MovieScreeningRoomTableAdapter = null;
            this.tableAdapterManager.MovieShowtimeTableAdapter = null;
            this.tableAdapterManager.MovieTableAdapter = null;
            this.tableAdapterManager.ScreeningRoomTableAdapter = null;
            this.tableAdapterManager.ShowtimeTableAdapter = null;
            this.tableAdapterManager.ShowtimeTicketPriceTableAdapter = null;
            this.tableAdapterManager.TicketPriceTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TheBestMovieTheater.TBMT_DBDataSetLocalTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // vManager_ShowtimesBindingNavigator
            // 
            this.vManager_ShowtimesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vManager_ShowtimesBindingNavigator.BindingSource = this.vManager_ShowtimesBindingSource;
            this.vManager_ShowtimesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vManager_ShowtimesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vManager_ShowtimesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.vManager_ShowtimesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vManager_ShowtimesBindingNavigatorSaveItem});
            this.vManager_ShowtimesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vManager_ShowtimesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vManager_ShowtimesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vManager_ShowtimesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vManager_ShowtimesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vManager_ShowtimesBindingNavigator.Name = "vManager_ShowtimesBindingNavigator";
            this.vManager_ShowtimesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vManager_ShowtimesBindingNavigator.Size = new System.Drawing.Size(642, 27);
            this.vManager_ShowtimesBindingNavigator.TabIndex = 7;
            this.vManager_ShowtimesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // vManager_ShowtimesBindingNavigatorSaveItem
            // 
            this.vManager_ShowtimesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vManager_ShowtimesBindingNavigatorSaveItem.Enabled = false;
            this.vManager_ShowtimesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vManager_ShowtimesBindingNavigatorSaveItem.Image")));
            this.vManager_ShowtimesBindingNavigatorSaveItem.Name = "vManager_ShowtimesBindingNavigatorSaveItem";
            this.vManager_ShowtimesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.vManager_ShowtimesBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // vManager_ShowtimesDataGridView
            // 
            this.vManager_ShowtimesDataGridView.AutoGenerateColumns = false;
            this.vManager_ShowtimesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vManager_ShowtimesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vManager_ShowtimesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.vManager_ShowtimesDataGridView.DataSource = this.vManager_ShowtimesBindingSource;
            this.vManager_ShowtimesDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.vManager_ShowtimesDataGridView.Location = new System.Drawing.Point(0, 27);
            this.vManager_ShowtimesDataGridView.Name = "vManager_ShowtimesDataGridView";
            this.vManager_ShowtimesDataGridView.RowHeadersWidth = 51;
            this.vManager_ShowtimesDataGridView.RowTemplate.Height = 24;
            this.vManager_ShowtimesDataGridView.Size = new System.Drawing.Size(642, 220);
            this.vManager_ShowtimesDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Showtime";
            this.dataGridViewTextBoxColumn1.HeaderText = "Showtime";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ShowtimeID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ShowtimeID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MovieID";
            this.dataGridViewTextBoxColumn4.HeaderText = "MovieID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn5.HeaderText = "Title";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // ShowtimeModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 333);
            this.Controls.Add(this.vManager_ShowtimesDataGridView);
            this.Controls.Add(this.vManager_ShowtimesBindingNavigator);
            this.Controls.Add(this.BackButton);
            this.Name = "ShowtimeModifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowtimeModifyForm";
            this.Load += new System.EventHandler(this.ShowtimeModifyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBMT_DBDataSetLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vManager_ShowtimesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vManager_ShowtimesBindingNavigator)).EndInit();
            this.vManager_ShowtimesBindingNavigator.ResumeLayout(false);
            this.vManager_ShowtimesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vManager_ShowtimesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private TBMT_DBDataSetLocal tBMT_DBDataSetLocal;
        private System.Windows.Forms.BindingSource vManager_ShowtimesBindingSource;
        private TBMT_DBDataSetLocalTableAdapters.vManager_ShowtimesTableAdapter vManager_ShowtimesTableAdapter;
        private TBMT_DBDataSetLocalTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vManager_ShowtimesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vManager_ShowtimesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView vManager_ShowtimesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}