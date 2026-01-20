using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MethodsFW;
using System.Data.SqlClient;

namespace GymMS
{
    public partial class FormNewMembs : Form
    {
        public FormNewMembs()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\GymMS\Gym.mdf;Integrated Security = True";

        private void FormNewMembs_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    DispMembId();
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

                        string insdata = "Insert Into NewMembers (FullName, Gender, DateOfBirth, PhnNum, Email, JoinDate, GymTime, Address, MembDuration, DateInsert) Values (@fullnm, @gndr, @dob, @phnnum, @email, @jndt, @gymtime, @addrss, @mbdur, @dtins)";

                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            inscmd.Parameters.AddWithValue("@fullnm", TxtBxName.Text.Trim());
                            inscmd.Parameters.AddWithValue("@gndr", CmbBxGender.Text.Trim());
                            inscmd.Parameters.AddWithValue("@dob", DTPDOB.Value);
                            inscmd.Parameters.AddWithValue("@phnnum", MTBPhnNum.Text);
                            inscmd.Parameters.AddWithValue("@email", TxtBxEmail.Text ?? string.Empty);
                            inscmd.Parameters.AddWithValue("@jndt", DTPJoinDate.Value);
                            inscmd.Parameters.AddWithValue("@gymtime", CmbBxGymTime.Text.Trim());
                            inscmd.Parameters.AddWithValue("@addrss", TxtBxAddrss.Text.Trim());
                            inscmd.Parameters.AddWithValue("@mbdur", CmbBxMembDur.Text.Trim());
                            inscmd.Parameters.AddWithValue("dtins", DateTime.Today);

                            inscmd.ExecuteNonQuery();

                            MessageBox.Show("Member Info Saved Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            ClearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnMembSave");
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
            TxtBxEmail.Clear();
            MTBPhnNum.Clear();
            DTPDOB.ResetText();
            DTPJoinDate.ResetText();
            CmbBxGender.SelectedIndex = -1;
            CmbBxGymTime.SelectedIndex = -1;
            CmbBxMembDur.SelectedIndex = -1;
        }

        private bool CheckEmptyFields()
        {
            if (string.IsNullOrEmpty(TxtBxName.Text) || string.IsNullOrEmpty(TxtBxAddrss.Text) || CmbBxGender.SelectedIndex == -1 || CmbBxGymTime.SelectedIndex == -1 ||
                CmbBxMembDur.SelectedIndex == -1 || !MTBPhnNum.MaskCompleted)
            {
                return true;
            }
            return false;
        }

        private void DispMembId()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select Count(*) From NewMembers";
                    using (SqlCommand cmd = new SqlCommand(seldata, sqlcon))
                    {
                        int id = (int)cmd.ExecuteScalar();
                        LbMembId.Text = $"{id + 1}";
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DispMembId");
                }
            }
        }
    }
}
