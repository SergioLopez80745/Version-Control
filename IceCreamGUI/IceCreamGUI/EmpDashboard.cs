using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static IceCreamGUI.frmMain;

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
            IceCream IceCream = new IceCream();
            IceCream.Toppings = new List<IceCream.toppingType>();



            //will call from frmMain to calculate iceCream
            IceCream.Calculate();
            cart.Add(IceCream);

            MessageBox.Show("IceCream has been added to cart.");

            //lstCart.Items.Add(iceCream);
            listCart();

            //will call to reset form
            ResetForm();
        }

        private void listCart()
        {
            IceCream iceCream = new IceCream();
            iceCream.Toppings = new List<IceCream.toppingType>();
            int num = 0;

            lstCart.Items.Clear();
            foreach (IceCream I in cart)
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
