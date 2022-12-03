namespace OOP_SD_Final_Project
{
    partial class Screen8Form
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
            this.moviesLabel = new System.Windows.Forms.Label();
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.idNumberLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moviesLabel
            // 
            this.moviesLabel.AutoSize = true;
            this.moviesLabel.Location = new System.Drawing.Point(338, 106);
            this.moviesLabel.Name = "moviesLabel";
            this.moviesLabel.Size = new System.Drawing.Size(111, 13);
            this.moviesLabel.TabIndex = 24;
            this.moviesLabel.Text = "Upcoming Screenings";
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(335, 378);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(114, 32);
            this.mainMenuButton.TabIndex = 23;
            this.mainMenuButton.Text = "Back";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(88, 61);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(113, 13);
            this.companyNameLabel.TabIndex = 22;
            this.companyNameLabel.Text = "The Theater Company";
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idNumberLabel.Location = new System.Drawing.Point(618, 29);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(94, 33);
            this.idNumberLabel.TabIndex = 21;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(602, 73);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(71, 13);
            this.userNameLabel.TabIndex = 20;
            this.userNameLabel.Text = "USER NAME";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(571, 40);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(47, 13);
            this.userIdLabel.TabIndex = 19;
            this.userIdLabel.Text = "User Id: ";
            // 
            // Screen8Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moviesLabel);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.idNumberLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userIdLabel);
            this.Name = "Screen8Form";
            this.Text = "Future Screenings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moviesLabel;
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label idNumberLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userIdLabel;
    }
}