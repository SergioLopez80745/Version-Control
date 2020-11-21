using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Test
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = NZXT2080TI\SQLEXPRESS; Initial Catalog = IceCreamData; Integrated Security = True;");
            SqlCommand cmd = new SqlCommand("Select * From Employee Where UserName ='" + txtUserId.Text + "' and Password = '"+ txtPassword.Text + "'",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                EmployeeTab ss = new EmployeeTab();
                ss.Show();
            }
            else
            {
                MessageBox.Show("The UserId or Password you entered is incorrect.");
            }

        }
    }
}
