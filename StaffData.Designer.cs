namespace GymMS
{
    partial class FormStaffData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStaffData));
            this.label11 = new System.Windows.Forms.Label();
            this.LbTRC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbBxName = new System.Windows.Forms.ComboBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LbName = new System.Windows.Forms.Label();
            this.PicBxGymPer = new System.Windows.Forms.PictureBox();
            this.LbHeading = new System.Windows.Forms.Label();
            this.DGVStaff = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGymPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Font = new System.Drawing.Font("Texturina", 11F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(406, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 35);
            this.label11.TabIndex = 85;
            this.label11.Text = "Staff Data";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbTRC
            // 
            this.LbTRC.AutoSize = true;
            this.LbTRC.BackColor = System.Drawing.Color.Bisque;
            this.LbTRC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LbTRC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LbTRC.Location = new System.Drawing.Point(123, 610);
            this.LbTRC.Name = "LbTRC";
            this.LbTRC.Size = new System.Drawing.Size(34, 25);
            this.LbTRC.TabIndex = 84;
            this.LbTRC.Text = "{?}";
            this.LbTRC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 83;
            this.label1.Text = "Total Rows:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbBxName
            // 
            this.CmbBxName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmbBxName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBxName.FormattingEnabled = true;
            this.CmbBxName.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.CmbBxName.Location = new System.Drawing.Point(111, 130);
            this.CmbBxName.Name = "CmbBxName";
            this.CmbBxName.Size = new System.Drawing.Size(200, 33);
            this.CmbBxName.TabIndex = 82;
            this.CmbBxName.Text = "Select ";
            this.CmbBxName.SelectedIndexChanged += new System.EventHandler(this.CmbBxName_SelectedIndexChanged);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.AutoSize = true;
            this.BtnRefresh.BackColor = System.Drawing.Color.Bisque;
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Font = new System.Drawing.Font("Texturina", 10F, System.Drawing.FontStyle.Bold);
            this.BtnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnRefresh.Location = new System.Drawing.Point(761, 123);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(140, 43);
            this.BtnRefresh.TabIndex = 81;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.AutoSize = true;
            this.BtnSearch.BackColor = System.Drawing.Color.Bisque;
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Font = new System.Drawing.Font("Texturina", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSearch.Location = new System.Drawing.Point(601, 123);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(140, 43);
            this.BtnSearch.TabIndex = 80;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.BackColor = System.Drawing.Color.Transparent;
            this.LbName.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.ForeColor = System.Drawing.Color.Bisque;
            this.LbName.Location = new System.Drawing.Point(12, 132);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(78, 26);
            this.LbName.TabIndex = 79;
            this.LbName.Text = "Name";
            this.LbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PicBxGymPer
            // 
            this.PicBxGymPer.BackColor = System.Drawing.Color.Gray;
            this.PicBxGymPer.Image = global::GymMS.Properties.Resources.person;
            this.PicBxGymPer.Location = new System.Drawing.Point(345, 10);
            this.PicBxGymPer.Name = "PicBxGymPer";
            this.PicBxGymPer.Size = new System.Drawing.Size(60, 60);
            this.PicBxGymPer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxGymPer.TabIndex = 78;
            this.PicBxGymPer.TabStop = false;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbHeading.Font = new System.Drawing.Font("Playball", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.DarkRed;
            this.LbHeading.Location = new System.Drawing.Point(411, 15);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(204, 50);
            this.LbHeading.TabIndex = 77;
            this.LbHeading.Text = "Star Fitness";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVStaff
            // 
            this.DGVStaff.AllowUserToAddRows = false;
            this.DGVStaff.AllowUserToDeleteRows = false;
            this.DGVStaff.BackgroundColor = System.Drawing.Color.Gray;
            this.DGVStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Texturina", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVStaff.ColumnHeadersHeight = 34;
            this.DGVStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVStaff.EnableHeadersVisualStyles = false;
            this.DGVStaff.Location = new System.Drawing.Point(4, 180);
            this.DGVStaff.Name = "DGVStaff";
            this.DGVStaff.ReadOnly = true;
            this.DGVStaff.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DGVStaff.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVStaff.RowTemplate.Height = 28;
            this.DGVStaff.Size = new System.Drawing.Size(920, 420);
            this.DGVStaff.TabIndex = 76;
            // 
            // FormStaffData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(928, 644);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LbTRC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbBxName);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.PicBxGymPer);
            this.Controls.Add(this.LbHeading);
            this.Controls.Add(this.DGVStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormStaffData";
            this.Text = "Gym Management";
            this.Load += new System.EventHandler(this.FormStaffData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGymPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LbTRC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbBxName;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.PictureBox PicBxGymPer;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.DataGridView DGVStaff;
    }
}