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
    public partial class Screen1Form : Form
    {
        /// <summary>
        /// Form Constructor which loads components of Screen1Form.
        /// </summary>
        public Screen1Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Button which leads User to Form 1.3 (Log-in)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logInButton_Click(object sender, EventArgs e)
        {
            Screen1_3Form form1_3 = new Screen1_3Form();
            form1_3.Show();
            this.Hide();

        }
        /// <summary>
        /// Button which leads User to Form 1.1 (Sign-Up)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signUpButton_Click(object sender, EventArgs e)
        {
            


            Screen1_1Form form1_1 = new Screen1_1Form();

            form1_1.Show();
            this.Hide();

        }
        /// <summary>
        /// Function which overrides the closing button from the form and shuts down the whole application. 
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Environment.Exit(1);
        }

    }
}
