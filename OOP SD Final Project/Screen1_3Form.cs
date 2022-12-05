using OOP_Design_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            if (ValidateEmail())
            {
                string password = passwordTextBox.Text;
                string email = emailTextBox.Text;



                string connstring = "Data Source = (LocalDB)\\MSSQLLocalDB; " +
                    "AttachDbFilename = C:\\xyz\\Project Database.mdf; Integrated Security = True; Connect Timeout = 30";
                SqlConnection con = new SqlConnection(connstring);
                con.Open();
                string query = "Select * from [User] where Password= '" + password + "' AND Email ='" + email + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();

                int userId;
                string firstName = "";
                string lastName = "";
                string role = "";
                bool verification = false;

                while (reader.Read())
                {
                    userId = int.Parse(reader["UserId"].ToString());
                    firstName = reader["FirstName"].ToString();
                    lastName = reader["LastName"].ToString();
                    role = reader["Role"].ToString();
                    MessageBox.Show(userId.ToString());
                    verification = true;

                    // Set the active user to contain the relevant data.
                    User.ActiveUser = new User(userId, firstName, lastName);

                }

                //  VERIFY WITH NOAH HOW TO IDENTIFY IF A USER IS A MANAGER OR A CLIENT
                if (verification)
                {
                    MessageBox.Show("logged in");

                    if (role == "Client")/*USER IS PART OF THE CLIENTS*/
                    {
                        this.Hide();

                        Screen7Form form7 = new Screen7Form();
                        form7.Show();
                    }
                    // if User holds a Manager User.Role 
                    else if (role == "Manager")
                    {
                        this.Hide();
                        Screen2Form form2 = new Screen2Form();
                        form2.Show();

                    }


                }
                else
                {
                    MessageBox.Show("wrong email or password");
                }
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

        private bool ValidateEmail()
        {
            string email = emailTextBox.Text.Trim();

            if (email.Contains('@'))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter a valid email address.");
                
                return false;
            }
        }

    }
}
