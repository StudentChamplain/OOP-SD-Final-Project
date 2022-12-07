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
    public partial class Screen5Form : Form
    {
        
        /// <summary>
     /// 
     /// Form Constructor which loads components of Screen5Form.
     /// </summary>
        public Screen5Form()
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
        /// This button will be saving the changes done to the datagrid view to the database 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_DatabaseDataSet);

        }
        /// <summary>
        /// loads data into the 'project_DatabaseDataSet.Room' table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Screen5Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code  You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.project_DatabaseDataSet.Room);

        }
    }
}
