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
    public partial class Screen9Form : Form
    {
        public Screen9Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Button which leads User to Form 8 (List Of Screenings)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Screen7Form form7 = new Screen7Form();
            form7.Show();
        }


        /// <summary>
        /// Function which overrides the closing button  and leads the user back to Screen7Form (Main menu). 
        ///  </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            this.Hide();

            Screen7Form form7 = new Screen7Form();
            form7.Show();

        }
    }
}
