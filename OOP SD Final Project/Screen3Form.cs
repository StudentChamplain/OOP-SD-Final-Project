using ExtensionMethods;
using OOP_Design_Project;
using System;
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

namespace OOP_SD_Final_Project
{
    public partial class Screen3Form : Form
    {
        /// <summary>
        /// 
        /// Form Constructor which loads components of Screen3Form.
        /// </summary>
        public Screen3Form()
        {
            InitializeComponent();
            this.SetUserInfo(idNumberLabel, userNameLabel);
        }

        /// <summary>
        /// Button which leads User to Form 2 (Manager Main Menu)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Screen2Form form2= new Screen2Form();
            form2.Show();
            this.Hide();
        }

        /// <summary>
        /// Function which overrides the closing button  and leads the user back to Screen2Form (Manager Main Menu). 
        ///  </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            this.Hide();

            Screen2Form form2 = new Screen2Form();
            form2.Show();

        }
        /// <summary>
        /// This button saves items into the Database when values are modified in the Form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void movieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.movieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_DatabaseDataSet);

        }
        /// <summary>
        /// Loads data into the 'project_DatabaseDataSet.User' table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Screen3Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DatabaseDataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.project_DatabaseDataSet.Movie);



            string connstring = "Data Source = (LocalDB)\\MSSQLLocalDB; " +
                    "AttachDbFilename = C:\\xyz\\Project Database.mdf; Integrated Security = True; Connect Timeout = 30";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            string query = "select m.MovieId,\r\n\tm.Title,\r\n\tm.Genre,\r\n\tm.Minutes,\r\n\tSUM(s.TicketsSold) TicketsSold\r\nfrom ShowTime s\r\ninner join Movie m on\r\nm.MovieId = s.MovieId\r\nGROUP BY m.MovieId, m.Title, m.Genre, m.Minutes";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader = cmd.ExecuteReader();

            string movieTitle;
            string ticketsSold;
            string displayString;

            listBox1.Items.Add("Title - Tickets Sold");

            while (reader.Read())
            {
                movieTitle = reader["Title"].ToString();
                ticketsSold = reader["TicketsSold"].ToString();

                displayString = movieTitle+ " -  " + ticketsSold;
               

                listBox1.Items.Add(displayString);
            }
        }
    }
}
