﻿using System;
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
    public partial class Screen8Form : Form
    {/// <summary>
     /// 
     /// Form Constructor which loads components of Screen8Form.
     /// </summary>
        public Screen8Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Button which leads Client back to Form 7 (Sign-up Confirmation)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Screen7Form form7 = new Screen7Form();
            form7.Show();
            this.Hide();
        }

        /// <summary>
        /// Function which overrides the closing button and leads the user back to Screen7Form (Main menu). 
        ///  </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            this.Hide();

            Screen7Form form7 = new Screen7Form();
            form7.Show();

        }
    }
}