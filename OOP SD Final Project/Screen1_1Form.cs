using OOP_SD_Final_Project;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OOP_Design_Project
{
    /// <summary>
    /// Form in which the user enters their credentials to create an account.
    /// </summary>
    public partial class Screen1_1Form : Form
    {
        /// <summary>
        /// Form Constructor which loads components of Screen1_1Form.
        /// </summary>
        public Screen1_1Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button will lead User to a Login Confirmation form if the email is validated to be unique 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void signUpConfirmationButton_Click(object sender, EventArgs e)
        {
           
            if(ValidateEmail() == true)
            {
                
                DateTime now = DateTime.Now;

                SqlConnection con = DBConnection.getInstance();

                string query = "INSERT INTO [dbo].[User] ([Email], [FirstName], [LastName], [Password], [SignUpDateTime], [Role]) VALUES ('" + emailTextBox.Text.Trim() + "', '" + firstNameTextBox.Text + "' , '" + lastNameTextBox.Text + "' , '" + passwordTextBox.Text + "' , '" + now + "',  '" + "Client" + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();


                // Get the data from the user that was created.
                query = "Select * from [User] where Email ='" + emailTextBox.Text.Trim() + "'";
                cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                int userId;
                string firstName = "";
                string lastName = "";

                while (reader.Read())
                {
                    userId = int.Parse(reader["UserId"].ToString());
                    firstName = reader["FirstName"].ToString();
                    lastName = reader["LastName"].ToString();

                    // Set the active user to contain the relevant data.
                    User.ActiveUser = new User(userId, firstName, lastName);
                }

                con.Close();

                Screen1_2Form form1_2 = new Screen1_2Form();
                form1_2.Show();
                this.Hide();
            }

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
        /// <summary>
        /// When clicking on save button the form will be saving the changes to the database 
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
        /// Loads data into the 'project_DatabaseDataSet.User' table. You can move, or remove it, as needed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Screen1_1Form_Load(object sender, EventArgs e)
        {
            
            this.userTableAdapter.Fill(this.project_DatabaseDataSet.User);

        }
        /// <summary>
        /// This method will connect to the database and verify if the email has already been taken or if the email entered contains a "@" symbol. If so it returns a true value.
        /// </summary>
        /// <returns> bool = isValid </returns>
        private bool ValidateEmail()
        {
            string email = emailTextBox.Text.Trim();
            bool isValid = false;

            if (email.Contains('@'))
            {
                SqlConnection con = DBConnection.getInstance();

                string query = "Select * from [User] where Email ='" + email + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();

                bool verification = false;

                while (reader.Read())
                {
                    verification = true;
                }

                if (verification == true)
                {
                    MessageBox.Show("That email is already taken.");
                }
                else
                {
                    isValid = true;
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid email address.");
            }
           
            return isValid;
        }
    }
}
