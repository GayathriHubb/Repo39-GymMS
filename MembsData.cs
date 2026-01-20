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
    public partial class FormMembsData : Form
    {
        public FormMembsData()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\GymMS\Gym.mdf;Integrated Security = True";

        private void FormSearchMembs_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select NewMembers.NewMembsId as MembId, FullName, Gender, DateOfBirth, PhnNum, Email, JoinDate, GymTime, Address, MembDuration, MemberShipStatus From NewMembers";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        DGVMembs.DataSource = dt;

                        LbTRC.Text = DGVMembs.Rows.Count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "SearchMembsLoad");
                }
            }
        }

        string selgender;
        private void CmbBxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            selgender = CmbBxGender.Text;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            FormSearchMembs_Load(this, EventArgs.Empty);
            CmbBxGender.SelectedIndex = -1;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (selgender != null)
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string seldata = $"Select NewMembers.NewMembsId as MembId, FullName, Gender, DateOfBirth, PhnNum, Email, JoinDate, GymTime, Address, MembDuration, MemberShipStatus From NewMembers Where Gender = '{selgender}'";
                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            DGVMembs.DataSource = dt;

                            LbTRC.Text = DGVMembs.Rows.Count.ToString();
                        }

                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnSearch");
                    }
                }
            }
        }
    }
}
