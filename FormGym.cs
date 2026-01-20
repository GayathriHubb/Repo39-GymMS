using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GymMS.Properties;
using MethodsFW;

namespace GymMS
{
    public partial class Form1Gym : Form
    {
        public Form1Gym()
        {
            InitializeComponent();
        }

        public static string un;
        
        private void Form1Gym_Load(object sender, EventArgs e)
        {
            LbUser.Text = $"{Solutions.CapitalizeFirstLetter1(un)}";

            MaximumSize = new Size(SystemInformation.WorkingArea.Width, SystemInformation.WorkingArea.Height);
        }

        private void Form1Gym_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        bool arrowdown = true;
        private void TSMArrow_Click(object sender, EventArgs e)
        {
            if (arrowdown)
            {
                MenuStripGym.Dock = DockStyle.Left;
                TSMArrow.Image = Resources.Right;
                arrowdown = false;
            }
            else
            {
                MenuStripGym.Dock = DockStyle.Top;
                TSMArrow.Image = Resources.Down;
                arrowdown = true;
            }
        }

        private void GymMembsDDItems_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsm = (ToolStripMenuItem)sender;

            switch (tsm.Name)
            {
                case "TSMAddMembs":
                    FormNewMembs frmnewmembs = new FormNewMembs();
                    frmnewmembs.Show();
                    break;

                case "TSMEditDelMembs":
                    FormEditDelMembs frmedmembs = new FormEditDelMembs();
                    frmedmembs.Show();
                    break;

                case "TSMMembsData":
                    FormMembsData frmsrchmembs = new FormMembsData();
                    frmsrchmembs.Show();
                    break;

                case "TSMMembsFees":
                    FormMembsFees frmmembsfees = new FormMembsFees();
                    frmmembsfees.Show();
                    break;
            }

        }

        private void GymStaffDDItems_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsm = (ToolStripMenuItem)sender;

            switch (tsm.Name)
            {
                case "TSMAddStaff":
                    FormGymStaff gymstf = new FormGymStaff();
                    gymstf.Show();
                    break;

                case "TSMUpdDelStaff":
                    FormEditDelStaff frmedstf = new FormEditDelStaff();
                    frmedstf.Show();
                    break;
                case "TSMStaffData":
                    FormStaffData frmstfdata = new FormStaffData();
                    frmstfdata.Show();
                    break;

                case "TSMStaffSalary":
                    FormStaffSalary frmstfslry = new FormStaffSalary();
                    frmstfslry.Show();
                    break;
            }
        }

        private void TSMEquipment_Click(object sender, EventArgs e)
        {
            FormEquipment gymequp = new FormEquipment();
            gymequp.Show();
        }

        private void TSMDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard frmdshbrd = new FormDashboard();
            frmdshbrd.Show();
        }

        private void TSMExitDDItems_Click(object sender, EventArgs e)
        {
            ToolStripItem tsm = (ToolStripItem)sender;

            switch (tsm.Name)
            {
                case "TSMLogout":
                    DialogResult dr1 = MessageBox.Show("Are you Sure to Logout ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dr1 == DialogResult.Yes)
                    {
                        Hide();
                        FormLogin frmlgn = new FormLogin();
                        frmlgn.Show();
                    }
                    break;
                case "TSMExitApp":
                    DialogResult dr2 = MessageBox.Show("Are you Sure to Exit App ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (dr2 == DialogResult.Yes)
                    {
                        Application.ExitThread();
                    }
                    break;
            }
        }
    }
}
