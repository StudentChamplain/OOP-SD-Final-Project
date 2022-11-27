﻿using OOP_Design_Project;
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
    public partial class Screen5Form : Form
    {
        public Screen5Form()
        {
            InitializeComponent();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Screen2Form form2 = new Screen2Form();
            form2.Show();
            this.Hide();
        }
        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            this.Hide();
            Screen2Form form2 = new Screen2Form();
            form2.Show();


        }

    }
}
