using ExtensionMethods;
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
    /// <summary>
    /// The client's form to consult the list of Showtimes.
    /// </summary>
    public partial class Screen8Form : Form
    {
        /// <summary>
        /// Form Constructor which loads components of Screen8Form.
        /// </summary>
        public Screen8Form()
        {
            InitializeComponent();
            this.SetUserInfo(idNumberLabel, userNameLabel);
        }
        /// <summary>
        /// Button which leads Client back to Form 7 (Sign-up Confirmation)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Screen7Form form7 = new Screen7Form();
            form7.Show();
            this.Hide();
        }

        /// <summary>
        /// Function which overrides the closing button and leads the user back to Screen7Form (Main menu). 
        ///  </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            this.Hide();

            Screen7Form form7 = new Screen7Form();
            form7.Show();

        }
        /// <summary>
        /// loads data into the 'project_DatabaseDataSet.ShowTime' table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Screen8Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DatabaseDataSet.ShowTime' table. You can move, or remove it, as needed.
            this.showTimeTableAdapter.Fill(this.project_DatabaseDataSet.ShowTime);
            // TODO: This line of code loads data into the 'project_DatabaseDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.project_DatabaseDataSet.Room);
            // TODO: This line of code loads data into the 'project_DatabaseDataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.project_DatabaseDataSet.Movie);
            // TODO: This line of code loads data into the 'project_DatabaseDataSet.ShowTime' table. You can move, or remove it, as needed.
            this.showTimeTableAdapter.Fill(this.project_DatabaseDataSet.ShowTime);

        }

        private void movieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_DatabaseDataSet);

        }

    }
}
