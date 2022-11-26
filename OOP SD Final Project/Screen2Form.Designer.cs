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
            this.consultMoviesButton.Location = new System.Drawing.Point(160, 82);
            this.consultMoviesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.consultMoviesButton.Name = "consultMoviesButton";
            this.consultMoviesButton.Size = new System.Drawing.Size(152, 60);
            this.consultMoviesButton.TabIndex = 0;
            this.consultMoviesButton.Text = "Movies";
            this.consultMoviesButton.UseVisualStyleBackColor = true;
            // 
            // consultRoomsButton
            // 
            this.consultRoomsButton.Location = new System.Drawing.Point(160, 289);
            this.consultRoomsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.consultRoomsButton.Name = "consultRoomsButton";
            this.consultRoomsButton.Size = new System.Drawing.Size(152, 60);
            this.consultRoomsButton.TabIndex = 1;
            this.consultRoomsButton.Text = "Screening Rooms";
            this.consultRoomsButton.UseVisualStyleBackColor = true;
            // 
            // consultScreeningsButton
            // 
            this.consultScreeningsButton.Location = new System.Drawing.Point(160, 188);
            this.consultScreeningsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.consultScreeningsButton.Name = "consultScreeningsButton";
            this.consultScreeningsButton.Size = new System.Drawing.Size(152, 60);
            this.consultScreeningsButton.TabIndex = 2;
            this.consultScreeningsButton.Text = "Screenings";
            this.consultScreeningsButton.UseVisualStyleBackColor = true;
            // 
            // logOffButton
            // 
            this.logOffButton.Location = new System.Drawing.Point(500, 231);
            this.logOffButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logOffButton.Name = "logOffButton";
            this.logOffButton.Size = new System.Drawing.Size(152, 60);
            this.logOffButton.TabIndex = 3;
            this.logOffButton.Text = "Log Out";
            this.logOffButton.UseVisualStyleBackColor = true;
            // 
            // consultClientsButton
            // 
            this.consultClientsButton.Location = new System.Drawing.Point(500, 114);
            this.consultClientsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.consultClientsButton.Name = "consultClientsButton";
            this.consultClientsButton.Size = new System.Drawing.Size(152, 60);
            this.consultClientsButton.TabIndex = 4;
            this.consultClientsButton.Text = "Clients";
            this.consultClientsButton.UseVisualStyleBackColor = true;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(85, 23);
            this.companyNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(142, 16);
            this.companyNameLabel.TabIndex = 5;
            this.companyNameLabel.Text = "The Theater Company";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(695, 23);
            this.userIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(56, 16);
            this.userIdLabel.TabIndex = 6;
            this.userIdLabel.Text = "User Id: ";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(736, 64);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(87, 16);
            this.userNameLabel.TabIndex = 7;
            this.userNameLabel.Text = "USER NAME";
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idNumberLabel.Location = new System.Drawing.Point(757, 10);
            this.idNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(125, 40);
            this.idNumberLabel.TabIndex = 8;
            this.idNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Screen2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 480);
            this.Controls.Add(this.idNumberLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userIdLabel);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.consultClientsButton);
            this.Controls.Add(this.logOffButton);
            this.Controls.Add(this.consultScreeningsButton);
            this.Controls.Add(this.consultRoomsButton);
            this.Controls.Add(this.consultMoviesButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private Label companyNameLabel;
        private Label userIdLabel;
        private Label userNameLabel;
        private Label idNumberLabel;
    }
}