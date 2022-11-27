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
        public Screen1_1Form()
        {
            InitializeComponent();
        }

        private void signUpConfirmationButton_Click(object sender, EventArgs e)
        {
            Screen1_2Form form = new Screen1_2Form();
            form.ShowDialog();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
