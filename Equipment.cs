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
    public partial class FormEquipment : Form
    {
        public FormEquipment()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\GymMS\Gym.mdf;Integrated Security = True";

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                MessageBox.Show("Pls All All Fields Properly", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (DTPDeliveredDate.Value > DateTime.Today)
            {
                MessageBox.Show("Delivered Date Cannot be Greater than Current Date", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string insdata = "Insert Into Equipment (ItemName, Description, MusclesUsed, ItemCount, DeliveryDate, ItemCost, DateInsert) Values (@itemname, @desc, @msused, @itmcnt, @delvrydt, @itmcost, @dtins)";

                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            inscmd.Parameters.AddWithValue("@itemname", TxtBxItemName.Text.Trim());
                            inscmd.Parameters.AddWithValue("@desc", TxtBxDescription.Text.Trim());
                            inscmd.Parameters.AddWithValue("msused", TxtBxMuscUsed.Text.Trim());
                            inscmd.Parameters.AddWithValue("@itmcnt", (int)NUDItemCount.Value);
                            inscmd.Parameters.AddWithValue("delvrydt", DTPDeliveredDate.Value);
                            inscmd.Parameters.AddWithValue("@itmcost", (int)NUDCost.Value);
                            inscmd.Parameters.AddWithValue("@dtins", DateTime.Today);

                            inscmd.ExecuteNonQuery();
                            MessageBox.Show("Equipment Data Saved Successfully", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            ClearFields();  
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnSaveEqp");
                    }
                }
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void BtnViewEqp_Click(object sender, EventArgs e)
        {
            FormEqpData frmeqpdata = new FormEqpData();
            frmeqpdata.ShowDialog();
        }

        private void ClearFields()
        {
            TxtBxItemName.Clear();
            TxtBxDescription.Clear();   
            TxtBxMuscUsed.Clear();
            DTPDeliveredDate.ResetText();
            NUDItemCount.Value = 0;
            NUDCost.Value = 0;
        }

        private bool CheckEmptyFields()
        {
            if (string.IsNullOrEmpty(TxtBxItemName.Text) || string.IsNullOrEmpty(TxtBxDescription.Text) || string.IsNullOrEmpty(TxtBxMuscUsed.Text) || NUDItemCount.Value == 0 || NUDCost.Value == 0)
            {
                return true; 
            }
            return false;
        }

        
    }
}
