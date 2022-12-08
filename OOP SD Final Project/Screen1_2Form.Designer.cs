using System.Windows.Forms;

namespace OOP_Design_Project
{
    partial class Screen1_2Form
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
            this.newIDLlabel = new System.Windows.Forms.Label();
            this.iDNumberLabel = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newIDLlabel
            // 
            this.newIDLlabel.AutoSize = true;
            this.newIDLlabel.Location = new System.Drawing.Point(287, 140);
            this.newIDLlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newIDLlabel.Name = "newIDLlabel";
            this.newIDLlabel.Size = new System.Drawing.Size(68, 16);
            this.newIDLlabel.TabIndex = 0;
            this.newIDLlabel.Text = "Your Id is: ";
            // 
            // iDNumberLabel
            // 
            this.iDNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iDNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDNumberLabel.Location = new System.Drawing.Point(377, 129);
            this.iDNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iDNumberLabel.Name = "iDNumberLabel";
            this.iDNumberLabel.Size = new System.Drawing.Size(155, 41);
            this.iDNumberLabel.TabIndex = 1;
            this.iDNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(243, 304);
            this.logInButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(164, 64);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "Log In ";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(484, 304);
            this.goBackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(164, 64);
            this.goBackButton.TabIndex = 3;
            this.goBackButton.Text = "Go back to main menu";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // Screen1_2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 480);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.iDNumberLabel);
            this.Controls.Add(this.newIDLlabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Screen1_2Form";
            this.Text = "Log in information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label newIDLlabel;
        private Label iDNumberLabel;
        private Button logInButton;
        private Button goBackButton;
    }
}