namespace GymMS
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.PicBxGymPer = new System.Windows.Forms.PictureBox();
            this.LbHeading = new System.Windows.Forms.Label();
            this.TxtBxPassword = new System.Windows.Forms.TextBox();
            this.TxtBxUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.ChkBxPswrd = new System.Windows.Forms.CheckBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LbNoAcc = new System.Windows.Forms.Label();
            this.BtnSignUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGymPer)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBxGymPer
            // 
            this.PicBxGymPer.BackColor = System.Drawing.Color.LightGray;
            this.PicBxGymPer.Image = global::GymMS.Properties.Resources.person;
            this.PicBxGymPer.Location = new System.Drawing.Point(411, 12);
            this.PicBxGymPer.Name = "PicBxGymPer";
            this.PicBxGymPer.Size = new System.Drawing.Size(60, 60);
            this.PicBxGymPer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxGymPer.TabIndex = 23;
            this.PicBxGymPer.TabStop = false;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbHeading.Font = new System.Drawing.Font("Playball", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.Yellow;
            this.LbHeading.Location = new System.Drawing.Point(337, 82);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(204, 50);
            this.LbHeading.TabIndex = 22;
            this.LbHeading.Text = "Star Fitness";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBxPassword
            // 
            this.TxtBxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxPassword.Location = new System.Drawing.Point(352, 280);
            this.TxtBxPassword.Name = "TxtBxPassword";
            this.TxtBxPassword.Size = new System.Drawing.Size(300, 37);
            this.TxtBxPassword.TabIndex = 5;
            this.TxtBxPassword.UseSystemPasswordChar = true;
            // 
            // TxtBxUsername
            // 
            this.TxtBxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxUsername.Location = new System.Drawing.Point(352, 221);
            this.TxtBxUsername.Name = "TxtBxUsername";
            this.TxtBxUsername.Size = new System.Drawing.Size(300, 37);
            this.TxtBxUsername.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Bisque;
            this.label5.Location = new System.Drawing.Point(219, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.BackColor = System.Drawing.Color.Transparent;
            this.LbName.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.ForeColor = System.Drawing.Color.Bisque;
            this.LbName.Location = new System.Drawing.Point(217, 226);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(123, 26);
            this.LbName.TabIndex = 24;
            this.LbName.Text = "UserName";
            this.LbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChkBxPswrd
            // 
            this.ChkBxPswrd.AutoSize = true;
            this.ChkBxPswrd.BackColor = System.Drawing.Color.Transparent;
            this.ChkBxPswrd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBxPswrd.ForeColor = System.Drawing.Color.Bisque;
            this.ChkBxPswrd.Location = new System.Drawing.Point(483, 330);
            this.ChkBxPswrd.Name = "ChkBxPswrd";
            this.ChkBxPswrd.Size = new System.Drawing.Size(169, 26);
            this.ChkBxPswrd.TabIndex = 28;
            this.ChkBxPswrd.Text = "Show Password";
            this.ChkBxPswrd.UseVisualStyleBackColor = false;
            this.ChkBxPswrd.CheckedChanged += new System.EventHandler(this.ChkBxPswrd_CheckedChanged);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.Bisque;
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Texturina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnReset.Location = new System.Drawing.Point(477, 420);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(160, 50);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "Clear";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.BackColor = System.Drawing.Color.Bisque;
            this.BtnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignIn.Font = new System.Drawing.Font("Texturina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSignIn.Location = new System.Drawing.Point(241, 420);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(160, 50);
            this.BtnSignIn.TabIndex = 1;
            this.BtnSignIn.Text = "SignIn";
            this.BtnSignIn.UseVisualStyleBackColor = false;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(355, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "SIGNIN FORM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbNoAcc
            // 
            this.LbNoAcc.AutoSize = true;
            this.LbNoAcc.BackColor = System.Drawing.Color.Transparent;
            this.LbNoAcc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNoAcc.ForeColor = System.Drawing.Color.LightGray;
            this.LbNoAcc.Location = new System.Drawing.Point(380, 510);
            this.LbNoAcc.Name = "LbNoAcc";
            this.LbNoAcc.Size = new System.Drawing.Size(120, 28);
            this.LbNoAcc.TabIndex = 32;
            this.LbNoAcc.Text = "No Acc ?";
            this.LbNoAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.BackColor = System.Drawing.Color.Bisque;
            this.BtnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSignUp.Font = new System.Drawing.Font("Texturina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSignUp.Location = new System.Drawing.Point(360, 545);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(160, 50);
            this.BtnSignUp.TabIndex = 3;
            this.BtnSignUp.Text = "SignUp";
            this.BtnSignUp.UseVisualStyleBackColor = false;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 644);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.LbNoAcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSignIn);
            this.Controls.Add(this.ChkBxPswrd);
            this.Controls.Add(this.TxtBxPassword);
            this.Controls.Add(this.TxtBxUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.PicBxGymPer);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Text = "Gym Management";
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGymPer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBxGymPer;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.TextBox TxtBxPassword;
        private System.Windows.Forms.TextBox TxtBxUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.CheckBox ChkBxPswrd;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbNoAcc;
        private System.Windows.Forms.Button BtnSignUp;
    }
}