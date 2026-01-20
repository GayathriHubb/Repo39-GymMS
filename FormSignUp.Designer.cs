namespace GymMS
{
    partial class FormSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.LbNoAcc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.ChkBxPswrd = new System.Windows.Forms.CheckBox();
            this.TxtBxPassword = new System.Windows.Forms.TextBox();
            this.TxtBxUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.PicBxGymPer = new System.Windows.Forms.PictureBox();
            this.LbHeading = new System.Windows.Forms.Label();
            this.TxtBxCnfmPswrd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGymPer)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.BackColor = System.Drawing.Color.Bisque;
            this.BtnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSignIn.Font = new System.Drawing.Font("Texturina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSignIn.Location = new System.Drawing.Point(305, 555);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(280, 50);
            this.BtnSignIn.TabIndex = 7;
            this.BtnSignIn.Text = "SignIn";
            this.BtnSignIn.UseVisualStyleBackColor = false;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // LbNoAcc
            // 
            this.LbNoAcc.AutoSize = true;
            this.LbNoAcc.BackColor = System.Drawing.Color.Transparent;
            this.LbNoAcc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNoAcc.ForeColor = System.Drawing.Color.LightGray;
            this.LbNoAcc.Location = new System.Drawing.Point(342, 520);
            this.LbNoAcc.Name = "LbNoAcc";
            this.LbNoAcc.Size = new System.Drawing.Size(206, 23);
            this.LbNoAcc.TabIndex = 44;
            this.LbNoAcc.Text = "Already have Acc ?";
            this.LbNoAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(347, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 28);
            this.label1.TabIndex = 43;
            this.label1.Text = "SIGNUP FORM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.Bisque;
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Texturina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnReset.Location = new System.Drawing.Point(477, 425);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(160, 50);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "Clear";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.BackColor = System.Drawing.Color.Bisque;
            this.BtnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignUp.Font = new System.Drawing.Font("Texturina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSignUp.Location = new System.Drawing.Point(241, 425);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(160, 50);
            this.BtnSignUp.TabIndex = 1;
            this.BtnSignUp.Text = "SignUp";
            this.BtnSignUp.UseVisualStyleBackColor = false;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // ChkBxPswrd
            // 
            this.ChkBxPswrd.AutoSize = true;
            this.ChkBxPswrd.BackColor = System.Drawing.Color.Transparent;
            this.ChkBxPswrd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBxPswrd.ForeColor = System.Drawing.Color.Bisque;
            this.ChkBxPswrd.Location = new System.Drawing.Point(483, 355);
            this.ChkBxPswrd.Name = "ChkBxPswrd";
            this.ChkBxPswrd.Size = new System.Drawing.Size(169, 26);
            this.ChkBxPswrd.TabIndex = 6;
            this.ChkBxPswrd.Text = "Show Password";
            this.ChkBxPswrd.UseVisualStyleBackColor = false;
            this.ChkBxPswrd.CheckedChanged += new System.EventHandler(this.ChkBxPswrd_CheckedChanged);
            // 
            // TxtBxPassword
            // 
            this.TxtBxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPassword.Location = new System.Drawing.Point(352, 254);
            this.TxtBxPassword.Name = "TxtBxPassword";
            this.TxtBxPassword.Size = new System.Drawing.Size(300, 37);
            this.TxtBxPassword.TabIndex = 4;
            this.TxtBxPassword.UseSystemPasswordChar = true;
            // 
            // TxtBxUsername
            // 
            this.TxtBxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxUsername.Location = new System.Drawing.Point(352, 210);
            this.TxtBxUsername.Name = "TxtBxUsername";
            this.TxtBxUsername.Size = new System.Drawing.Size(300, 37);
            this.TxtBxUsername.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Bisque;
            this.label5.Location = new System.Drawing.Point(227, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 26);
            this.label5.TabIndex = 38;
            this.label5.Text = "Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.BackColor = System.Drawing.Color.Transparent;
            this.LbName.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.ForeColor = System.Drawing.Color.Bisque;
            this.LbName.Location = new System.Drawing.Point(217, 215);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(123, 26);
            this.LbName.TabIndex = 36;
            this.LbName.Text = "UserName";
            this.LbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PicBxGymPer
            // 
            this.PicBxGymPer.BackColor = System.Drawing.Color.LightGray;
            this.PicBxGymPer.Image = global::GymMS.Properties.Resources.person;
            this.PicBxGymPer.Location = new System.Drawing.Point(411, 10);
            this.PicBxGymPer.Name = "PicBxGymPer";
            this.PicBxGymPer.Size = new System.Drawing.Size(60, 60);
            this.PicBxGymPer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxGymPer.TabIndex = 35;
            this.PicBxGymPer.TabStop = false;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbHeading.Font = new System.Drawing.Font("Playball", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.Yellow;
            this.LbHeading.Location = new System.Drawing.Point(337, 80);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(204, 50);
            this.LbHeading.TabIndex = 34;
            this.LbHeading.Text = "Star Fitness";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBxCnfmPswrd
            // 
            this.TxtBxCnfmPswrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxCnfmPswrd.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxCnfmPswrd.Location = new System.Drawing.Point(352, 298);
            this.TxtBxCnfmPswrd.Name = "TxtBxCnfmPswrd";
            this.TxtBxCnfmPswrd.Size = new System.Drawing.Size(300, 37);
            this.TxtBxCnfmPswrd.TabIndex = 5;
            this.TxtBxCnfmPswrd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(138, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 26);
            this.label2.TabIndex = 46;
            this.label2.Text = "Confirm Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.TxtBxCnfmPswrd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSignIn);
            this.Controls.Add(this.LbNoAcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.ChkBxPswrd);
            this.Controls.Add(this.TxtBxPassword);
            this.Controls.Add(this.TxtBxUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.PicBxGymPer);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSignUp";
            this.Text = "Gym Management";
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGymPer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Label LbNoAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.CheckBox ChkBxPswrd;
        private System.Windows.Forms.TextBox TxtBxPassword;
        private System.Windows.Forms.TextBox TxtBxUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.PictureBox PicBxGymPer;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.TextBox TxtBxCnfmPswrd;
        private System.Windows.Forms.Label label2;
    }
}