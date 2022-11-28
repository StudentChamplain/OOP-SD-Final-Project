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
    public partial class Screen6Form : Form
    {
        /// <summary>
        /// 
        /// Form Constructor which loads components of Screen6Form.
        /// </summary>
        public Screen6Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button which leads User to Form 2 (Manager Main Menu)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Screen2Form form2 = new Screen2Form();
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
    }
}