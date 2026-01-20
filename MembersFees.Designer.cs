namespace GymMS
{
    partial class FormMembsFees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMembsFees));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.LbHeading = new System.Windows.Forms.Label();
            this.PicBxGymPer = new System.Windows.Forms.PictureBox();
            this.NUDMembId = new System.Windows.Forms.NumericUpDown();
            this.PicBxSearch = new System.Windows.Forms.PictureBox();
            this.LbMembId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbBxGender = new System.Windows.Forms.ComboBox();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.CmbBxMembStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MTBPhnNum = new System.Windows.Forms.MaskedTextBox();
            this.CmbBxGymTime = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NUDAmount = new System.Windows.Forms.NumericUpDown();
            this.DTPFeesMonth = new System.Windows.Forms.DateTimePicker();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnFees = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DGVFees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGymPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMembId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Texturina", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(382, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 35);
            this.label1.TabIndex = 48;
            this.label1.Text = "Members Fees";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbHeading.Font = new System.Drawing.Font("Playball", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.DarkRed;
            this.LbHeading.Location = new System.Drawing.Point(403, 10);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(204, 50);
            this.LbHeading.TabIndex = 46;
            this.LbHeading.Text = "Star Fitness";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicBxGymPer
            // 
            this.PicBxGymPer.BackColor = System.Drawing.Color.Transparent;
            this.PicBxGymPer.Image = global::GymMS.Properties.Resources.person;
            this.PicBxGymPer.Location = new System.Drawing.Point(337, 5);
            this.PicBxGymPer.Name = "PicBxGymPer";
            this.PicBxGymPer.Size = new System.Drawing.Size(60, 60);
            this.PicBxGymPer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxGymPer.TabIndex = 47;
            this.PicBxGymPer.TabStop = false;
            // 
            // NUDMembId
            // 
            this.NUDMembId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUDMembId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDMembId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.NUDMembId.Location = new System.Drawing.Point(157, 135);
            this.NUDMembId.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDMembId.Name = "NUDMembId";
            this.NUDMembId.Size = new System.Drawing.Size(180, 39);
            this.NUDMembId.TabIndex = 1;
            // 
            // PicBxSearch
            // 
            this.PicBxSearch.BackColor = System.Drawing.Color.Bisque;
            this.PicBxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBxSearch.Image = ((System.Drawing.Image)(resources.GetObject("PicBxSearch.Image")));
            this.PicBxSearch.Location = new System.Drawing.Point(356, 134);
            this.PicBxSearch.Name = "PicBxSearch";
            this.PicBxSearch.Size = new System.Drawing.Size(40, 40);
            this.PicBxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxSearch.TabIndex = 83;
            this.PicBxSearch.TabStop = false;
            this.ToolTip1.SetToolTip(this.PicBxSearch, "Search");
            this.PicBxSearch.Click += new System.EventHandler(this.PicBxSearch_Click);
            // 
            // LbMembId
            // 
            this.LbMembId.AutoSize = true;
            this.LbMembId.BackColor = System.Drawing.Color.Transparent;
            this.LbMembId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMembId.Location = new System.Drawing.Point(151, 138);
            this.LbMembId.Name = "LbMembId";
            this.LbMembId.Size = new System.Drawing.Size(0, 32);
            this.LbMembId.TabIndex = 82;
            this.LbMembId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Bisque;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 22);
            this.label10.TabIndex = 81;
            this.label10.Text = "MembId";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbBxGender
            // 
            this.CmbBxGender.Enabled = false;
            this.CmbBxGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBxGender.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxGender.FormattingEnabled = true;
            this.CmbBxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.CmbBxGender.Location = new System.Drawing.Point(157, 253);
            this.CmbBxGender.Name = "CmbBxGender";
            this.CmbBxGender.Size = new System.Drawing.Size(200, 33);
            this.CmbBxGender.TabIndex = 78;
            // 
            // TxtBxName
            // 
            this.TxtBxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxName.Enabled = false;
            this.TxtBxName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxName.Location = new System.Drawing.Point(157, 193);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(300, 37);
            this.TxtBxName.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Bisque;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 80;
            this.label3.Text = "Gender";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.BackColor = System.Drawing.Color.Bisque;
            this.LbName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.Location = new System.Drawing.Point(32, 200);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(97, 22);
            this.LbName.TabIndex = 79;
            this.LbName.Text = "Full Name";
            this.LbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbBxMembStatus
            // 
            this.CmbBxMembStatus.Enabled = false;
            this.CmbBxMembStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBxMembStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxMembStatus.FormattingEnabled = true;
            this.CmbBxMembStatus.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CmbBxMembStatus.Location = new System.Drawing.Point(662, 195);
            this.CmbBxMembStatus.Name = "CmbBxMembStatus";
            this.CmbBxMembStatus.Size = new System.Drawing.Size(150, 33);
            this.CmbBxMembStatus.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Bisque;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 22);
            this.label2.TabIndex = 89;
            this.label2.Text = "Membership Status";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MTBPhnNum
            // 
            this.MTBPhnNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MTBPhnNum.Enabled = false;
            this.MTBPhnNum.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTBPhnNum.Location = new System.Drawing.Point(158, 311);
            this.MTBPhnNum.Mask = "0000000000";
            this.MTBPhnNum.Name = "MTBPhnNum";
            this.MTBPhnNum.Size = new System.Drawing.Size(200, 37);
            this.MTBPhnNum.TabIndex = 87;
            // 
            // CmbBxGymTime
            // 
            this.CmbBxGymTime.Enabled = false;
            this.CmbBxGymTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBxGymTime.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxGymTime.FormattingEnabled = true;
            this.CmbBxGymTime.Items.AddRange(new object[] {
            "6:00 AM to 7:00 AM",
            "7:00 AM to 8:00 AM",
            "8:00 AM to 9:00 AM",
            "5:00 PM to 6:00 PM",
            "6:00 PM to 7:00 PM"});
            this.CmbBxGymTime.Location = new System.Drawing.Point(592, 138);
            this.CmbBxGymTime.Name = "CmbBxGymTime";
            this.CmbBxGymTime.Size = new System.Drawing.Size(250, 33);
            this.CmbBxGymTime.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Bisque;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(466, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 22);
            this.label7.TabIndex = 88;
            this.label7.Text = "Gym Time";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Bisque;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 86;
            this.label4.Text = "PhnNum";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Bisque;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(466, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 22);
            this.label5.TabIndex = 90;
            this.label5.Text = "MonthYear";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Bisque;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(466, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 22);
            this.label6.TabIndex = 91;
            this.label6.Text = "Amount";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NUDAmount
            // 
            this.NUDAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUDAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDAmount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.NUDAmount.Location = new System.Drawing.Point(587, 310);
            this.NUDAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDAmount.Name = "NUDAmount";
            this.NUDAmount.Size = new System.Drawing.Size(180, 39);
            this.NUDAmount.TabIndex = 92;
            // 
            // DTPFeesMonth
            // 
            this.DTPFeesMonth.CustomFormat = "MMMM yyyy";
            this.DTPFeesMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFeesMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPFeesMonth.Location = new System.Drawing.Point(587, 252);
            this.DTPFeesMonth.Name = "DTPFeesMonth";
            this.DTPFeesMonth.Size = new System.Drawing.Size(225, 34);
            this.DTPFeesMonth.TabIndex = 93;
            // 
            // BtnReset
            // 
            this.BtnReset.AutoSize = true;
            this.BtnReset.BackColor = System.Drawing.Color.Bisque;
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Texturina", 11F, System.Drawing.FontStyle.Bold);
            this.BtnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnReset.Location = new System.Drawing.Point(592, 367);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(160, 47);
            this.BtnReset.TabIndex = 3;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnFees
            // 
            this.BtnFees.AutoSize = true;
            this.BtnFees.BackColor = System.Drawing.Color.Bisque;
            this.BtnFees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFees.Font = new System.Drawing.Font("Texturina", 11F, System.Drawing.FontStyle.Bold);
            this.BtnFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnFees.Location = new System.Drawing.Point(191, 367);
            this.BtnFees.Name = "BtnFees";
            this.BtnFees.Size = new System.Drawing.Size(160, 47);
            this.BtnFees.TabIndex = 2;
            this.BtnFees.Text = "Fees";
            this.BtnFees.UseVisualStyleBackColor = false;
            this.BtnFees.Click += new System.EventHandler(this.BtnFees_Click);
            // 
            // DGVFees
            // 
            this.DGVFees.AllowUserToAddRows = false;
            this.DGVFees.AllowUserToDeleteRows = false;
            this.DGVFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVFees.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVFees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Texturina", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVFees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVFees.ColumnHeadersHeight = 34;
            this.DGVFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVFees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVFees.EnableHeadersVisualStyles = false;
            this.DGVFees.Location = new System.Drawing.Point(4, 432);
            this.DGVFees.Name = "DGVFees";
            this.DGVFees.ReadOnly = true;
            this.DGVFees.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVFees.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVFees.RowTemplate.Height = 28;
            this.DGVFees.Size = new System.Drawing.Size(920, 200);
            this.DGVFees.TabIndex = 6;
            // 
            // FormMembsFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(928, 644);
            this.Controls.Add(this.DGVFees);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnFees);
            this.Controls.Add(this.DTPFeesMonth);
            this.Controls.Add(this.NUDAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbBxMembStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MTBPhnNum);
            this.Controls.Add(this.CmbBxGymTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NUDMembId);
            this.Controls.Add(this.PicBxSearch);
            this.Controls.Add(this.LbMembId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CmbBxGender);
            this.Controls.Add(this.TxtBxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicBxGymPer);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMembsFees";
            this.Text = "Gym Management";
            this.Load += new System.EventHandler(this.MembersFees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGymPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMembId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicBxGymPer;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.NumericUpDown NUDMembId;
        private System.Windows.Forms.PictureBox PicBxSearch;
        private System.Windows.Forms.Label LbMembId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbBxGender;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.ComboBox CmbBxMembStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MTBPhnNum;
        private System.Windows.Forms.ComboBox CmbBxGymTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NUDAmount;
        private System.Windows.Forms.DateTimePicker DTPFeesMonth;
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnFees;
        private System.Windows.Forms.DataGridView DGVFees;
    }
}