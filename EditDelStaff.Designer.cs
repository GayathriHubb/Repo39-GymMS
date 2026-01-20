namespace GymMS
{
    partial class FormEditDelStaff
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditDelStaff));
            this.PicBxGymPer = new System.Windows.Forms.PictureBox();
            this.LbHeading = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
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
            this.LbName = new System.Windows.Forms.Label();
            this.PicBxSearch = new System.Windows.Forms.PictureBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.CmbBxWorkStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.NUDStaffId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGymPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDStaffId)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBxGymPer
            // 
            this.PicBxGymPer.BackColor = System.Drawing.Color.Transparent;
            this.PicBxGymPer.Image = global::GymMS.Properties.Resources.person;
            this.PicBxGymPer.Location = new System.Drawing.Point(318, 12);
            this.PicBxGymPer.Name = "PicBxGymPer";
            this.PicBxGymPer.Size = new System.Drawing.Size(60, 60);
            this.PicBxGymPer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxGymPer.TabIndex = 45;
            this.PicBxGymPer.TabStop = false;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbHeading.Font = new System.Drawing.Font("Playball", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.DarkRed;
            this.LbHeading.Location = new System.Drawing.Point(384, 17);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(204, 50);
            this.LbHeading.TabIndex = 44;
            this.LbHeading.Text = "Star Fitness";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Font = new System.Drawing.Font("Texturina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(335, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(259, 37);
            this.label11.TabIndex = 75;
            this.label11.Text = "Edit | Delete Staff Info";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 22);
            this.label10.TabIndex = 92;
            this.label10.Text = "StaffId";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnReset
            // 
            this.BtnReset.AutoSize = true;
            this.BtnReset.BackColor = System.Drawing.Color.Bisque;
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Texturina", 11F, System.Drawing.FontStyle.Bold);
            this.BtnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnReset.Location = new System.Drawing.Point(570, 552);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(160, 47);
            this.BtnReset.TabIndex = 77;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.AutoSize = true;
            this.BtnEdit.BackColor = System.Drawing.Color.Bisque;
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Texturina", 11F, System.Drawing.FontStyle.Bold);
            this.BtnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnEdit.Location = new System.Drawing.Point(195, 552);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(160, 47);
            this.BtnEdit.TabIndex = 76;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // DTPJoinDate
            // 
            this.DTPJoinDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPJoinDate.Location = new System.Drawing.Point(583, 146);
            this.DTPJoinDate.Name = "DTPJoinDate";
            this.DTPJoinDate.Size = new System.Drawing.Size(220, 34);
            this.DTPJoinDate.TabIndex = 83;
            // 
            // DTPDOB
            // 
            this.DTPDOB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDOB.Location = new System.Drawing.Point(146, 346);
            this.DTPDOB.Name = "DTPDOB";
            this.DTPDOB.Size = new System.Drawing.Size(220, 34);
            this.DTPDOB.TabIndex = 80;
            // 
            // MTBPhnNum
            // 
            this.MTBPhnNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MTBPhnNum.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTBPhnNum.Location = new System.Drawing.Point(146, 409);
            this.MTBPhnNum.Mask = "0000000000";
            this.MTBPhnNum.Name = "MTBPhnNum";
            this.MTBPhnNum.Size = new System.Drawing.Size(200, 37);
            this.MTBPhnNum.TabIndex = 81;
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
            this.CmbBxGender.Location = new System.Drawing.Point(146, 277);
            this.CmbBxGender.Name = "CmbBxGender";
            this.CmbBxGender.Size = new System.Drawing.Size(200, 33);
            this.CmbBxGender.TabIndex = 79;
            // 
            // TxtBxAddrss
            // 
            this.TxtBxAddrss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxAddrss.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxAddrss.Location = new System.Drawing.Point(581, 201);
            this.TxtBxAddrss.Multiline = true;
            this.TxtBxAddrss.Name = "TxtBxAddrss";
            this.TxtBxAddrss.Size = new System.Drawing.Size(300, 140);
            this.TxtBxAddrss.TabIndex = 84;
            // 
            // TxtBxEmail
            // 
            this.TxtBxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxEmail.Location = new System.Drawing.Point(146, 476);
            this.TxtBxEmail.Name = "TxtBxEmail";
            this.TxtBxEmail.Size = new System.Drawing.Size(300, 37);
            this.TxtBxEmail.TabIndex = 82;
            // 
            // TxtBxName
            // 
            this.TxtBxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxName.Location = new System.Drawing.Point(146, 211);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(300, 37);
            this.TxtBxName.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(477, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 22);
            this.label8.TabIndex = 91;
            this.label8.Text = "Address";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(477, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 90;
            this.label6.Text = "Join Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 89;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 88;
            this.label4.Text = "PhnNum";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 87;
            this.label3.Text = "Gender";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 86;
            this.label2.Text = "Date Of Birth";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.BackColor = System.Drawing.Color.Transparent;
            this.LbName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.Location = new System.Drawing.Point(24, 218);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(97, 22);
            this.LbName.TabIndex = 85;
            this.LbName.Text = "Full Name";
            this.LbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PicBxSearch
            // 
            this.PicBxSearch.BackColor = System.Drawing.Color.Bisque;
            this.PicBxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBxSearch.Image = ((System.Drawing.Image)(resources.GetObject("PicBxSearch.Image")));
            this.PicBxSearch.Location = new System.Drawing.Point(352, 151);
            this.PicBxSearch.Name = "PicBxSearch";
            this.PicBxSearch.Size = new System.Drawing.Size(40, 40);
            this.PicBxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxSearch.TabIndex = 94;
            this.PicBxSearch.TabStop = false;
            this.ToolTip1.SetToolTip(this.PicBxSearch, "Search");
            this.PicBxSearch.Click += new System.EventHandler(this.PicBxSearch_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.AutoSize = true;
            this.BtnDelete.BackColor = System.Drawing.Color.Bisque;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Texturina", 11F, System.Drawing.FontStyle.Bold);
            this.BtnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDelete.Location = new System.Drawing.Point(386, 552);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(160, 47);
            this.BtnDelete.TabIndex = 95;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // CmbBxWorkStatus
            // 
            this.CmbBxWorkStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBxWorkStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxWorkStatus.FormattingEnabled = true;
            this.CmbBxWorkStatus.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CmbBxWorkStatus.Location = new System.Drawing.Point(620, 370);
            this.CmbBxWorkStatus.Name = "CmbBxWorkStatus";
            this.CmbBxWorkStatus.Size = new System.Drawing.Size(150, 33);
            this.CmbBxWorkStatus.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 96;
            this.label1.Text = "Working Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NUDStaffId
            // 
            this.NUDStaffId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUDStaffId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDStaffId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.NUDStaffId.Location = new System.Drawing.Point(146, 152);
            this.NUDStaffId.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDStaffId.Name = "NUDStaffId";
            this.NUDStaffId.Size = new System.Drawing.Size(180, 39);
            this.NUDStaffId.TabIndex = 1;
            // 
            // FormEditDelStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 644);
            this.Controls.Add(this.NUDStaffId);
            this.Controls.Add(this.CmbBxWorkStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.PicBxSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnEdit);
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
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PicBxGymPer);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEditDelStaff";
            this.Text = "Gym Management";
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGymPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDStaffId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBxGymPer;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnEdit;
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
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.PictureBox PicBxSearch;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.ComboBox CmbBxWorkStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUDStaffId;
    }
}