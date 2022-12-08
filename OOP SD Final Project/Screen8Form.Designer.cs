namespace OOP_SD_Final_Project
{
    partial class Screen8Form
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
            this.moviesLabel = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.idNumberLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.project_DatabaseDataSet = new OOP_SD_Final_Project.Project_DatabaseDataSet();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieTableAdapter = new OOP_SD_Final_Project.Project_DatabaseDataSetTableAdapters.MovieTableAdapter();
            this.tableAdapterManager = new OOP_SD_Final_Project.Project_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.roomTableAdapter = new OOP_SD_Final_Project.Project_DatabaseDataSetTableAdapters.RoomTableAdapter();
            this.showTimeTableAdapter = new OOP_SD_Final_Project.Project_DatabaseDataSetTableAdapters.ShowTimeTableAdapter();
            this.movieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomDataGridView = new System.Windows.Forms.DataGridView();
            this.showTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showTimeDataGridView = new System.Windows.Forms.DataGridView();
            this.moviesList = new System.Windows.Forms.Label();
            this.roomList = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.project_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // moviesLabel
            // 
            this.moviesLabel.AutoSize = true;
            this.moviesLabel.Location = new System.Drawing.Point(338, 106);
            this.moviesLabel.Name = "moviesLabel";
            this.moviesLabel.Size = new System.Drawing.Size(111, 13);
            this.moviesLabel.TabIndex = 24;
            this.moviesLabel.Text = "Upcoming Screenings";
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(453, 657);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(114, 32);
            this.mainMenuButton.TabIndex = 23;
            this.mainMenuButton.Text = "Back";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(88, 61);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(113, 13);
            this.companyNameLabel.TabIndex = 22;
            this.companyNameLabel.Text = "The Theater Company";
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idNumberLabel.Location = new System.Drawing.Point(796, 20);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(94, 33);
            this.idNumberLabel.TabIndex = 21;
            this.idNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(780, 64);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(71, 13);
            this.userNameLabel.TabIndex = 20;
            this.userNameLabel.Text = "USER NAME";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(749, 31);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(47, 13);
            this.userIdLabel.TabIndex = 19;
            this.userIdLabel.Text = "User Id: ";
            // 
            // project_DatabaseDataSet
            // 
            this.project_DatabaseDataSet.DataSetName = "Project_DatabaseDataSet";
            this.project_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.project_DatabaseDataSet;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MovieTableAdapter = this.movieTableAdapter;
            this.tableAdapterManager.RoomTableAdapter = this.roomTableAdapter;
            this.tableAdapterManager.ShowTimeTableAdapter = this.showTimeTableAdapter;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OOP_SD_Final_Project.Project_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // showTimeTableAdapter
            // 
            this.showTimeTableAdapter.ClearBeforeFill = true;
            // 
            // movieDataGridView
            // 
            this.movieDataGridView.AutoGenerateColumns = false;
            this.movieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.movieDataGridView.DataSource = this.movieBindingSource;
            this.movieDataGridView.Location = new System.Drawing.Point(49, 415);
            this.movieDataGridView.Name = "movieDataGridView";
            this.movieDataGridView.ReadOnly = true;
            this.movieDataGridView.Size = new System.Drawing.Size(463, 220);
            this.movieDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MovieId";
            this.dataGridViewTextBoxColumn1.HeaderText = "MovieId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Minutes";
            this.dataGridViewTextBoxColumn4.HeaderText = "Minutes";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.project_DatabaseDataSet;
            // 
            // roomDataGridView
            // 
            this.roomDataGridView.AutoGenerateColumns = false;
            this.roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8});
            this.roomDataGridView.DataSource = this.roomBindingSource;
            this.roomDataGridView.Location = new System.Drawing.Point(574, 415);
            this.roomDataGridView.Name = "roomDataGridView";
            this.roomDataGridView.ReadOnly = true;
            this.roomDataGridView.Size = new System.Drawing.Size(363, 220);
            this.roomDataGridView.TabIndex = 25;
            // 
            // showTimeBindingSource
            // 
            this.showTimeBindingSource.DataMember = "ShowTime";
            this.showTimeBindingSource.DataSource = this.project_DatabaseDataSet;
            // 
            // showTimeDataGridView
            // 
            this.showTimeDataGridView.AutoGenerateColumns = false;
            this.showTimeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showTimeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.showTimeDataGridView.DataSource = this.showTimeBindingSource;
            this.showTimeDataGridView.Location = new System.Drawing.Point(125, 142);
            this.showTimeDataGridView.Name = "showTimeDataGridView";
            this.showTimeDataGridView.ReadOnly = true;
            this.showTimeDataGridView.Size = new System.Drawing.Size(742, 220);
            this.showTimeDataGridView.TabIndex = 25;
            // 
            // moviesList
            // 
            this.moviesList.AutoSize = true;
            this.moviesList.Location = new System.Drawing.Point(213, 385);
            this.moviesList.Name = "moviesList";
            this.moviesList.Size = new System.Drawing.Size(60, 13);
            this.moviesList.TabIndex = 26;
            this.moviesList.Text = "Movies List";
            // 
            // roomList
            // 
            this.roomList.AutoSize = true;
            this.roomList.Location = new System.Drawing.Point(693, 385);
            this.roomList.Name = "roomList";
            this.roomList.Size = new System.Drawing.Size(59, 13);
            this.roomList.TabIndex = 27;
            this.roomList.Text = "Rooms List";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ShowTimeId";
            this.dataGridViewTextBoxColumn10.HeaderText = "ShowTimeId";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "RoomId";
            this.dataGridViewTextBoxColumn11.HeaderText = "RoomId";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "MovieId";
            this.dataGridViewTextBoxColumn12.HeaderText = "MovieId";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "StartTime";
            this.dataGridViewTextBoxColumn13.HeaderText = "StartTime";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RoomId";
            this.dataGridViewTextBoxColumn5.HeaderText = "RoomId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "RoomNo";
            this.dataGridViewTextBoxColumn8.HeaderText = "RoomNo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Screen8Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 725);
            this.Controls.Add(this.roomList);
            this.Controls.Add(this.moviesList);
            this.Controls.Add(this.showTimeDataGridView);
            this.Controls.Add(this.roomDataGridView);
            this.Controls.Add(this.movieDataGridView);
            this.Controls.Add(this.moviesLabel);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.idNumberLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userIdLabel);
            this.Name = "Screen8Form";
            this.Text = "Future Screenings";
            this.Load += new System.EventHandler(this.Screen8Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moviesLabel;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label idNumberLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Project_DatabaseDataSet project_DatabaseDataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private Project_DatabaseDataSetTableAdapters.MovieTableAdapter movieTableAdapter;
        private Project_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Project_DatabaseDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.DataGridView movieDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private Project_DatabaseDataSetTableAdapters.ShowTimeTableAdapter showTimeTableAdapter;
        private System.Windows.Forms.DataGridView roomDataGridView;
        private System.Windows.Forms.BindingSource showTimeBindingSource;
        private System.Windows.Forms.DataGridView showTimeDataGridView;
        private System.Windows.Forms.Label moviesList;
        private System.Windows.Forms.Label roomList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}