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
        public Screen2Form(User currentUser)
        {
            InitializeComponent();
            SetUserInfo(currentUser.StringifyId(), currentUser.FullName);
        }

        public void SetUserInfo(string Id, string name)
        {
            this.idNumberLabel.Text = Id.ToString();
            this.userNameLabel.Text = name;
        }

    }
}
