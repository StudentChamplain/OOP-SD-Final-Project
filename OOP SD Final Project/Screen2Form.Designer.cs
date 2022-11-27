using System.Windows.Forms;

namespace OOP_Design_Project
{
    partial class Screen2Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.consultMoviesButton = new System.Windows.Forms.Button();
            this.consultRoomsButton = new System.Windows.Forms.Button();
            this.consultScreeningsButton = new System.Windows.Forms.Button();
            this.logOffButton = new System.Windows.Forms.Button();
            this.consultClientsButton = new System.Windows.Forms.Button();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.idNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // consultMoviesButton
            // 
            this.consultMoviesButton.Location = new System.Drawing.Point(120, 67);
            this.consultMoviesButton.Name = "consultMoviesButton";
            this.consultMoviesButton.Size = new System.Drawing.Size(114, 49);
            this.consultMoviesButton.TabIndex = 0;
            this.consultMoviesButton.Text = "Movies";
            this.consultMoviesButton.UseVisualStyleBackColor = true;
            // 
            // consultRoomsButton
            // 
            this.consultRoomsButton.Location = new System.Drawing.Point(120, 235);
            this.consultRoomsButton.Name = "consultRoomsButton";
            this.consultRoomsButton.Size = new System.Drawing.Size(114, 49);
            this.consultRoomsButton.TabIndex = 1;
            this.consultRoomsButton.Text = "Screening Rooms";
            this.consultRoomsButton.UseVisualStyleBackColor = true;
            // 
            // consultScreeningsButton
            // 
            this.consultScreeningsButton.Location = new System.Drawing.Point(120, 153);
            this.consultScreeningsButton.Name = "consultScreeningsButton";
            this.consultScreeningsButton.Size = new System.Drawing.Size(114, 49);
            this.consultScreeningsButton.TabIndex = 2;
            this.consultScreeningsButton.Text = "Screenings";
            this.consultScreeningsButton.UseVisualStyleBackColor = true;
            // 
            // logOffButton
            // 
            this.logOffButton.Location = new System.Drawing.Point(375, 188);
            this.logOffButton.Name = "logOffButton";
            this.logOffButton.Size = new System.Drawing.Size(114, 49);
            this.logOffButton.TabIndex = 3;
            this.logOffButton.Text = "Log Out";
            this.logOffButton.UseVisualStyleBackColor = true;
            // 
            // consultClientsButton
            // 
            this.consultClientsButton.Location = new System.Drawing.Point(375, 93);
            this.consultClientsButton.Name = "consultClientsButton";
            this.consultClientsButton.Size = new System.Drawing.Size(114, 49);
            this.consultClientsButton.TabIndex = 4;
            this.consultClientsButton.Text = "Clients";
            this.consultClientsButton.UseVisualStyleBackColor = true;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(64, 19);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(113, 13);
            this.companyNameLabel.TabIndex = 5;
            this.companyNameLabel.Text = "The Theater Company";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(521, 19);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(47, 13);
            this.userIdLabel.TabIndex = 6;
            this.userIdLabel.Text = "User Id: ";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(552, 52);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(71, 13);
            this.userNameLabel.TabIndex = 7;
            this.userNameLabel.Text = "USER NAME";
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idNumberLabel.Location = new System.Drawing.Point(568, 8);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(94, 33);
            this.idNumberLabel.TabIndex = 8;
            // 
            // Screen2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.idNumberLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.consultClientsButton);
            this.Controls.Add(this.logOffButton);
            this.Controls.Add(this.consultScreeningsButton);
            this.Controls.Add(this.consultRoomsButton);
            this.Controls.Add(this.consultMoviesButton);
            this.Name = "Screen2Form";
            this.Text = "Manager Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button consultMoviesButton;
        private Button consultRoomsButton;
        private Button consultScreeningsButton;
        private Button logOffButton;
        private Button consultClientsButton;
        private Label companyNameLabel;
        private Label userIdLabel;
        private Label userNameLabel;
        private Label idNumberLabel;
    }
}