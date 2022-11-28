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
    public partial class Screen2Form : Form
    {
        /// <summary>
        /// 
        /// Form Constructor which loads components of Screen2Form.
        /// </summary>
        public Screen2Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button which leads User to Form 3 (Movies List)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consultMoviesButton_Click(object sender, EventArgs e)
        {

            this.Hide();

            Screen3Form form3 = new Screen3Form();
            form3.Show();

        }

        /// <summary>
        /// Button which leads User to Form 4 (Screenings List)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consultScreeningsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Screen4Form form4 = new Screen4Form();
            form4.Show();

        }

        /// <summary>
        /// Button which leads User to Form 5 (Rooms List)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consultRoomsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Screen5Form form5 = new Screen5Form();
            form5.Show();

        }

        /// <summary>
        /// Button which leads User to Form 6 (CLients List)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void consultClientsButton_Click(object sender, EventArgs e)
        {

            this.Hide();

            Screen6Form form6 = new Screen6Form();
            form6.Show();

        }

        /// <summary>
        /// Button which Logs-Off the user and leads them to to Form 1 (Main Menu)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logOffButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Screen1Form form1 = new Screen1Form();
            form1.Show();

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
