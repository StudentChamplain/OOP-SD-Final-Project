using OOP_SD_Final_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Design_Project
{
    public partial class Screen1_2Form : Form
    {
        /// <summary>
        /// Form Constructor which loads components of Screen1_2Form.
        /// </summary>
        public Screen1_2Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Button which leads User to Form 7 (Client Main menu)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logInButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Screen7Form form7 = new Screen7Form();
            form7.Show();


        }
        /// <summary>
        /// Button which hides and closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Screen1Form form1 = new Screen1Form();
            form1.Show();
        }

        /// <summary>
        /// Function which overrides the closing button and the this.Close() function from before, and leads  user  to the Client Main Menu (Client Main menu). 
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
