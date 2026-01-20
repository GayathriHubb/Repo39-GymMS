using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MethodsFW;

namespace GymMS
{
    public partial class FormGymStaff : Form
    {
        public FormGymStaff()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\GymMS\Gym.mdf;Integrated Security = True";

        private void FormGymStaff_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DispStaffId();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "MembsLoad");
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Empty Fields.. Pls Fill All Fields Properly", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (DTPDOB.Value > DateTime.Today)
            {
                MessageBox.Show("DateOfBirth Cannot be Greater than Current Date", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (DTPJoinDate.Value < DTPDOB.Value)
            {
                MessageBox.Show("Join Date Cannot be Less than DateOfBirth", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(TxtBxEmail.Text) && !Solutions.ValdEmail(TxtBxEmail.Text))
            {
                MessageBox.Show("Invalid Email.. Pls Enter Valid Email", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string insdata = "Insert Into GymStaff (FullName, Gender, DateOfBirth, PhnNum, Email, JoinDate, Address, DateInsert) Values (@fullname, @gndr, @dob, @phnnum, @email, @jndt, @addrss, @dtins)";
                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            inscmd.Parameters.AddWithValue("@fullname", TxtBxName.Text.Trim());
                            inscmd.Parameters.AddWithValue("@gndr", CmbBxGender.Text.Trim());
                            inscmd.Parameters.AddWithValue("@dob", DTPDOB.Value);
                            inscmd.Parameters.AddWithValue("@phnnum", MTBPhnNum.Text);
                            inscmd.Parameters.AddWithValue("@email", TxtBxEmail.Text.Trim() ?? string.Empty);
                            inscmd.Parameters.AddWithValue("@jndt", DTPJoinDate.Value);
                            inscmd.Parameters.AddWithValue("@addrss", TxtBxAddrss.Text.Trim());
                            inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                            inscmd.ExecuteNonQuery();
                            MessageBox.Show("Staff Info Saved Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            ClearFields();
                        }

                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnStaffSave");
                    }
                }
            }

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            TxtBxName.Clear();  
            TxtBxAddrss.Clear();    
            MTBPhnNum.Clear();
            TxtBxEmail.Clear();
            CmbBxGender.SelectedIndex = -1;
            DTPDOB.ResetText(); 
            DTPJoinDate.ResetText();    
        }

        private bool CheckEmptyFields()
        {
            if(string.IsNullOrEmpty(TxtBxName.Text) || string.IsNullOrEmpty(TxtBxAddrss.Text) || CmbBxGender.SelectedIndex == -1 || !MTBPhnNum.MaskCompleted)
            {
                return true;
            }
            return false;
        }

        private void DispStaffId()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select Count(*) From GymStaff";
                    using (SqlCommand cmd = new SqlCommand(seldata, sqlcon))
                    {
                        int id = (int)cmd.ExecuteScalar();
                        LbStaffId.Text = $"{id + 1}";
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DispStaffId");
                }
            }
        }
    }
}
