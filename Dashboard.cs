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
using System.Data.SqlClient;

namespace GymMS
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\GymMS\Gym.mdf;Integrated Security = True";

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                try
                {
                    TotalMembsCount();
                    TotalStaffCount();
                    
                    TotalEquipCount();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DashboardLoad");
                }
            }
        }

        public void TotalMembsCount()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select Count(*) From NewMembers Where MemberShipStatus = @mbsts";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@mbsts", "Yes");
                        object res = selcmd.ExecuteScalar();    
                        if (res != DBNull.Value)
                        {
                            int mbscnt = Convert.ToInt32(res);
                            LbTMC.Text = $"{res}";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "TotMembsCnt");
                }
            }
        }

        public void TotalStaffCount()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select Count(*) From GymStaff Where WorkingStatus = @wrksts";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@wrksts", "Yes");
                        object res = selcmd.ExecuteScalar();
                        if (res != DBNull.Value)
                        {
                            int stfcnt = Convert.ToInt32(res);
                            LbTSC.Text = $"{res}";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "TotStaffCnt");
                }
            }
        }

        public void TotalEquipCount()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select Count(*) From Equipment";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        object res = selcmd.ExecuteScalar();
                        if (res != DBNull.Value)
                        {
                            int eqpcnt = Convert.ToInt32(res);
                            LbTEC.Text = $"{res}";
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "TotEqpCnt");
                }
            }
        }

        public void DispChartData()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select FullName, GymTime From NewMembers Where MemberShipStatus = @mbsts";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@mbsts", "Yes");
                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        //Chart1.DataSource = dt;
                        //Chart1.DataBind();
                    }

                    //Chart1.Series["GymTime"].XValueMember = "FullName";
                    //Chart1.Series["GymTime"].YValueMembers = "GymTime";
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "DispChart");
                }
            }
        }
    }
}
