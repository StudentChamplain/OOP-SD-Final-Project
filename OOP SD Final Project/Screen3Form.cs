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
    public partial class Screen3Form : Form
    {
        /// <summary>
        /// 
        /// Form Constructor which loads components of Screen3Form.
        /// </summary>
        public Screen3Form()
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
            Screen2Form form2= new Screen2Form();
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
        /// This button saves items into the Database when values are modified in the Form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_DatabaseDataSet);

        }
        /// <summary>
        /// Loads data into the 'project_DatabaseDataSet.User' table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Screen3Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DatabaseDataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.project_DatabaseDataSet.Movie);

        }
    }
}
