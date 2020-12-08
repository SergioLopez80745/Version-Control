using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IceCreamGUI
{
    
    public partial class EmployeeOptionTab : Form
    {
        public EmployeeOptionTab()
        {
            InitializeComponent();
        }

        private void BtnStartOrder_Click(object sender, EventArgs e)
        {
            new EmpDashboard().Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Hide();
        }

        private void EmployeeOptionTab_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group5b;Password=group5b;";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From group5B.Schedule";

            DataTable Schedule = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(Schedule);
            dataGridView1.DataSource = Schedule;

        }
    }
}
