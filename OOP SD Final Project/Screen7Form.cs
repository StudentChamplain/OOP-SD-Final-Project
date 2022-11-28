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
    public partial class Screen7Form : Form
    {

        /// <summary>
        /// 
        /// Form Constructor which loads components of Screen7Form.
        /// </summary>
        public Screen7Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Button which leads Client to Form8 (Screenings List) 
        /// </summary>
        /// <param name="sender">   </param>
        /// <param name="e">   </param>
        private void screeningsButton_Click(object sender, EventArgs e)
        {
            Screen8Form form8 = new Screen8Form();
            form8.Show();
            this.Hide();


        }
        /// <summary>
        /// Button which logs out the Client and sends him back to the Main Menu Form (Screen1).
        /// </summary>
        /// <param name="sender">   </param>
        /// <param name="e">   </param>
        private void logOutButton_Click(object sender, EventArgs e)
        {
            Screen1Form form1 = new Screen1Form();
            form1.Show();
            this.Hide();
        }
        /// <summary>
        /// Function which overrides the closing button  and leads the user back to Screen1Form (Manager Main Menu). 
        ///  </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            this.Hide();

            Screen1Form form1 = new Screen1Form();
            form1.Show();

        }
    }
}
