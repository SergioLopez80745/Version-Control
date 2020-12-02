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
            con.ConnectionString = @"Data Source = NZXT2080TI\SQLEXPRESS; Initial Catalog = IceCreamData; Integrated Security = True;";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From Schedule";

            DataTable Schedule = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(Schedule);
            dataGridView1.DataSource = Schedule;

        }
    }
}
