using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Test.frmMain;

namespace Test
{
    public partial class OrderTab : Form
    {
        public OrderTab()
        {
            InitializeComponent();
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
            IceCream IceCream = new IceCream();
            IceCream.Toppings = new List<IceCream.toppingType>();
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

        private void btnPay_Click(object sender, EventArgs e)
        {
        
        }

        private void lstCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (IceCream I in lstCart.SelectedItems)
            {
                lblSize.Text = I.Size.ToString();
                lblFlavor.Text = I.Flavor.ToString();
                lblToppings.Text = I.Toppings.ToString();

                foreach (IceCream.toppingType topping in I.Toppings)
                    lblToppings.Text += topping.ToString();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstCart.Items.Remove(lstCart.SelectedItem);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lstCart.Items.Clear();
        }

        private void RefreshList()
        {
            double subTotal = 0;

            lstCart.Items.Clear();

            //using list box
            foreach (IceCream I in frmMain.cart)
            {
                lstCart.Items.Add(I);
                subTotal += I.Cost;
            }
            lblsubTotal.Text = subTotal.ToString("C2");

            lblSize.Text = "Size ";
            lblFlavor.Text = "Flavor ";
            lblToppings.Text = "Toppings ";
            lblTotal.Text = "Cost ";
        }
    }
}
