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
            this.companyLogoLabel = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.idNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // consultMoviesButton
            // 
            this.consultMoviesButton.Location = new System.Drawing.Point(140, 77);
            this.consultMoviesButton.Name = "consultMoviesButton";
            this.consultMoviesButton.Size = new System.Drawing.Size(133, 56);
            this.consultMoviesButton.TabIndex = 0;
            this.consultMoviesButton.Text = "Movies";
            this.consultMoviesButton.UseVisualStyleBackColor = true;
            // 
            // consultRoomsButton
            // 
            this.consultRoomsButton.Location = new System.Drawing.Point(140, 271);
            this.consultRoomsButton.Name = "consultRoomsButton";
            this.consultRoomsButton.Size = new System.Drawing.Size(133, 56);
            this.consultRoomsButton.TabIndex = 1;
            this.consultRoomsButton.Text = "Screening Rooms";
            this.consultRoomsButton.UseVisualStyleBackColor = true;
            // 
            // consultScreeningsButton
            // 
            this.consultScreeningsButton.Location = new System.Drawing.Point(140, 176);
            this.consultScreeningsButton.Name = "consultScreeningsButton";
            this.consultScreeningsButton.Size = new System.Drawing.Size(133, 56);
            this.consultScreeningsButton.TabIndex = 2;
            this.consultScreeningsButton.Text = "Screenings";
            this.consultScreeningsButton.UseVisualStyleBackColor = true;
            // 
            // logOffButton
            // 
            this.logOffButton.Location = new System.Drawing.Point(438, 217);
            this.logOffButton.Name = "logOffButton";
            this.logOffButton.Size = new System.Drawing.Size(133, 56);
            this.logOffButton.TabIndex = 3;
            this.logOffButton.Text = "Log Out";
            this.logOffButton.UseVisualStyleBackColor = true;
            // 
            // consultClientsButton
            // 
            this.consultClientsButton.Location = new System.Drawing.Point(438, 107);
            this.consultClientsButton.Name = "consultClientsButton";
            this.consultClientsButton.Size = new System.Drawing.Size(133, 56);
            this.consultClientsButton.TabIndex = 4;
            this.consultClientsButton.Text = "Clients";
            this.consultClientsButton.UseVisualStyleBackColor = true;
            // 
            // companyLogoLabel
            // 
            this.companyLogoLabel.AutoSize = true;
            this.companyLogoLabel.Location = new System.Drawing.Point(75, 22);
            this.companyLogoLabel.Name = "companyLogoLabel";
            this.companyLogoLabel.Size = new System.Drawing.Size(92, 15);
            this.companyLogoLabel.TabIndex = 5;
            this.companyLogoLabel.Text = "Company Logo ";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(608, 22);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(49, 15);
            this.userIdLabel.TabIndex = 6;
            this.userIdLabel.Text = "User Id: ";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(644, 60);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(71, 15);
            this.userNameLabel.TabIndex = 7;
            this.userNameLabel.Text = "USER NAME";
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idNumberLabel.Location = new System.Drawing.Point(663, 9);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(109, 38);
            this.idNumberLabel.TabIndex = 8;
            // 
            // Screen2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.idNumberLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.companyLogoLabel);
            this.Controls.Add(this.consultClientsButton);
            this.Controls.Add(this.logOffButton);
            this.Controls.Add(this.consultScreeningsButton);
            this.Controls.Add(this.consultRoomsButton);
            this.Controls.Add(this.consultMoviesButton);
            this.Name = "Screen2Form";
            this.Text = "Screen2Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button consultMoviesButton;
        private Button consultRoomsButton;
        private Button consultScreeningsButton;
        private Button logOffButton;
        private Button consultClientsButton;
        private Label companyLogoLabel;
        private Label userIdLabel;
        private Label userNameLabel;
        private Label idNumberLabel;
    }
}