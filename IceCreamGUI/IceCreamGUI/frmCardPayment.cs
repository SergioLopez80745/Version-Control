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

        private void btnPay_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string CardNumber = txtCardNum.Text;
            string ExpireDate = txtExpire.Text;
            string Zipcode = txtZip.Text;
            new frmReceipt().Show();
            this.Hide();
        }

    }
}
