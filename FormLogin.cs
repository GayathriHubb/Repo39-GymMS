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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            Debug.WriteLine($"AutoScaleFactor: {AutoScaleFactor} | {CurrentAutoScaleDimensions}");
            //Debug.Assert(Size == CurrentAutoScaleDimensions);
        }

        readonly string constring = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\CSharp\WinFormsNetFmwk1\GymMS\Gym.mdf;Integrated Security = True";

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBxUsername.Text) ||  string.IsNullOrEmpty(TxtBxPassword.Text))
            {
                MessageBox.Show("Pls Fill the Empty Fields..", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return; 
            }
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(constring))
                {
                    try
                    {
                        sqlcon.Open();

                        string seldata = "Select Count(*) From Users Where Username = @un AND Password = @pswrd";
                        using (SqlCommand selcmd = new SqlCommand(seldata, sqlcon))
                        {
                            selcmd.Parameters.AddWithValue("@un", TxtBxUsername.Text.Trim());
                            selcmd.Parameters.AddWithValue("@pswrd", TxtBxPassword.Text.Trim());

                            int rc = Convert.ToInt32(selcmd.ExecuteScalar());
                            if (rc > 0)
                            {
                                Form1Gym.un = TxtBxUsername.Text.Trim();
                                MessageBox.Show("SignIn Successfull", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                Form1Gym frmgym = new Form1Gym();
                                frmgym.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message, "BtnSignIn");
                    }
                }
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TxtBxUsername.Clear();
            TxtBxPassword.Clear();
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp frmsignup = new FormSignUp();
            frmsignup.Show();
            Hide();
        }

        private void ChkBxPswrd_CheckedChanged(object sender, EventArgs e)
        {
            TxtBxPassword.UseSystemPasswordChar = !ChkBxPswrd.Checked;
        }
    }
}
