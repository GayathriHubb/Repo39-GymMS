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
    public partial class FormStaffSalary : Form
    {
        public FormStaffSalary()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\GymMS\Gym.mdf;Integrated Security = True";

        private void StaffSalary_Load(object sender, EventArgs e)
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
                            selcmd.Parameters.AddWithValue("@stfid", (int)NUDStaffId.Value);

                            SqlDataReader sdr = selcmd.ExecuteReader();
                            if (sdr.Read())
                            {
                                TxtBxName.Text = (string)sdr["FullName"];
                                CmbBxGender.Text = (string)sdr["Gender"];
                                MTBPhnNum.Text = Convert.ToInt64(sdr["PhnNum"]).ToString();
                                DTPJoinDate.Value = (DateTime)sdr["JoinDate"];
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


        private void BtnSalary_Click(object sender, EventArgs e)
        {
            if (NUDStaffId.Value == 0 || NUDAmount.Value == 0)
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

                        string seldata = "Select Count(*) From Salary Where StaffId = @mbid AND SalaryMonth = @slrmnth";
                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            selcmd.Parameters.AddWithValue("@mbid", NUDStaffId.Value);
                            selcmd.Parameters.AddWithValue("@slrmnth", DTPSalaryMonth.Text);

                            int rc = (int)selcmd.ExecuteScalar();
                            if (rc == 0)
                            {
                                string insdata = "Insert Into Salary (StaffId, SalaryMonth, Amount, DateInsert) Values (@stfid, @slrmnth, @amnt, @dtins)";
                                using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                                {
                                    inscmd.Parameters.AddWithValue("@stfid", (int)NUDStaffId.Value);
                                    inscmd.Parameters.AddWithValue("@slrmnth", DTPSalaryMonth.Text);
                                    inscmd.Parameters.AddWithValue("@amnt", (int)NUDAmount.Value);
                                    inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                                    inscmd.ExecuteNonQuery();
                                    SetDGVRecord((int)NUDStaffId.Value);
                                    MessageBox.Show($"Salary Payment for {DTPSalaryMonth.Text} Successfull", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    ClearFields();
                                }
                            }
                            else
                            {
                                MessageBox.Show($"No Dues for {DTPSalaryMonth.Text} Left", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                ClearFields();
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnSalary");
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
            MTBPhnNum.Clear();
            CmbBxGender.SelectedIndex = -1;
            CmbBxWorkStatus.SelectedIndex = -1;
            DTPJoinDate.ResetText();
            DTPSalaryMonth.ResetText();
            NUDAmount.Value = 0;
        }

        private void SetDGVRecord(int? staffid)
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select * From Salary Where StaffId = @stfid";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@stfid", staffid);

                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DGVSalary.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DGVRecord");
                }
            }
        }

        
    }
}
