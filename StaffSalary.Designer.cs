namespace GymMS
{
    partial class FormStaffSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStaffSalary));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.PicBxGymPer = new System.Windows.Forms.PictureBox();
            this.LbHeading = new System.Windows.Forms.Label();
            this.NUDStaffId = new System.Windows.Forms.NumericUpDown();
            this.PicBxSearch = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbBxGender = new System.Windows.Forms.ComboBox();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.CmbBxWorkStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPJoinDate = new System.Windows.Forms.DateTimePicker();
            this.MTBPhnNum = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DTPSalaryMonth = new System.Windows.Forms.DateTimePicker();
            this.NUDAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DGVSalary = new System.Windows.Forms.DataGridView();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSalary = new System.Windows.Forms.Button();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGymPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDStaffId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Font = new System.Drawing.Font("Texturina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(391, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 37);
            this.label11.TabIndex = 78;
            this.label11.Text = "Staff Salary";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PicBxGymPer
            // 
            this.PicBxGymPer.BackColor = System.Drawing.Color.Transparent;
            this.PicBxGymPer.Image = global::GymMS.Properties.Resources.person;
            this.PicBxGymPer.Location = new System.Drawing.Point(317, 15);
            this.PicBxGymPer.Name = "PicBxGymPer";
            this.PicBxGymPer.Size = new System.Drawing.Size(60, 60);
            this.PicBxGymPer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxGymPer.TabIndex = 77;
            this.PicBxGymPer.TabStop = false;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbHeading.Font = new System.Drawing.Font("Playball", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.DarkRed;
            this.LbHeading.Location = new System.Drawing.Point(383, 20);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(204, 50);
            this.LbHeading.TabIndex = 76;
            this.LbHeading.Text = "Star Fitness";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NUDStaffId
            // 
            this.NUDStaffId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUDStaffId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDStaffId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.NUDStaffId.Location = new System.Drawing.Point(136, 140);
            this.NUDStaffId.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDStaffId.Name = "NUDStaffId";
            this.NUDStaffId.Size = new System.Drawing.Size(180, 39);
            this.NUDStaffId.TabIndex = 1;
            // 
            // PicBxSearch
            // 
            this.PicBxSearch.BackColor = System.Drawing.Color.Bisque;
            this.PicBxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicBxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicBxSearch.Image = ((System.Drawing.Image)(resources.GetObject("PicBxSearch.Image")));
            this.PicBxSearch.Location = new System.Drawing.Point(350, 139);
            this.PicBxSearch.Name = "PicBxSearch";
            this.PicBxSearch.Size = new System.Drawing.Size(40, 40);
            this.PicBxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxSearch.TabIndex = 101;
            this.PicBxSearch.TabStop = false;
            this.ToolTip1.SetToolTip(this.PicBxSearch, "Search");
            this.PicBxSearch.Click += new System.EventHandler(this.PicBxSearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Bisque;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 22);
            this.label10.TabIndex = 100;
            this.label10.Text = "StaffId";
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
            this.CmbBxGender.Location = new System.Drawing.Point(136, 245);
            this.CmbBxGender.Name = "CmbBxGender";
            this.CmbBxGender.Size = new System.Drawing.Size(200, 33);
            this.CmbBxGender.TabIndex = 97;
            // 
            // TxtBxName
            // 
            this.TxtBxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxName.Enabled = false;
            this.TxtBxName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxName.Location = new System.Drawing.Point(136, 193);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.Size = new System.Drawing.Size(300, 37);
            this.TxtBxName.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Bisque;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 99;
            this.label3.Text = "Gender";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.BackColor = System.Drawing.Color.Bisque;
            this.LbName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.Location = new System.Drawing.Point(26, 204);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(97, 22);
            this.LbName.TabIndex = 98;
            this.LbName.Text = "Full Name";
            this.LbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbBxWorkStatus
            // 
            this.CmbBxWorkStatus.Enabled = false;
            this.CmbBxWorkStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBxWorkStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxWorkStatus.FormattingEnabled = true;
            this.CmbBxWorkStatus.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CmbBxWorkStatus.Location = new System.Drawing.Point(632, 192);
            this.CmbBxWorkStatus.Name = "CmbBxWorkStatus";
            this.CmbBxWorkStatus.Size = new System.Drawing.Size(150, 33);
            this.CmbBxWorkStatus.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 106;
            this.label1.Text = "Working Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DTPJoinDate
            // 
            this.DTPJoinDate.Enabled = false;
            this.DTPJoinDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPJoinDate.Location = new System.Drawing.Point(595, 142);
            this.DTPJoinDate.Name = "DTPJoinDate";
            this.DTPJoinDate.Size = new System.Drawing.Size(220, 34);
            this.DTPJoinDate.TabIndex = 103;
            // 
            // MTBPhnNum
            // 
            this.MTBPhnNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MTBPhnNum.Enabled = false;
            this.MTBPhnNum.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTBPhnNum.Location = new System.Drawing.Point(136, 303);
            this.MTBPhnNum.Mask = "0000000000";
            this.MTBPhnNum.Name = "MTBPhnNum";
            this.MTBPhnNum.Size = new System.Drawing.Size(200, 37);
            this.MTBPhnNum.TabIndex = 102;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Bisque;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(481, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 105;
            this.label6.Text = "Join Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Bisque;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 104;
            this.label4.Text = "PhnNum";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DTPSalaryMonth
            // 
            this.DTPSalaryMonth.CustomFormat = "MMMM yyyy";
            this.DTPSalaryMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPSalaryMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPSalaryMonth.Location = new System.Drawing.Point(612, 244);
            this.DTPSalaryMonth.Name = "DTPSalaryMonth";
            this.DTPSalaryMonth.Size = new System.Drawing.Size(225, 34);
            this.DTPSalaryMonth.TabIndex = 111;
            // 
            // NUDAmount
            // 
            this.NUDAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUDAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDAmount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.NUDAmount.Location = new System.Drawing.Point(612, 302);
            this.NUDAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDAmount.Name = "NUDAmount";
            this.NUDAmount.Size = new System.Drawing.Size(180, 39);
            this.NUDAmount.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Bisque;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 109;
            this.label2.Text = "Amount";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Bisque;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(481, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 22);
            this.label5.TabIndex = 108;
            this.label5.Text = "MonthYear";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DGVSalary
            // 
            this.DGVSalary.AllowUserToAddRows = false;
            this.DGVSalary.AllowUserToDeleteRows = false;
            this.DGVSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVSalary.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Texturina", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVSalary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVSalary.ColumnHeadersHeight = 34;
            this.DGVSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVSalary.EnableHeadersVisualStyles = false;
            this.DGVSalary.Location = new System.Drawing.Point(4, 432);
            this.DGVSalary.Name = "DGVSalary";
            this.DGVSalary.ReadOnly = true;
            this.DGVSalary.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVSalary.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVSalary.RowTemplate.Height = 28;
            this.DGVSalary.Size = new System.Drawing.Size(920, 200);
            this.DGVSalary.TabIndex = 6;
            // 
            // BtnReset
            // 
            this.BtnReset.AutoSize = true;
            this.BtnReset.BackColor = System.Drawing.Color.Bisque;
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Texturina", 11F, System.Drawing.FontStyle.Bold);
            this.BtnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnReset.Location = new System.Drawing.Point(589, 365);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(160, 47);
            this.BtnReset.TabIndex = 3;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnSalary
            // 
            this.BtnSalary.AutoSize = true;
            this.BtnSalary.BackColor = System.Drawing.Color.Bisque;
            this.BtnSalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalary.Font = new System.Drawing.Font("Texturina", 11F, System.Drawing.FontStyle.Bold);
            this.BtnSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSalary.Location = new System.Drawing.Point(188, 365);
            this.BtnSalary.Name = "BtnSalary";
            this.BtnSalary.Size = new System.Drawing.Size(160, 47);
            this.BtnSalary.TabIndex = 2;
            this.BtnSalary.Text = "Salary";
            this.BtnSalary.UseVisualStyleBackColor = false;
            this.BtnSalary.Click += new System.EventHandler(this.BtnSalary_Click);
            // 
            // FormStaffSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(928, 644);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSalary);
            this.Controls.Add(this.DGVSalary);
            this.Controls.Add(this.DTPSalaryMonth);
            this.Controls.Add(this.NUDAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbBxWorkStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPJoinDate);
            this.Controls.Add(this.MTBPhnNum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NUDStaffId);
            this.Controls.Add(this.PicBxSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CmbBxGender);
            this.Controls.Add(this.TxtBxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PicBxGymPer);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormStaffSalary";
            this.Text = "Gym Management";
            this.Load += new System.EventHandler(this.StaffSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGymPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDStaffId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox PicBxGymPer;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.NumericUpDown NUDStaffId;
        private System.Windows.Forms.PictureBox PicBxSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbBxGender;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.ComboBox CmbBxWorkStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTPJoinDate;
        private System.Windows.Forms.MaskedTextBox MTBPhnNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTPSalaryMonth;
        private System.Windows.Forms.NumericUpDown NUDAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGVSalary;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnSalary;
        private System.Windows.Forms.ToolTip ToolTip1;
    }
}