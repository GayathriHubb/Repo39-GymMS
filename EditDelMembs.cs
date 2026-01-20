using MethodsFW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymMS
{
    public partial class FormEditDelMembs : Form
    {
        public FormEditDelMembs()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\GymMS\Gym.mdf;Integrated Security = True";

        private void PicBxSearch_Click(object sender, EventArgs e)
        {
            if (NUDMembId.Value > 0)
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string seldata = "Select * From NewMembers Where NewMembsId = @membid";
                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            selcmd.Parameters.AddWithValue("@membid", (int)NUDMembId.Value);

                            SqlDataReader sdr = selcmd.ExecuteReader();
                            if (sdr.Read())
                            {
                                TxtBxName.Text = (string)sdr["FullName"];
                                TxtBxEmail.Text = (sdr["Email"] != DBNull.Value) ? (string)sdr["Email"] : string.Empty;
                                MTBPhnNum.Text = Convert.ToInt64(sdr["PhnNum"]).ToString();
                                CmbBxGender.Text = (string)sdr["Gender"];
                                CmbBxGymTime.Text = (string)sdr["GymTime"];
                                CmbBxMembDur.Text = (string)sdr["MembDuration"];
                                DTPDOB.Value = (DateTime)sdr["DateOfBirth"];
                                DTPJoinDate.Value = (DateTime)sdr["JoinDate"];
                                TxtBxAddrss.Text = (string)sdr["Address"];
                                CmbBxMembStatus.Text = (sdr["MemberShipStatus"] != DBNull.Value) ? (string) sdr["MemberShipStatus"] : string.Empty;
                                    
                            }
                            else
                            {
                                MessageBox.Show("MembId Doesn't Exist", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                ClearFields();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "SearchMemb");
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
                DialogResult dr = MessageBox.Show($"Are you Sure to Edit MembId: {NUDMembId.Value} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string upddata = "Update NewMembers Set FullName = @fullnm, Gender = @gndr, DateOfBirth = @dob, PhnNum = @phnnum, Email = @email, JoinDate = @jndt, GymTime = @gymtime, Address = @addrss, MembDuration = @mbdur, MemberShipStatus = @mbshpsts Where NewMembsId = @membid";
                            using (SqlCommand updcmd = new SqlCommand(upddata, sqlcon))
                            {
                                updcmd.Parameters.AddWithValue("@fullnm", TxtBxName.Text.Trim());
                                updcmd.Parameters.AddWithValue("@gndr", CmbBxGender.Text);
                                updcmd.Parameters.AddWithValue("@dob", DTPDOB.Value);
                                updcmd.Parameters.AddWithValue("@phnnum", MTBPhnNum.Text);
                                updcmd.Parameters.AddWithValue("@email", TxtBxName.Text ?? string.Empty);
                                updcmd.Parameters.AddWithValue("@jndt", DTPJoinDate.Value);
                                updcmd.Parameters.AddWithValue("@gymtime", CmbBxGymTime.Text);
                                updcmd.Parameters.AddWithValue("@mbdur", CmbBxMembDur.Text);
                                updcmd.Parameters.AddWithValue("@mbshpsts", CmbBxMembStatus.Text);
                                updcmd.Parameters.AddWithValue("@addrss", TxtBxAddrss.Text.Trim());
                                updcmd.Parameters.AddWithValue("@membid", (int) NUDMembId.Value);

                                updcmd.ExecuteNonQuery();
                                MessageBox.Show("Member Record Updated Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "EditMembs");
                        }
                    }
                }
                
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (NUDMembId.Value > 0)
            {
                DialogResult dr = MessageBox.Show($"Are you Sure to Delete MembId: {NUDMembId.Value} ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    using (SqlConnection sqlcon = new SqlConnection(constring))
                    {
                        try
                        {
                            sqlcon.Open();

                            string deldata = "Delete From NewMembers Where NewMembsId = @mbid";
                            using (SqlCommand delcmd = new SqlCommand(deldata, sqlcon))
                            {
                                delcmd.Parameters.AddWithValue("@mbid", (int)NUDMembId.Value);

                                delcmd.ExecuteNonQuery();
                                MessageBox.Show("Member Record Deleted Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                ClearFields();
                            }

                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine(ex.Message, "DeleteMembs");
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
            TxtBxName.Clear();
            TxtBxAddrss.Clear();
            TxtBxEmail.Clear();
            MTBPhnNum.Clear();
            DTPDOB.ResetText();
            DTPJoinDate.ResetText();
            CmbBxGender.SelectedIndex = -1;
            CmbBxGymTime.SelectedIndex = -1;
            CmbBxMembDur.SelectedIndex = -1;
            CmbBxMembStatus.SelectedIndex = -1;
            
        }

        private bool CheckEmptyFields()
        {
            if (string.IsNullOrEmpty(TxtBxName.Text) || string.IsNullOrEmpty(TxtBxAddrss.Text) || CmbBxGender.SelectedIndex == -1 || CmbBxGymTime.SelectedIndex == -1 ||
                CmbBxMembDur.SelectedIndex == -1 || CmbBxMembStatus.SelectedIndex == -1 || !MTBPhnNum.MaskCompleted)
            {
                return true;
            }
            return false;
        }


    }
}
