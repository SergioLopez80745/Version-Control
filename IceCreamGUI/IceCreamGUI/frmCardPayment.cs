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
    public partial class frmCardPayment : Form
    {
        public frmCardPayment()
        {
            InitializeComponent();
        }
        public static string passingText;
        public static string passingText2;
        public static string passingText3;
        public static string passingText4;
        public static string passingText5;

        private void btnPay_Click(object sender, EventArgs e)
        {
            if ((txtName.Text.Trim() == String.Empty))
            {

                MessageBox.Show("Please input information");

            }
            else if ((txtCardNum.Text.Trim() == String.Empty))
            {
                MessageBox.Show("Please input information");


            }
            else if ((txtExpire.Text.Trim() == String.Empty))
            {
                MessageBox.Show("Please input information");


            }
            else if ((txtSecurityCode.Text.Trim() == String.Empty))
            {
                MessageBox.Show("Please input information");


            }
            else if ((txtZip.Text.Trim() == String.Empty))
            {
                MessageBox.Show("Please input information");


            }
            else
            {
                passingText = txtName.Text;
                passingText2 = txtCardNum.Text;
                passingText3 = txtExpire.Text;
                passingText4 = txtSecurityCode.Text;
                passingText5 = txtZip.Text;
                new frmReceipt().Show();
                this.Hide();
            }


            
        }

        private void frmCardPayment_Load(object sender, EventArgs e)
        {
          

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
            new EmpDashboard().Show();
            Close();
        }
    }
}
