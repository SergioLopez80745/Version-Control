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
            new frmReceipt().Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            IceCream IceCream = new IceCream();
            IceCream.Toppings = new List<IceCream.toppingType>();

            //size
            if (radSmall.Checked == true)
            {
                IceCream.Size = frmMain.IceCream.sizeType.SMALL;
            }
            else if (radMedium.Checked == true)
            {
                IceCream.Size = frmMain.IceCream.sizeType.MEDIUM;
            }
            else if (radLarge.Checked == true)
            {
                IceCream.Size = frmMain.IceCream.sizeType.LARGE;
            }
            
            //flavor
            if (chkChocolate.Checked == true)
            {
                IceCream.Flavor = frmMain.IceCream.flavorType.CHOCOLATE;
            }
            else if (chkVanilla.Checked == true)
            {
                IceCream.Flavor = frmMain.IceCream.flavorType.VANILLA;
            }
            else if (chkStrawberry.Checked == true)
            {
                IceCream.Flavor = frmMain.IceCream.flavorType.STRAWBERRY;
            }
            else if (chkSherbert.Checked == true)
            {
                IceCream.Flavor = frmMain.IceCream.flavorType.SHERBERT;
            }
            else if (chkCoffee.Checked == true)
            {
                IceCream.Flavor = frmMain.IceCream.flavorType.COFFEE;
            }
            else if (chkBanana.Checked == true)
            {
                IceCream.Flavor = frmMain.IceCream.flavorType.BANANA;
            }
            //Toppings

            if (chkSprinkles.Checked == true)
            {
                IceCream.Toppings.Add(frmMain.IceCream.toppingType.SPRINKLES);
            }
            if (chkCookie.Checked == true)
            {
                IceCream.Toppings.Add(frmMain.IceCream.toppingType.COOKIE);
            }
            if (chkChocolateChip.Checked == true)
            {
               IceCream.Toppings.Add(frmMain.IceCream.toppingType.CHOCOLATECHIP);
            }
            if (chkOreos.Checked == true)
            {
                IceCream.Toppings.Add(frmMain.IceCream.toppingType.OREOS);
            }
            if (chkCereal.Checked == true)
            {
                IceCream.Toppings.Add(frmMain.IceCream.toppingType.CEREAL);
            }
            if (chkNuts.Checked == true)
            {
               IceCream.Toppings.Add(frmMain.IceCream.toppingType.NUTS);
            }
           

            //will call from frmMain to calculate iceCream
            IceCream.Calculate();
            cart.Add(IceCream);

            MessageBox.Show("Ice Cream has been added to cart.");

            lstCart.Items.Add(IceCream);

            //after button is pressed, total and tax will be displayed below the list box
            double totalIceCream = 0.0;

            foreach (frmMain.IceCream icecream in frmMain.cart)
                totalIceCream += icecream.Cost;

            double tax = 8.25;
            double totalOrder = (totalIceCream * tax) / 100;

            txtSubTotal.Text = totalIceCream.ToString("C2");

            txtTax.Text = totalOrder.ToString("C2");
            txtTotalDue.Text = (totalIceCream + totalOrder).ToString("C2");

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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Item will be removed from list box
            lstCart.Items.Remove(lstCart.SelectedItem);
            lstCart.ClearSelected();
        }

        private void lblSize_Click(object sender, EventArgs e)
        {

        }

        private void btnPayCredit_Click(object sender, EventArgs e)
        {
            new frmCardPayment().Show();
            this.Hide();
        }

        private void btnPayDebit_Click(object sender, EventArgs e)
        {
            new frmCardPayment().Show();
            this.Hide();
        }

        private void btnTip_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EmpDashboard_Load(object sender, EventArgs e)
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
