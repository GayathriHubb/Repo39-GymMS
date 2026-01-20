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
    public partial class FormMembsFees : Form
    {
        public FormMembsFees()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\GymMS\Gym.mdf;Integrated Security = True";

        private void MembersFees_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    SetDGVRecord(null);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "FeesLoad");
                }
            }
        }

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
                                MTBPhnNum.Text = Convert.ToInt64(sdr["PhnNum"]).ToString();
                                CmbBxGender.Text = (string)sdr["Gender"];
                                CmbBxGymTime.Text = (string)sdr["GymTime"];
                                DTPFeesMonth.Value = (DateTime)sdr["JoinDate"];
                                CmbBxMembStatus.Text = (sdr["MemberShipStatus"] != DBNull.Value) ? (string)sdr["MemberShipStatus"] : string.Empty;

                                SetDGVRecord((int) NUDMembId.Value);
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

        private void BtnFees_Click(object sender, EventArgs e)
        {
            if (NUDMembId.Value == 0|| NUDAmount.Value == 0)
            {
                MessageBox.Show("Incomplete Info to Proceed", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return; 
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string seldata = "Select Count(*) From Fees Where MembId = @mbid AND FeesMonth = @fsmnth";
                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            selcmd.Parameters.AddWithValue("@mbid", NUDMembId.Value);
                            selcmd.Parameters.AddWithValue("@fsmnth", DTPFeesMonth.Text);

                            int rc = (int)selcmd.ExecuteScalar();
                            if (rc == 0)
                            {
                                string insdata = "Insert Into Fees (MembId, FeesMonth, Amount, DateInsert) Values (@mbid, @fsmnth, @amnt, @dtins)";
                                using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                                {
                                    inscmd.Parameters.AddWithValue("@mbid",(int) NUDMembId.Value);
                                    inscmd.Parameters.AddWithValue("@fsmnth", DTPFeesMonth.Text);
                                    inscmd.Parameters.AddWithValue("@amnt", (int) NUDAmount.Value);
                                    inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                                    inscmd.ExecuteNonQuery();
                                    SetDGVRecord((int)NUDMembId.Value);
                                    MessageBox.Show($"Fees Payment for {DTPFeesMonth.Text} Successfull", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    ClearFields();

                                }
                            }
                            else
                            {
                                MessageBox.Show($"No Dues for {DTPFeesMonth.Text} Left", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                ClearFields();
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnFees");
                    }
                }
            }
        }

        private void SetDGVRecord(int? membid)
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Fees Where MembId = @mbid";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@mbid", membid);

                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DGVFees.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DGVRecord");
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
            MTBPhnNum.Clear();
            DTPFeesMonth.ResetText();
            CmbBxGender.SelectedIndex = -1;
            CmbBxGymTime.SelectedIndex = -1;
            CmbBxMembStatus.SelectedIndex = -1;
            DTPFeesMonth.ResetText();
            NUDAmount.Value = 0;

        }

        
    }
}
