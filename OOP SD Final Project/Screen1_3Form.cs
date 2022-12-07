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
        /// When clicking on the button the program will connect to the database and verify the user email and the password were not already taken. If they are not taken the program will add the values to the table USers and direct the User either to Client Section of the Program or the Manager Section 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logInButton_Click(object sender, EventArgs e)
        {
            //email Validation
            if (ValidateEmail())
            {
                string password = passwordTextBox.Text;
                string email = emailTextBox.Text;



               
                //link to SQL Connection 
                SqlConnection con = DBConnection.getInstance();
                

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
                 
                    verification = true;

                    // Set the active user to contain the relevant data.
                    User.ActiveUser = new User(userId, firstName, lastName);

                }

               
                if (verification)
                {
                    

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

                con.Close();
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
        /// <summary>
        /// this Methodd will save the changes done to the database when clickin on the save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_DatabaseDataSet);

        }
        /// <summary>
        /// Loads data into the 'project_DatabaseDataSet.User' table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Screen1_3Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DatabaseDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.project_DatabaseDataSet.User);

        }

        /// <summary>
        /// this method will validate if the email has a "@" symbol and if so it will return a true statement.
        /// </summary>
        /// <returns>bool </returns>
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
