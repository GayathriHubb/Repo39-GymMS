namespace GymMS
{
    partial class FormEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEquipment));
            this.label1 = new System.Windows.Forms.Label();
            this.PicBxGymPer = new System.Windows.Forms.PictureBox();
            this.LbHeading = new System.Windows.Forms.Label();
            this.TxtBxItemName = new System.Windows.Forms.TextBox();
            this.LbName = new System.Windows.Forms.Label();
            this.TxtBxDescription = new System.Windows.Forms.TextBox();
            this.TxtBxMuscUsed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPDeliveredDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NUDCost = new System.Windows.Forms.NumericUpDown();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnViewEqp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NUDItemCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGymPer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDItemCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(358, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 28);
            this.label1.TabIndex = 47;
            this.label1.Text = "Equipment Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PicBxGymPer
            // 
            this.PicBxGymPer.BackColor = System.Drawing.Color.Gray;
            this.PicBxGymPer.Image = global::GymMS.Properties.Resources.person;
            this.PicBxGymPer.Location = new System.Drawing.Point(329, 12);
            this.PicBxGymPer.Name = "PicBxGymPer";
            this.PicBxGymPer.Size = new System.Drawing.Size(60, 60);
            this.PicBxGymPer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxGymPer.TabIndex = 46;
            this.PicBxGymPer.TabStop = false;
            // 
            // LbHeading
            // 
            this.LbHeading.AutoSize = true;
            this.LbHeading.BackColor = System.Drawing.Color.Transparent;
            this.LbHeading.Font = new System.Drawing.Font("Playball", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHeading.ForeColor = System.Drawing.Color.DarkRed;
            this.LbHeading.Location = new System.Drawing.Point(395, 17);
            this.LbHeading.Name = "LbHeading";
            this.LbHeading.Size = new System.Drawing.Size(204, 50);
            this.LbHeading.TabIndex = 45;
            this.LbHeading.Text = "Star Fitness";
            this.LbHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBxItemName
            // 
            this.TxtBxItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxItemName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxItemName.Location = new System.Drawing.Point(295, 139);
            this.TxtBxItemName.Name = "TxtBxItemName";
            this.TxtBxItemName.Size = new System.Drawing.Size(420, 37);
            this.TxtBxItemName.TabIndex = 4;
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.BackColor = System.Drawing.Color.Bisque;
            this.LbName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.Location = new System.Drawing.Point(121, 146);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(120, 23);
            this.LbName.TabIndex = 49;
            this.LbName.Text = "Item Name";
            this.LbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtBxDescription
            // 
            this.TxtBxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxDescription.Location = new System.Drawing.Point(295, 191);
            this.TxtBxDescription.Multiline = true;
            this.TxtBxDescription.Name = "TxtBxDescription";
            this.TxtBxDescription.Size = new System.Drawing.Size(420, 140);
            this.TxtBxDescription.TabIndex = 5;
            // 
            // TxtBxMuscUsed
            // 
            this.TxtBxMuscUsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBxMuscUsed.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxMuscUsed.Location = new System.Drawing.Point(295, 350);
            this.TxtBxMuscUsed.Name = "TxtBxMuscUsed";
            this.TxtBxMuscUsed.Size = new System.Drawing.Size(420, 37);
            this.TxtBxMuscUsed.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Bisque;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(121, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 23);
            this.label8.TabIndex = 53;
            this.label8.Text = "Description";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Bisque;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "Muscles Used";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DTPDeliveredDate
            // 
            this.DTPDeliveredDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DTPDeliveredDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPDeliveredDate.Location = new System.Drawing.Point(295, 436);
            this.DTPDeliveredDate.Name = "DTPDeliveredDate";
            this.DTPDeliveredDate.Size = new System.Drawing.Size(220, 34);
            this.DTPDeliveredDate.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Bisque;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(121, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 23);
            this.label6.TabIndex = 55;
            this.label6.Text = "Delivered Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Bisque;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Item Cost";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NUDCost
            // 
            this.NUDCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUDCost.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDCost.Location = new System.Drawing.Point(295, 489);
            this.NUDCost.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDCost.Name = "NUDCost";
            this.NUDCost.Size = new System.Drawing.Size(180, 34);
            this.NUDCost.TabIndex = 8;
            // 
            // BtnReset
            // 
            this.BtnReset.AutoSize = true;
            this.BtnReset.BackColor = System.Drawing.Color.Bisque;
            this.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Font = new System.Drawing.Font("Texturina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnReset.Location = new System.Drawing.Point(364, 539);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(160, 50);
            this.BtnReset.TabIndex = 2;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.AutoSize = true;
            this.BtnSave.BackColor = System.Drawing.Color.Bisque;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Texturina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSave.Location = new System.Drawing.Point(154, 539);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(160, 50);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnViewEqp
            // 
            this.BtnViewEqp.AutoSize = true;
            this.BtnViewEqp.BackColor = System.Drawing.Color.Bisque;
            this.BtnViewEqp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnViewEqp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewEqp.Font = new System.Drawing.Font("Texturina", 10F, System.Drawing.FontStyle.Bold);
            this.BtnViewEqp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnViewEqp.Location = new System.Drawing.Point(574, 539);
            this.BtnViewEqp.Name = "BtnViewEqp";
            this.BtnViewEqp.Size = new System.Drawing.Size(200, 50);
            this.BtnViewEqp.TabIndex = 3;
            this.BtnViewEqp.Text = "View Equipment";
            this.BtnViewEqp.UseVisualStyleBackColor = false;
            this.BtnViewEqp.Click += new System.EventHandler(this.BtnViewEqp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Bisque;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 57;
            this.label4.Text = "Item Count";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NUDItemCount
            // 
            this.NUDItemCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUDItemCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDItemCount.Location = new System.Drawing.Point(295, 396);
            this.NUDItemCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDItemCount.Name = "NUDItemCount";
            this.NUDItemCount.Size = new System.Drawing.Size(180, 34);
            this.NUDItemCount.TabIndex = 58;
            // 
            // FormEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(220)))), ((int)(((byte)(205)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(928, 644);
            this.Controls.Add(this.NUDItemCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnViewEqp);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.NUDCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTPDeliveredDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtBxDescription);
            this.Controls.Add(this.TxtBxMuscUsed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBxItemName);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PicBxGymPer);
            this.Controls.Add(this.LbHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEquipment";
            this.Text = "Gym Management";
            ((System.ComponentModel.ISupportInitialize)(this.PicBxGymPer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDItemCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicBxGymPer;
        private System.Windows.Forms.Label LbHeading;
        private System.Windows.Forms.TextBox TxtBxItemName;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.TextBox TxtBxDescription;
        private System.Windows.Forms.TextBox TxtBxMuscUsed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPDeliveredDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NUDCost;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnViewEqp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NUDItemCount;
    }
}