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
    public partial class FormStaffData : Form
    {
        public FormStaffData()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\GymMS\Gym.mdf;Integrated Security = True";

        private void FormStaffData_Load(object sender, EventArgs e)
        {
            FetchNamesInCB();

            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select StaffId, FullName, Gender, DateOfBirth, PhnNum, Email, JoinDate, Address, WorkingStatus From GymStaff Where WorkingStatus = @wrksts";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        selcmd.Parameters.AddWithValue("@wrksts", "Yes");
                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DGVStaff.DataSource = dt;

                        LbTRC.Text = DGVStaff.Rows.Count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "StaffDataLoad");
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            FormStaffData_Load(this, EventArgs.Empty);
            CmbBxName.ResetText();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (selname != null)
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string seldata = "Select StaffId, FullName, Gender, DateOfBirth, PhnNum, Email, JoinDate, Address, WorkingStatus From GymStaff Where FullName = @selname";
                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            selcmd.Parameters.AddWithValue("@selname", selname);

                            SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            DGVStaff.DataSource = dt;

                            LbTRC.Text = DGVStaff.Rows.Count.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnSearch");
                    }
                }
            }
            
        }

        string selname;
        private void CmbBxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            selname = CmbBxName.Text;
        }

        private void FetchNamesInCB()
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    CmbBxName.Items.Clear();
                    sqlcon.Open();

                    string seldata = "Select FullName From GymStaff";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataReader sdr = selcmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            CmbBxName.Items.Add(sdr["FullName"]);
                        }

                        sdr.Close();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "CBName");
                }
            }
        }
    }
}
