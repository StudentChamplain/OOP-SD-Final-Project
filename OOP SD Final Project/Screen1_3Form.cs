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
    public partial class Screen1_3Form : Form
    {
        /// <summary>
        /// 
        /// Form Constructor which loads components of Screen1_3Form.
        /// </summary>
        public Screen1_3Form()
        {
            InitializeComponent();
            MakeActiveUser();       // Temporary until users are integrated.
        }

        /// <summary>
        /// Button which leads User to Form 7 (Client Main Menu) or Form 2 (Manager Main Menu) 
         /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logInButton_Click(object sender, EventArgs e)
        {

            this.userTableAdapter.GetDataBy1(emailTextBox.Text, passwordTextBox.Text);
            // if User holds a Client User.Role 
            if( false/*USER IS PART OF THE CLIENTS*/)
            {
                this.Hide();

                Screen7Form form7 = new Screen7Form();
                form7.Show();
            }
            // if User holds a Manager User.Role 
            else if (true /*USER IS PART OF THE MANAGERS*/)
            {
                this.Hide();
                Screen2Form form2 = new Screen2Form();
                form2.Show();

            }



        }
        /// <summary>
        /// Button which hides and closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
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

        /// <summary>
        /// A method to assign an example of an active user.
        /// </summary>
        /// <remarks>Temporary. Will be removed when user log-in is integrated.</remarks>
        private void MakeActiveUser()
        {
            User newUser = new User(000111, "Alex", "Kidd");

            User.ActiveUser = newUser;
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_DatabaseDataSet);

        }

        private void Screen1_3Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DatabaseDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.project_DatabaseDataSet.User);

        }
    }
}
