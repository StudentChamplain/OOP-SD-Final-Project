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
            this.showTimeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showTimeTableAdapter = new OOP_SD_Final_Project.Project_DatabaseDataSetTableAdapters.ShowTimeTableAdapter();
            this.tableAdapterManager = new OOP_SD_Final_Project.Project_DatabaseDataSetTableAdapters.TableAdapterManager();
            this.showTimeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.project_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTimeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // moviesLabel
            // 
            this.moviesLabel.AutoSize = true;
            this.moviesLabel.Location = new System.Drawing.Point(451, 130);
            this.moviesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moviesLabel.Name = "moviesLabel";
            this.moviesLabel.Size = new System.Drawing.Size(140, 16);
            this.moviesLabel.TabIndex = 24;
            this.moviesLabel.Text = "Upcoming Screenings";
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(447, 465);
            this.mainMenuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(152, 39);
            this.mainMenuButton.TabIndex = 23;
            this.mainMenuButton.Text = "Back";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(117, 75);
            this.companyNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(142, 16);
            this.companyNameLabel.TabIndex = 22;
            this.companyNameLabel.Text = "The Theater Company";
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idNumberLabel.Location = new System.Drawing.Point(824, 36);
            this.idNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(125, 40);
            this.idNumberLabel.TabIndex = 21;
            this.idNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(803, 90);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(87, 16);
            this.userNameLabel.TabIndex = 20;
            this.userNameLabel.Text = "USER NAME";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(761, 49);
            this.userIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(56, 16);
            this.userIdLabel.TabIndex = 19;
            this.userIdLabel.Text = "User Id: ";
            // 
            // project_DatabaseDataSet
            // 
            this.project_DatabaseDataSet.DataSetName = "Project_DatabaseDataSet";
            this.project_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showTimeBindingSource
            // 
            this.showTimeBindingSource.DataMember = "ShowTime";
            this.showTimeBindingSource.DataSource = this.project_DatabaseDataSet;
            // 
            // showTimeTableAdapter
            // 
            this.showTimeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.MovieTableAdapter = null;
            this.tableAdapterManager.RoomTableAdapter = null;
            this.tableAdapterManager.ShowTimeTableAdapter = null;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = OOP_SD_Final_Project.Project_DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // showTimeDataGridView
            // 
            this.showTimeDataGridView.AutoGenerateColumns = false;
            this.showTimeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showTimeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.Title,
            this.RoomNo});
            this.showTimeDataGridView.DataSource = this.showTimeBindingSource;
            this.showTimeDataGridView.Location = new System.Drawing.Point(184, 164);
            this.showTimeDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showTimeDataGridView.Name = "showTimeDataGridView";
            this.showTimeDataGridView.RowHeadersWidth = 51;
            this.showTimeDataGridView.Size = new System.Drawing.Size(569, 220);
            this.showTimeDataGridView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StartTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "StartTime";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 125;
            // 
            // RoomNo
            // 
            this.RoomNo.DataPropertyName = "RoomNo";
            this.RoomNo.HeaderText = "RoomNo";
            this.RoomNo.MinimumWidth = 6;
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.Width = 125;
            // 
            // Screen8Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.showTimeDataGridView);
            this.Controls.Add(this.moviesLabel);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.idNumberLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userIdLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Screen8Form";
            this.Text = "Future Screenings";
            this.Load += new System.EventHandler(this.Screen8Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.project_DatabaseDataSet)).EndInit();
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
        private Project_DatabaseDataSet project_DatabaseDataSet;
        private System.Windows.Forms.BindingSource showTimeBindingSource;
        private Project_DatabaseDataSetTableAdapters.ShowTimeTableAdapter showTimeTableAdapter;
        private Project_DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView showTimeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
    }
}