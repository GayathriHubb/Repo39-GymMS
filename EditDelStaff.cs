using MethodsFW;
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

namespace GymMS
{
    public partial class FormEditDelStaff : Form
    {
        public FormEditDelStaff()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\GymMS\Gym.mdf;Integrated Security = True";

        private void PicBxSearch_Click(object sender, EventArgs e)
        {
            if (NUDStaffId.Value > 0)
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string seldata = "Select * From GymStaff Where StaffId = @stfid";
                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            selcmd.Parameters.AddWithValue("@membid", (int)NUDStaffId.Value);

                            SqlDataReader sdr = selcmd.ExecuteReader();
                            if (sdr.Read())
                            {
                                TxtBxName.Text = (string)sdr["FullName"];
                                CmbBxGender.Text = (string)sdr["Gender"];
                                TxtBxEmail.Text = (sdr["Email"] != DBNull.Value) ? (string)sdr["Email"] : string.Empty;
                                MTBPhnNum.Text = Convert.ToInt64(sdr["PhnNum"]).ToString();
                                DTPDOB.Value = (DateTime)sdr["DateOfBirth"];
                                DTPJoinDate.Value = (DateTime)sdr["JoinDate"];
                                TxtBxAddrss.Text = (string)sdr["Address"];
                                CmbBxWorkStatus.Text = (sdr["WorkingStatus"] != DBNull.Value) ? (string)sdr["WorkingStatus"] : string.Empty;

                            }
                            else
                            {
                                MessageBox.Show("StaffId Doesn't Exist", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                ClearFields();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "SearchStaff");
                    }
                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Empty Fields..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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

                        string upddata = "Update GymStaff Set FullName = @fullnm, Gender = @gndr, DateOfBirth = @dob, PhnNum = @phnnum, Email = @email, JoinDate = @jndt, Address = @addrss, WorkingStatus = @wrksts Where StaffId = @stfid";
                        using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                        {
                            updcmd.Parameters.AddWithValue("@fullnm", TxtBxName.Text.Trim());
                            updcmd.Parameters.AddWithValue("@gndr", CmbBxGender.Text);
                            updcmd.Parameters.AddWithValue("@dob", DTPDOB.Value);
                            updcmd.Parameters.AddWithValue("@phnnum", MTBPhnNum.Text);
                            updcmd.Parameters.AddWithValue("@email", TxtBxName.Text ?? string.Empty);
                            updcmd.Parameters.AddWithValue("@jndt", DTPJoinDate.Value);
                            updcmd.Parameters.AddWithValue("@addrss", TxtBxAddrss.Text.Trim());
                            updcmd.Parameters.AddWithValue("@mbshpsts", CmbBxWorkStatus.Text);
                            updcmd.Parameters.AddWithValue("@stfid", (int) NUDStaffId.Value);

                            updcmd.ExecuteNonQuery();
                            MessageBox.Show("Staff Record Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            ClearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "EditStaff");
                    }
                }
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (NUDStaffId.Value > 0)
            {
                DialogResult dr = MessageBox.Show($"Are you Sure to Delete StaffId: {NUDStaffId.Value} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string deldata = "Delete From GymStaff Where StaffId = @stfid";
                            using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                            {
                                delcmd.Parameters.AddWithValue("@stfid", (int)NUDStaffId.Value);

                                delcmd.ExecuteNonQuery();
                                MessageBox.Show("Staff Record Deleted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }

                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "DeleteStaff");
                        }
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
            NUDStaffId.Value = 0;
            TxtBxName.Clear();
            TxtBxAddrss.Clear();
            MTBPhnNum.Clear();
            TxtBxEmail.Clear();
            CmbBxGender.SelectedIndex = -1;
            CmbBxWorkStatus.SelectedIndex = -1;
            DTPDOB.ResetText();
            DTPJoinDate.ResetText();
        }

        private bool CheckEmptyFields()
        {
            if (string.IsNullOrEmpty(TxtBxName.Text) || string.IsNullOrEmpty(TxtBxAddrss.Text) || CmbBxGender.SelectedIndex == -1 || !MTBPhnNum.MaskCompleted || CmbBxWorkStatus.SelectedIndex == -1)
            {
                return true;
            }
            return false;
        }

        
    }
}
