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
    public partial class Screen1_1Form : Form
    {
        /// <summary>
        /// 
        /// Form Constructor which loads components of Screen1_1Form.
        /// </summary>
        public Screen1_1Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button which leads User to Form 1.2 (Sign-up Confirmation)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signUpConfirmationButton_Click(object sender, EventArgs e)
        {
            Screen1_2Form form1_2 = new Screen1_2Form();
            form1_2.Show();
            this.Hide();
        }

        /// <summary>
        /// Button which hides and closes the form.
        /// </summary>
        /// <param name="sender">   </param>
        /// <param name="e">   </param>
        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
        /// <summary>
        /// Function which overrides the closing button and the this.Close() function from before, and leads the user back to Screen1Form (Main menu). 
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
