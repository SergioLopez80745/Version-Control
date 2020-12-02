using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IceCreamGUI
{
    public partial class ManagerDashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = NZXT2080TI\SQLEXPRESS; Initial Catalog = IceCreamData; Integrated Security = True;");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        //ID variable used in Updating and Deleting Record  
        int ID = 0;

        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Hide();
        }

        private void btnViewSchedule_Click(object sender, EventArgs e)
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

            //lables , text boxes and bottons for employees
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            txtFName.Hide();
            txtId.Hide();
            txtLName.Hide();
            txtPassword.Hide();
            txtPhone.Hide();
            txtUserName.Hide();
            btnAddEmp.Hide();
            btnRemoveEmp.Hide();
            btnUpdateEmp.Hide();

            //schedule lables, text boxes and bottons
            label1.Show();
            txtTime.Show();
            btnAddSch.Show();
            btnRemoveSch.Show();
            btnUpdateSch.Show();
        }

        private void btnViewItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = NZXT2080TI\SQLEXPRESS; Initial Catalog = IceCreamData; Integrated Security = True;";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From Product";

            DataTable Product = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(Product);
            dataGridView1.DataSource = Product;

            infoHide();
        }

        private void btnViewEmp_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = NZXT2080TI\SQLEXPRESS; Initial Catalog = IceCreamData; Integrated Security = True;";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From Employee";

            DataTable Employee = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(Employee);
            dataGridView1.DataSource = Employee;

            //lables , text boxes and bottons for employees
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            txtFName.Show();
            txtId.Show();
            txtLName.Show();
            txtPassword.Show();
            txtPhone.Show();
            txtUserName.Show();
            btnAddEmp.Show();        
            btnRemoveEmp.Show();         
            btnUpdateEmp.Show();

            //schedule lables, text boxes and bottons
            label1.Hide();
            txtTime.Hide();
            btnAddSch.Hide();
            btnRemoveSch.Hide();
            btnUpdateSch.Hide();
        }

        private void infoHide()
        {
            label1.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            txtTime.Hide();
            txtFName.Hide();
            txtId.Hide();
            txtLName.Hide();
            txtPassword.Hide();
            txtPhone.Hide();
            txtUserName.Hide();
            btnAddEmp.Hide();
            btnAddSch.Hide();
            btnRemoveEmp.Hide();
            btnRemoveSch.Hide();
            btnUpdateEmp.Hide();
            btnUpdateSch.Hide();
        }

        //might not need this method??
        private void infoShow()
        {
            label1.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            txtTime.Show();
            txtFName.Show();
            txtId.Show();
            txtLName.Show();
            txtPassword.Show();
            txtPhone.Show();
            txtUserName.Show();
            btnAddEmp.Show();
            btnAddSch.Show();
            btnRemoveEmp.Show();
            btnRemoveSch.Show();
            btnUpdateEmp.Show();
            btnUpdateSch.Show();
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            infoHide();
        }
    }
}
