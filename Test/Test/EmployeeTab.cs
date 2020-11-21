using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class EmployeeTab : Form
    {
        public EmployeeTab()
        {
            InitializeComponent();
        }

        private void BtnStartOrder_Click(object sender, EventArgs e)
        {
            new OrderTab().Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Hide();
        }
    }
}