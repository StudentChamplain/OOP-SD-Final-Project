namespace OOP_SD_Final_Project
{
    partial class Screen3_1Form
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
            this.moviesDetailsLabel = new System.Windows.Forms.Label();
            this.companyNamelabel = new System.Windows.Forms.Label();
            this.idNumberLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // moviesDetailsLabel
            // 
            this.moviesDetailsLabel.AutoSize = true;
            this.moviesDetailsLabel.Location = new System.Drawing.Point(361, 105);
            this.moviesDetailsLabel.Name = "moviesDetailsLabel";
            this.moviesDetailsLabel.Size = new System.Drawing.Size(76, 13);
            this.moviesDetailsLabel.TabIndex = 23;
            this.moviesDetailsLabel.Text = "Movies Details";
            // 
            // companyNamelabel
            // 
            this.companyNamelabel.AutoSize = true;
            this.companyNamelabel.Location = new System.Drawing.Point(87, 62);
            this.companyNamelabel.Name = "companyNamelabel";
            this.companyNamelabel.Size = new System.Drawing.Size(113, 13);
            this.companyNamelabel.TabIndex = 22;
            this.companyNamelabel.Text = "The Theater Company";
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idNumberLabel.Location = new System.Drawing.Point(617, 30);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(94, 33);
            this.idNumberLabel.TabIndex = 21;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(601, 74);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(71, 13);
            this.userNameLabel.TabIndex = 20;
            this.userNameLabel.Text = "USER NAME";
            // 
            // userIdLabel
            // 
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Location = new System.Drawing.Point(570, 41);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(47, 13);
            this.userIdLabel.TabIndex = 19;
            this.userIdLabel.Text = "User Id: ";
            // 
            // Screen3_1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moviesDetailsLabel);
            this.Controls.Add(this.companyNamelabel);
            this.Controls.Add(this.idNumberLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userIdLabel);
            this.Name = "Screen3_1Form";
            this.Text = "Screen3_1Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moviesDetailsLabel;
        private System.Windows.Forms.Label companyNamelabel;
        private System.Windows.Forms.Label idNumberLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userIdLabel;
    }
}