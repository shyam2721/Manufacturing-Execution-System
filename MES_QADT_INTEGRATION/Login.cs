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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MES_QADT_INTEGRATION
{
    public partial class Login : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataSet ds = null;
        SqlDataAdapter sda = null;
        int result;
        DataTable dt;
        string status;
        public Login()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Username should not be blank");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password should not be blank");
                return;
            }
            else
            {

                ds = new DataSet();
                con = new SqlConnection("Data Source=LAPTOP-D75E4G8P\\SQLEXPRESS;Initial Catalog=mesdb;Integrated Security=True");
                try
                {
                    con.Open();
                    cmd = new SqlCommand("SP_CHECK_USER_VALIDATION", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = txtUserName.Text;
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtPassword.Text;
                    sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong credentials");
                        txtUserName.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cmd.Dispose();
                    con.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
           
        }
    }
}
