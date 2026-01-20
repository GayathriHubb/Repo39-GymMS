namespace GymMS
{
    partial class Form1Gym
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Gym));
            this.MenuStripGym = new System.Windows.Forms.MenuStrip();
            this.TSMArrow = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMGymMembs = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddMembs = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMEditDelMembs = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMMembsData = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMMembsFees = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMGymStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMAddStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMUpdDelStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMStaffData = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMStaffSalary = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMEquipment = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMExitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.LbUser = new System.Windows.Forms.Label();
            this.MenuStripGym.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripGym
            // 
            this.MenuStripGym.BackColor = System.Drawing.Color.Transparent;
            this.MenuStripGym.Font = new System.Drawing.Font("Akaya Telivigala", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStripGym.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStripGym.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStripGym.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMArrow,
            this.TSMGymMembs,
            this.TSMGymStaff,
            this.TSMEquipment,
            this.TSMDashboard,
            this.TSMExit});
            this.MenuStripGym.Location = new System.Drawing.Point(0, 0);
            this.MenuStripGym.Name = "MenuStripGym";
            this.MenuStripGym.Size = new System.Drawing.Size(978, 109);
            this.MenuStripGym.TabIndex = 0;
            // 
            // TSMArrow
            // 
            this.TSMArrow.BackColor = System.Drawing.Color.Bisque;
            this.TSMArrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSMArrow.Image = global::GymMS.Properties.Resources.Down;
            this.TSMArrow.Name = "TSMArrow";
            this.TSMArrow.Size = new System.Drawing.Size(40, 105);
            this.TSMArrow.Click += new System.EventHandler(this.TSMArrow_Click);
            // 
            // TSMGymMembs
            // 
            this.TSMGymMembs.BackColor = System.Drawing.Color.Tan;
            this.TSMGymMembs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMAddMembs,
            this.TSMEditDelMembs,
            this.TSMMembsData,
            this.TSMMembsFees});
            this.TSMGymMembs.Font = new System.Drawing.Font("Akaya Telivigala", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMGymMembs.Image = ((System.Drawing.Image)(resources.GetObject("TSMGymMembs.Image")));
            this.TSMGymMembs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMGymMembs.Name = "TSMGymMembs";
            this.TSMGymMembs.Size = new System.Drawing.Size(163, 105);
            this.TSMGymMembs.Text = "Gym Members";
            this.TSMGymMembs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // TSMAddMembs
            // 
            this.TSMAddMembs.Name = "TSMAddMembs";
            this.TSMAddMembs.Size = new System.Drawing.Size(356, 46);
            this.TSMAddMembs.Text = "Add Members";
            this.TSMAddMembs.Click += new System.EventHandler(this.GymMembsDDItems_Click);
            // 
            // TSMEditDelMembs
            // 
            this.TSMEditDelMembs.Name = "TSMEditDelMembs";
            this.TSMEditDelMembs.Size = new System.Drawing.Size(356, 46);
            this.TSMEditDelMembs.Text = "Edit And Delete Members";
            this.TSMEditDelMembs.Click += new System.EventHandler(this.GymMembsDDItems_Click);
            // 
            // TSMMembsData
            // 
            this.TSMMembsData.Name = "TSMMembsData";
            this.TSMMembsData.Size = new System.Drawing.Size(356, 46);
            this.TSMMembsData.Text = "Members Data";
            this.TSMMembsData.Click += new System.EventHandler(this.GymMembsDDItems_Click);
            // 
            // TSMMembsFees
            // 
            this.TSMMembsFees.Name = "TSMMembsFees";
            this.TSMMembsFees.Size = new System.Drawing.Size(356, 46);
            this.TSMMembsFees.Text = "Members Fees";
            this.TSMMembsFees.Click += new System.EventHandler(this.GymMembsDDItems_Click);
            // 
            // TSMGymStaff
            // 
            this.TSMGymStaff.BackColor = System.Drawing.Color.Bisque;
            this.TSMGymStaff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMAddStaff,
            this.TSMUpdDelStaff,
            this.TSMStaffData,
            this.TSMStaffSalary});
            this.TSMGymStaff.Font = new System.Drawing.Font("Akaya Telivigala", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMGymStaff.Image = ((System.Drawing.Image)(resources.GetObject("TSMGymStaff.Image")));
            this.TSMGymStaff.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMGymStaff.Name = "TSMGymStaff";
            this.TSMGymStaff.Size = new System.Drawing.Size(125, 105);
            this.TSMGymStaff.Text = "Gym Staff";
            this.TSMGymStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // TSMAddStaff
            // 
            this.TSMAddStaff.Name = "TSMAddStaff";
            this.TSMAddStaff.Size = new System.Drawing.Size(318, 46);
            this.TSMAddStaff.Text = "Add Staff";
            this.TSMAddStaff.Click += new System.EventHandler(this.GymStaffDDItems_Click);
            // 
            // TSMUpdDelStaff
            // 
            this.TSMUpdDelStaff.Name = "TSMUpdDelStaff";
            this.TSMUpdDelStaff.Size = new System.Drawing.Size(318, 46);
            this.TSMUpdDelStaff.Text = "Edit And Delete Staff";
            this.TSMUpdDelStaff.Click += new System.EventHandler(this.GymStaffDDItems_Click);
            // 
            // TSMStaffData
            // 
            this.TSMStaffData.Name = "TSMStaffData";
            this.TSMStaffData.Size = new System.Drawing.Size(318, 46);
            this.TSMStaffData.Text = "Staff Data";
            this.TSMStaffData.Click += new System.EventHandler(this.GymStaffDDItems_Click);
            // 
            // TSMStaffSalary
            // 
            this.TSMStaffSalary.Name = "TSMStaffSalary";
            this.TSMStaffSalary.Size = new System.Drawing.Size(318, 46);
            this.TSMStaffSalary.Text = "Staff Salary";
            this.TSMStaffSalary.Click += new System.EventHandler(this.GymStaffDDItems_Click);
            // 
            // TSMEquipment
            // 
            this.TSMEquipment.BackColor = System.Drawing.Color.Tan;
            this.TSMEquipment.Font = new System.Drawing.Font("Akaya Telivigala", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSMEquipment.Image = ((System.Drawing.Image)(resources.GetObject("TSMEquipment.Image")));
            this.TSMEquipment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMEquipment.Name = "TSMEquipment";
            this.TSMEquipment.Size = new System.Drawing.Size(128, 105);
            this.TSMEquipment.Text = "Equipment";
            this.TSMEquipment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TSMEquipment.Click += new System.EventHandler(this.TSMEquipment_Click);
            // 
            // TSMDashboard
            // 
            this.TSMDashboard.BackColor = System.Drawing.Color.Bisque;
            this.TSMDashboard.Image = ((System.Drawing.Image)(resources.GetObject("TSMDashboard.Image")));
            this.TSMDashboard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMDashboard.Name = "TSMDashboard";
            this.TSMDashboard.Size = new System.Drawing.Size(126, 105);
            this.TSMDashboard.Text = "Dashboard";
            this.TSMDashboard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TSMDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TSMDashboard.Click += new System.EventHandler(this.TSMDashboard_Click);
            // 
            // TSMExit
            // 
            this.TSMExit.BackColor = System.Drawing.Color.Tan;
            this.TSMExit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMLogout,
            this.TSMExitApp});
            this.TSMExit.Image = ((System.Drawing.Image)(resources.GetObject("TSMExit.Image")));
            this.TSMExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSMExit.Name = "TSMExit";
            this.TSMExit.Size = new System.Drawing.Size(80, 105);
            this.TSMExit.Text = "Exit";
            this.TSMExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // TSMLogout
            // 
            this.TSMLogout.Name = "TSMLogout";
            this.TSMLogout.Size = new System.Drawing.Size(201, 46);
            this.TSMLogout.Text = "Logout";
            this.TSMLogout.Click += new System.EventHandler(this.TSMExitDDItems_Click);
            // 
            // TSMExitApp
            // 
            this.TSMExitApp.Name = "TSMExitApp";
            this.TSMExitApp.Size = new System.Drawing.Size(201, 46);
            this.TSMExitApp.Text = "Exit App";
            this.TSMExitApp.Click += new System.EventHandler(this.TSMExitDDItems_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Bisque;
            this.label1.Location = new System.Drawing.Point(432, 580);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 44;
            this.label1.Text = "User:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LbUser
            // 
            this.LbUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LbUser.AutoSize = true;
            this.LbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LbUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUser.ForeColor = System.Drawing.Color.Bisque;
            this.LbUser.Location = new System.Drawing.Point(506, 580);
            this.LbUser.Name = "LbUser";
            this.LbUser.Size = new System.Drawing.Size(41, 28);
            this.LbUser.TabIndex = 45;
            this.LbUser.Text = "{?}";
            this.LbUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1Gym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.LbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuStripGym);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1Gym";
            this.Text = "Gym Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1Gym_FormClosing);
            this.Load += new System.EventHandler(this.Form1Gym_Load);
            this.MenuStripGym.ResumeLayout(false);
            this.MenuStripGym.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripGym;
        private System.Windows.Forms.ToolStripMenuItem TSMArrow;
        private System.Windows.Forms.ToolStripMenuItem TSMGymMembs;
        private System.Windows.Forms.ToolStripMenuItem TSMGymStaff;
        private System.Windows.Forms.ToolStripMenuItem TSMEquipment;
        private System.Windows.Forms.ToolStripMenuItem TSMExit;
        private System.Windows.Forms.ToolStripMenuItem TSMLogout;
        private System.Windows.Forms.ToolStripMenuItem TSMExitApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbUser;
        private System.Windows.Forms.ToolStripMenuItem TSMAddMembs;
        private System.Windows.Forms.ToolStripMenuItem TSMEditDelMembs;
        private System.Windows.Forms.ToolStripMenuItem TSMMembsData;
        private System.Windows.Forms.ToolStripMenuItem TSMMembsFees;
        private System.Windows.Forms.ToolStripMenuItem TSMAddStaff;
        private System.Windows.Forms.ToolStripMenuItem TSMUpdDelStaff;
        private System.Windows.Forms.ToolStripMenuItem TSMStaffSalary;
        private System.Windows.Forms.ToolStripMenuItem TSMDashboard;
        private System.Windows.Forms.ToolStripMenuItem TSMStaffData;
    }
}

