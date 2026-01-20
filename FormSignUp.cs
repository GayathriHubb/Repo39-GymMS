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
using MethodsFW;

namespace GymMS
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\GymMS\Gym.mdf;Integrated Security = True";

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (Solutions.SignUpProcess(TxtBxUsername.Text.Trim(), TxtBxPassword.Text.Trim(), TxtBxCnfmPswrd.Text.Trim()))
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string chkun = "Select Count(*) From Users Where Username = @un";
                        using (SqlCommand chkcmd = new SqlCommand(chkun, sqlcon))
                        {
                            chkcmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());
                            int rc = 0;
                            int res = Convert.ToInt32(chkcmd.ExecuteScalar());
                            if (rc > 0)
                            {
                                string tempun = $"{Solutions.CapitalizeFirstLetter1(TxtBxUsername.Text)}";
                                MessageBox.Show($"Username: {tempun} is Existing Already", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        string insdata = "Insert Into Users (Username, Password, DateCreate) Values (@un, @pswrd, @dtcrt)";
                        using (SqlCommand inscmd = new SqlCommand(insdata, sqlcon))
                        {
                            inscmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());
                            inscmd.Parameters.AddWithValue("@pswrd", TxtBxPassword.Text.Trim());
                            inscmd.Parameters.AddWithValue("@dtcrt", DateTime.Today);

                            inscmd.ExecuteNonQuery();

                            MessageBox.Show("User Registration Successfull", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            FormLogin frmlgn = new FormLogin();
                            frmlgn.Show();
                            Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnSignUp");
                    }
                }
                
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtBxUsername.Clear();
            TxtBxPassword.Clear();
            TxtBxCnfmPswrd.Clear(); 
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            FormLogin frmlgn = new FormLogin();
            frmlgn.Show();
            Hide();
        }

        private void ChkBxPswrd_CheckedChanged(object sender, EventArgs e)
        {
            TxtBxPassword.UseSystemPasswordChar = !ChkBxPswrd.Checked;
            TxtBxCnfmPswrd.UseSystemPasswordChar = !ChkBxPswrd.Checked;
        }
    }
}
