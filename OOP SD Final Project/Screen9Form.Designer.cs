namespace OOP_SD_Final_Project
{
    partial class Screen9Form
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
            this.mainMenuButton = new System.Windows.Forms.Button();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.idNumberLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.movieTitleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.showtimeLabel = new System.Windows.Forms.Label();
            this.showtimeInfoLabel = new System.Windows.Forms.Label();
            this.durationInfoLabel = new System.Windows.Forms.Label();
            this.roomInfoLabel = new System.Windows.Forms.Label();
            this.genreInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuButton
            // 
            this.mainMenuButton.Location = new System.Drawing.Point(335, 384);
            this.mainMenuButton.Name = "mainMenuButton";
            this.mainMenuButton.Size = new System.Drawing.Size(114, 32);
            this.mainMenuButton.TabIndex = 30;
            this.mainMenuButton.Text = "Back";
            this.mainMenuButton.UseVisualStyleBackColor = true;
            this.mainMenuButton.Click += new System.EventHandler(this.mainMenuButton_Click);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(88, 67);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(113, 13);
            this.companyNameLabel.TabIndex = 29;
            this.companyNameLabel.Text = "The Theater Company";
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idNumberLabel.Location = new System.Drawing.Point(618, 35);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(94, 33);
            this.idNumberLabel.TabIndex = 28;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(602, 79);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(71, 13);
            this.userNameLabel.TabIndex = 27;
            this.userNameLabel.Text = "USER NAME";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(571, 46);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(47, 13);
            this.userIdLabel.TabIndex = 26;
            this.userIdLabel.Text = "User Id: ";
            // 
            // movieTitleLabel
            // 
            this.movieTitleLabel.AutoSize = true;
            this.movieTitleLabel.Location = new System.Drawing.Point(392, 105);
            this.movieTitleLabel.Name = "movieTitleLabel";
            this.movieTitleLabel.Size = new System.Drawing.Size(74, 13);
            this.movieTitleLabel.TabIndex = 31;
            this.movieTitleLabel.Text = "MOVIE TITLE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(103, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 167);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(332, 134);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(45, 13);
            this.genreLabel.TabIndex = 34;
            this.genreLabel.Text = "GENRE";
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Location = new System.Drawing.Point(332, 197);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(40, 13);
            this.roomLabel.TabIndex = 35;
            this.roomLabel.Text = "ROOM";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(332, 230);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(64, 13);
            this.durationLabel.TabIndex = 36;
            this.durationLabel.Text = "DURATION";
            // 
            // showtimeLabel
            // 
            this.showtimeLabel.AutoSize = true;
            this.showtimeLabel.Location = new System.Drawing.Point(332, 167);
            this.showtimeLabel.Name = "showtimeLabel";
            this.showtimeLabel.Size = new System.Drawing.Size(67, 13);
            this.showtimeLabel.TabIndex = 37;
            this.showtimeLabel.Text = "SHOWTIME";
            // 
            // showtimeInfoLabel
            // 
            this.showtimeInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showtimeInfoLabel.Location = new System.Drawing.Point(445, 167);
            this.showtimeInfoLabel.Name = "showtimeInfoLabel";
            this.showtimeInfoLabel.Size = new System.Drawing.Size(138, 19);
            this.showtimeInfoLabel.TabIndex = 41;
            // 
            // durationInfoLabel
            // 
            this.durationInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.durationInfoLabel.Location = new System.Drawing.Point(445, 230);
            this.durationInfoLabel.Name = "durationInfoLabel";
            this.durationInfoLabel.Size = new System.Drawing.Size(138, 19);
            this.durationInfoLabel.TabIndex = 40;
            // 
            // roomInfoLabel
            // 
            this.roomInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomInfoLabel.Location = new System.Drawing.Point(445, 197);
            this.roomInfoLabel.Name = "roomInfoLabel";
            this.roomInfoLabel.Size = new System.Drawing.Size(138, 19);
            this.roomInfoLabel.TabIndex = 39;
            // 
            // genreInfoLabel
            // 
            this.genreInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.genreInfoLabel.Location = new System.Drawing.Point(445, 134);
            this.genreInfoLabel.Name = "genreInfoLabel";
            this.genreInfoLabel.Size = new System.Drawing.Size(138, 19);
            this.genreInfoLabel.TabIndex = 38;
            // 
            // Screen9Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showtimeInfoLabel);
            this.Controls.Add(this.durationInfoLabel);
            this.Controls.Add(this.roomInfoLabel);
            this.Controls.Add(this.genreInfoLabel);
            this.Controls.Add(this.showtimeLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.movieTitleLabel);
            this.Controls.Add(this.mainMenuButton);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.idNumberLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userIdLabel);
            this.Name = "Screen9Form";
            this.Text = "Buy a Ticket ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button mainMenuButton;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label idNumberLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Label movieTitleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label showtimeLabel;
        private System.Windows.Forms.Label showtimeInfoLabel;
        private System.Windows.Forms.Label durationInfoLabel;
        private System.Windows.Forms.Label roomInfoLabel;
        private System.Windows.Forms.Label genreInfoLabel;
    }
}