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
    public partial class FormEqpData : Form
    {
        public FormEqpData()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\GymMS\Gym.mdf;Integrated Security = True";

        private void FormEqpData_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(constring))
            {
                try
                {
                    sqlcon.Open();

                    string seldata = "Select EqpId, ItemName, Description, MusclesUsed, ItemCount, Equipment.DeliveryDate as DeliveredDate, ItemCost From Equipment";
                    using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(selcmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        DGVEqp.DataSource = dt;
                        LbTRC.Text = DGVEqp.Rows.Count.ToString();  
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message, "EqpDataLoad");
                }
            }
        }
    }
}
