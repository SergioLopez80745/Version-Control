using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceCreamGUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "Employee" && txtPassword.Text == "Password")
            {
                new EmployeeOptionTab().Show();
                this.Hide();
            }
            
            else if (txtUserId.Text == "Manager" && txtPassword.Text == "Password")
            {
                new ManagerDashboard().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("The UserId or Password you entered is incorrect.");
            }


        }
    }
}
