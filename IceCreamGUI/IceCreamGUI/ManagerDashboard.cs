using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IceCreamGUI
{
    public partial class ManagerDashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group5b;Password=group5b;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataTable dt;
       

        //ID variable used in Updating and Deleting Record  
        int employeeId;


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
            //DisplayDataSch();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group5b;Password=group5b;";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From group5B.Schedule";

            DataTable Schedule = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(Schedule);
            dataGridView1.DataSource = Schedule;

            ClearData();

            //lables , text boxes and bottons for employees
            label1.Hide();
            label2.Hide();
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
            txtAddress.Hide();
            txtPay.Hide();
            btnAddEmp.Hide();
            btnRemoveEmp.Hide();
            btnUpdateEmp.Hide();

            //schedule lables, text boxes and bottons
            lblAddEmpId.Show();
            lblSun.Show();
            lblMon.Show();
            lblTues.Show();
            lblWed.Show();
            lblThur.Show();
            lblFri.Show();
            lblSat.Show();
            txtAddEmployee.Show();
            txtSat.Show();
            txtSun.Show();
            txtMon.Show();
            txtTues.Show();
            txtWed.Show();
            txtThur.Show();
            txtFri.Show();

            btnAddSch.Show();
            btnRemoveSch.Show();
            btnUpdateSch.Show();

        }

        private void btnViewItem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group5b;Password=group5b;";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From group5B.Product";

            DataTable Product = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(Product);
            dataGridView1.DataSource = Product;

            infoHide();
            ClearData();
        }

        private void btnViewEmp_Click(object sender, EventArgs e)
        {
            //DisplayDataEmp();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group5b;Password=group5b;";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select * From group5B.Employee";

            DataTable Employee = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            adapter.Fill(Employee);
            dataGridView1.DataSource = Employee;

            ClearData();

            //lables , text boxes and bottons for employees
            label1.Show();
            label2.Show();
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
            txtPay.Show();
            txtAddress.Show();
            btnAddEmp.Show();        
            btnRemoveEmp.Show();         
            btnUpdateEmp.Show();

            //schedule lables, text boxes and bottons
            lblAddEmpId.Hide();
            lblSun.Hide();
            lblMon.Hide();
            lblTues.Hide();
            lblWed.Hide();
            lblThur.Hide();
            lblFri.Hide();
            lblSat.Hide();
            txtAddEmployee.Hide();
            txtSat.Hide();
            txtSun.Hide();
            txtMon.Hide();
            txtTues.Hide();
            txtWed.Hide();
            txtThur.Hide();
            txtFri.Hide();

            btnAddSch.Hide();
            btnRemoveSch.Hide();
            btnUpdateSch.Hide();
        }

        private void infoHide()
        {
            //schedule
            lblAddEmpId.Hide();
            lblSun.Hide();
            lblMon.Hide();
            lblTues.Hide();
            lblWed.Hide();
            lblThur.Hide();
            lblFri.Hide();
            lblSat.Hide();
            txtAddEmployee.Hide();
            txtSat.Hide();
            txtSun.Hide();
            txtMon.Hide();
            txtTues.Hide();
            txtWed.Hide();
            txtThur.Hide();
            txtFri.Hide();

            //employees
            label1.Hide();
            label2.Hide();
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
            txtAddress.Hide();
            txtPay.Hide();
            
            //bouttons
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
            lblAddEmpId.Show();
            lblSun.Show();
            lblMon.Show();
            lblTues.Show();
            lblWed.Show();
            lblThur.Show();
            lblFri.Show();
            lblSat.Show();
            txtAddEmployee.Show();
            txtSat.Show();
            txtSun.Show();
            txtMon.Show();
            txtTues.Show();
            txtWed.Show();
            txtThur.Show();
            txtFri.Show();

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

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtFName.Text != "" && txtLName.Text != "" && txtPhone.Text != "" && txtUserName.Text != "" && txtPassword.Text != "" && txtAddress.Text != "" && txtPay.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("insert into group5B.Employee(EmployeeId,Fname,LName,Phone,UserName,Password,Address,Pay) values(@employeeid,@fname,@lname,@phone,@username,@password,@address,@pay)", con);
                
                cmd.Parameters.AddWithValue("@employeeid", txtId.Text);
                cmd.Parameters.AddWithValue("@fname", txtFName.Text);
                cmd.Parameters.AddWithValue("@lname", txtLName.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@address",txtAddress.Text);
                cmd.Parameters.AddWithValue("@pay", txtPay.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayDataEmp();
                ClearData();
            }

            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        //Display Data in DataGridView  
        private void DisplayDataEmp()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("Select * From group5B.Employee", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void DisplayDataSch()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("Select * From group5B.Schedule", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //Clear Data  
        private void ClearData()
        {
            txtId.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtPhone.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtPay.Text = "";
            txtAddress.Text = "";

            txtAddEmployee.Text = "";
            txtSun.Text = "";
            txtMon.Text = "";
            txtTues.Text = "";
            txtWed.Text = "";
            txtThur.Text = "";
            txtFri.Text = "";
            txtSat.Text = "";
        }


        private void btnRemoveEmp_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from group5B.Employee where EmployeeId='" + txtId.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayDataEmp();

                MessageBox.Show("Record Deleted Successfully!");

                ClearData();
            }
            catch
            {
                MessageBox.Show("Please type Id in Employee Id to delete record.");
            }
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update group5B.Employee set EmployeeId='" + txtId.Text + "', FName='" + txtFName.Text+"',LName='"+txtLName.Text+"',Phone='"+txtPhone.Text+"',UserName='"+txtUserName.Text+"',Password='"+txtPassword.Text+"',Address='"+txtAddress.Text+"',Pay='"+txtPay.Text+"'where EmployeeId='"+employeeId+"'",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayDataEmp();
                ClearData();
            }
            catch
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void btnAddSch_Click(object sender, EventArgs e)
        {
            if (txtAddEmployee.Text != "" && txtSun.Text != "" && txtMon.Text != "" && txtTues.Text != "" && txtWed.Text != "" && txtThur.Text != "" && txtFri.Text != "" && txtSat.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("insert into group5B.Schedule(EmployeeId,Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday) values(@employeeid,@sunday,@monday,@tuesday,@wednesday,@thursday,@friday,@saturday)", con);
                
                cmd.Parameters.AddWithValue("@employeeid", txtAddEmployee.Text);
                cmd.Parameters.AddWithValue("@sunday",txtSun.Text);
                cmd.Parameters.AddWithValue("@monday", txtMon.Text);
                cmd.Parameters.AddWithValue("@tuesday", txtTues.Text);
                cmd.Parameters.AddWithValue("@wednesday", txtWed.Text);
                cmd.Parameters.AddWithValue("@thursday", txtThur.Text);
                cmd.Parameters.AddWithValue("@friday", txtFri.Text);
                cmd.Parameters.AddWithValue("@saturday", txtSat.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayDataSch();
                ClearData();
            }

            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtUserName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtPay.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                txtAddEmployee.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSun.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMon.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTues.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtWed.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtThur.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtFri.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtSat.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                employeeId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnRemoveSch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from group5B.Schedule where EmployeeId='" + txtAddEmployee.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayDataSch();

                MessageBox.Show("Record Deleted Successfully!");

                ClearData();
            }
            catch
            {
                MessageBox.Show("Please type Id in Employee Id to delete record.");
            }
        }

        private void btnUpdateSch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update group5B.Schedule set EmployeeId='" + txtAddEmployee.Text + "', Sunday='" + txtSun.Text + "',Monday='" + txtMon.Text + "',Tuesday='" + txtTues.Text + "',Wednesday='" + txtWed.Text + "',Thursday='" + txtThur.Text + "',Friday='" + txtFri.Text + "',Saturday='" + txtSat.Text + "'where EmployeeId='" + employeeId + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayDataSch();
                ClearData();
            }
            catch
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void btnPrintInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportInventory ri = new ReportInventory();
            ri.Show();
        }
    }
}
