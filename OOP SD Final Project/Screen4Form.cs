using ExtensionMethods;
using OOP_Design_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_SD_Final_Project
{
    public partial class Screen4Form : Form
    {
        /// <summary>
        /// 
        /// Form Constructor which loads components of Screen4Form.
        /// </summary>
        public Screen4Form()
        {
            InitializeComponent();
            this.SetUserInfo(idNumberLabel, userNameLabel);
        }

        /// <summary>
        /// Button which leads User to Form 2 (Manager Main Menu)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Screen2Form form2 = new Screen2Form();
            form2.Show();
            this.Hide();
        }

        /// <summary>
        /// Function which overrides the closing button  and leads the user back to Screen2Form (Manager Main Menu). 
        ///  </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            this.Hide();
            Screen2Form form2 = new Screen2Form();
            form2.Show();


        }
        /// <summary>
        /// This button saves the values to the database when clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showTimeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.showTimeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_DatabaseDataSet);

        }

        /// <summary>
        ///  Loads data into the different tables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Screen4Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DatabaseDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.project_DatabaseDataSet.Room);
            // TODO: This line of code loads data into the 'project_DatabaseDataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.project_DatabaseDataSet.Movie);
            // TODO: This line of code loads data into the 'project_DatabaseDataSet.ShowTime' table. You can move, or remove it, as needed.
            this.showTimeTableAdapter.Fill(this.project_DatabaseDataSet.ShowTime);
            // TODO: This line of code loads data into the 'project_DatabaseDataSet.ShowTime' table. You can move, or remove it, as needed.
            this.showTimeTableAdapter.Fill(this.project_DatabaseDataSet.ShowTime);

        }

        /// <summary>
        /// This button saves the values to the database when clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showTimeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.showTimeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_DatabaseDataSet);

        }
    }
}
