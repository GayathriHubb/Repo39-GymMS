namespace GymMS
{
    partial class FormGymStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGymStaff));
            this.PicBxGymPer = new System.Windows.Forms.PictureBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.DTPJoinDate = new System.Windows.Forms.DateTimePicker();
            this.DTPDOB = new System.Windows.Forms.DateTimePicker();
            this.MTBPhnNum = new System.Windows.Forms.MaskedTextBox();
            this.CmbBxGender = new System.Windows.Forms.ComboBox();
            this.TxtBxAddrss = new System.Windows.Forms.TextBox();
            this.TxtBxEmail = new System.Windows.Forms.TextBox();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbHeading = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbStaffId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGymPer)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBxGymPer
            // 
            this.PicBxGymPer.BackColor = System.Drawing.Color.Transparent;
            this.PicBxGymPer.Image = global::GymMS.Properties.Resources.person;
            this.PicBxGymPer.Location = new System.Drawing.Point(329, 15);
            this.PicBxGymPer.Name = "PicBxGymPer";
            this.PicBxGymPer.Size = new System.Drawing.Size(60, 60);
            this.PicBxGymPer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxGymPer.TabIndex = 43;
            this.PicBxGymPer.TabStop = false;
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.Bisque;
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Texturina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnReset.Location = new System.Drawing.Point(510, 535);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(160, 50);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.Bisque;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Texturina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSave.Location = new System.Drawing.Point(274, 535);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(160, 50);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // DTPJoinDate
            // 
            this.DTPJoinDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPJoinDate.Location = new System.Drawing.Point(593, 190);
            this.DTPJoinDate.Name = "DTPJoinDate";
            this.DTPJoinDate.Size = new System.Drawing.Size(220, 34);
            this.DTPJoinDate.TabIndex = 8;
            // 
            // DTPDOB
            // 
            this.DTPDOB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDOB.Location = new System.Drawing.Point(160, 318);
            this.DTPDOB.Name = "DTPDOB";
            this.DTPDOB.Size = new System.Drawing.Size(220, 34);
            this.DTPDOB.TabIndex = 5;
            // 
            // MTBPhnNum
            // 
            this.MTBPhnNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MTBPhnNum.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTBPhnNum.Location = new System.Drawing.Point(160, 381);
            this.MTBPhnNum.Mask = "0000000000";
            this.MTBPhnNum.Name = "MTBPhnNum";
            this.MTBPhnNum.Size = new System.Drawing.Size(200, 37);
            this.MTBPhnNum.TabIndex = 6;
            // 
            // CmbBxGender
            // 
            this.CmbBxGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBxGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxGender.FormattingEnabled = true;
            this.CmbBxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.CmbBxGender.Location = new System.Drawing.Point(160, 249);
            this.CmbBxGender.Name = "CmbBxGender";
            this.CmbBxGender.Size = new System.Drawing.Size(200, 33);
            this.CmbBxGender.TabIndex = 4;
            // 
            // TxtBxAddrss
            // 
            this.TxtBxAddrss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxAddrss.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxAddrss.Location = new System.Drawing.Point(591, 245);
            this.TxtBxAddrss.Multiline = true;
            this.TxtBxAddrss.Name = "TxtBxAddrss";
            this.TxtBxAddrss.Size = new System.Drawing.Size(300, 140);
            this.TxtBxAddrss.TabIndex = 9;
            // 
            // TxtBxEmail
            // 
            this.TxtBxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxEmail.Location = new System.Drawing.Point(160, 448);
            this.TxtBxEmail.Name = "TxtBxEmail";
            this.TxtBxEmail.Size = new System.Drawing.Size(300, 37);
            this.TxtBxEmail.TabIndex = 7;
            // 
            // TxtBxName
            // 
            this.TxtBxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxName.Location = new System.Drawing.Point(160, 183);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(300, 37);
            this.TxtBxName.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(476, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 38;
            this.label8.Text = "Address";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(476, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "Join Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 32;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "PhnNum";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 27;
            this.label3.Text = "Gender";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Date Of Birth";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbHeading.Font = new System.Drawing.Font("Playball", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.DarkRed;
            this.LbHeading.Location = new System.Drawing.Point(395, 20);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(204, 50);
            this.LbHeading.TabIndex = 24;
            this.LbHeading.Text = "Star Fitness";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.BackColor = System.Drawing.Color.Transparent;
            this.LbName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.Location = new System.Drawing.Point(38, 190);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(97, 22);
            this.LbName.TabIndex = 22;
            this.LbName.Text = "Full Name";
            this.LbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(409, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 44;
            this.label1.Text = "Staff Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbStaffId
            // 
            this.LbStaffId.AutoSize = true;
            this.LbStaffId.BackColor = System.Drawing.Color.Transparent;
            this.LbStaffId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbStaffId.Location = new System.Drawing.Point(154, 128);
            this.LbStaffId.Name = "LbStaffId";
            this.LbStaffId.Size = new System.Drawing.Size(43, 32);
            this.LbStaffId.TabIndex = 49;
            this.LbStaffId.Text = "{?}";
            this.LbStaffId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 22);
            this.label10.TabIndex = 48;
            this.label10.Text = "MembId";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormGymStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 644);
            this.Controls.Add(this.LbStaffId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicBxGymPer);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.DTPJoinDate);
            this.Controls.Add(this.DTPDOB);
            this.Controls.Add(this.MTBPhnNum);
            this.Controls.Add(this.CmbBxGender);
            this.Controls.Add(this.TxtBxAddrss);
            this.Controls.Add(this.TxtBxEmail);
            this.Controls.Add(this.TxtBxName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.LbName);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormGymStaff";
            this.Text = "Gym Management";
            this.Load += new System.EventHandler(this.FormGymStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGymPer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBxGymPer;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DateTimePicker DTPJoinDate;
        private System.Windows.Forms.DateTimePicker DTPDOB;
        private System.Windows.Forms.MaskedTextBox MTBPhnNum;
        private System.Windows.Forms.ComboBox CmbBxGender;
        private System.Windows.Forms.TextBox TxtBxAddrss;
        private System.Windows.Forms.TextBox TxtBxEmail;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbStaffId;
        private System.Windows.Forms.Label label10;
    }
}