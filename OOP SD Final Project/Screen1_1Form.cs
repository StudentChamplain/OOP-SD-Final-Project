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
    public partial class Screen1_1Form : Form
    {





        /*
         
         INSERT INTO [User] (Email, FirstName, LastName, Password, SignUpDateTime, Role) VALUES (@Email,@FirstName,@LastName,@Password,@SignUpDateTime,@Role); 

         
         
         
         
         */
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
           
            if(ValidateEmail() == true)
            {
                //INSERTING THE USER INTO THE USERS TABLE

                DateTime now = DateTime.Now;
                string connstring = "Data Source = (LocalDB)\\MSSQLLocalDB; " +
                    "AttachDbFilename = C:\\xyz\\Project Database.mdf; Integrated Security = True; Connect Timeout = 30";
                SqlConnection con = new SqlConnection(connstring);
                con.Open();
                string query = "INSERT INTO [dbo].[User] ([Email], [FirstName], [LastName], [Password], [SignUpDateTime], [Role]) VALUES ('" + emailTextBox.Text.Trim() + "', '" + firstNameTextBox.Text + "' , '" + lastNameTextBox.Text + "' , '" + passwordTextBox.Text + "' , '" + now + "',  '" + "Client" + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();


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

                    User.ActiveUser = new User(userId, firstName, lastName);
                }

                con.Close();



                //Client newCLient = new Client();

                Screen1_2Form form1_2 = new Screen1_2Form();
                form1_2.Show();
                this.Hide();
            }

        }

        /*INSERT INTO [dbo].[User] ([Email], [FirstName], [LastName], [Password], [SignUpDateTime], [Role]) VALUES (@Email, @FirstName, @LastName, @Password, @SignUpDateTime, @Role);
    SELECT UserId, Email, FirstName, LastName, Password, SignUpDateTime, Role FROM [User] WHERE (UserId = SCOPE_IDENTITY())
         * 
         */

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

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_DatabaseDataSet);

        }

        private void Screen1_1Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DatabaseDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.project_DatabaseDataSet.User);

        }

        private bool ValidateEmail()
        {
            string email = emailTextBox.Text.Trim();
            bool isValid = false;

            if (email.Contains('@'))
            {
                string connstring = "Data Source = (LocalDB)\\MSSQLLocalDB; " +
                    "AttachDbFilename = C:\\xyz\\Project Database.mdf; Integrated Security = True; Connect Timeout = 30";
                SqlConnection con = new SqlConnection(connstring);
                con.Open();
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
            }
            else
            {
                MessageBox.Show("Please enter a valid email address.");
            }

            return isValid;
        }
    }
}
