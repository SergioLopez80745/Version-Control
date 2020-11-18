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
    public partial class EmpDashboard : Form
    {
        public EmpDashboard()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            new CheckOut().Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            iceCream iceCream = new iceCream();
            iceCream.Toppings = new List<iceCream.ToppingType>();



            //will call from frmMain to calculate iceCream
            iceCream.Calculate();
            frmMain.cart.Add(iceCream);

            MessageBox.Show("IceCream has been added to cart.");

            //lstCart.Items.Add(pizza);
            listCart();

            //will call to reset form
            ResetForm();
        }

        private void listCart()
        {
            iceCream iceCream = new iceCream();
            iceCream.Toppings = new List<iceCream.toppingType>();
            int num = 0;

            lstCart.Items.Clear();
            foreach (iceCream I in frmMain.cart)
            {
                num++;
                lstCart.Items.Add(I);
            }
        }

        private void ResetForm()
        {
            radSmall.Checked = true;
            chkChocolate.Checked = true;
            chkSprinkles.Checked = true;
            chkStrawberry.Checked = false;
            chkSherbert.Checked = false;
            chkOreos.Checked = false;
            chkChocolateChip.Checked = false;
            chkBanana.Checked = false;
            chkCereal.Checked = false;
            chkCoffee.Checked = false;
            chkCookie.Checked = false;
            chkVanilla.Checked = false;
            chkNuts.Checked = false;
        }
    }
}
