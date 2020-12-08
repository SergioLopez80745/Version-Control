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
            new StandardReceipt().Show();
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
            if (radChocolate.Checked == true)
            {
                IceCream.Flavor = frmMain.IceCream.flavorType.CHOCOLATE;
            }
            else if (radVanilla.Checked == true)
            {
                IceCream.Flavor = frmMain.IceCream.flavorType.VANILLA;
            }
            else if (radStrawberry.Checked == true)
            {
                IceCream.Flavor = frmMain.IceCream.flavorType.STRAWBERRY;
            }
            else if (radSherbert.Checked == true)
            {
                IceCream.Flavor = frmMain.IceCream.flavorType.SHERBERT;
            }
            else if (radCoffee.Checked == true)
            {
                IceCream.Flavor = frmMain.IceCream.flavorType.COFFEE;
            }
            else if (radBanana.Checked == true)
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
            
            double tip = 0;


            double totalOrder = (totalIceCream * tax) / 100;
            txtTax.Text = totalOrder.ToString("C2");
            txtSubTotal.Text = totalIceCream.ToString("C2");

            if (radFivePercent.Checked == true)
            {
                double percent = 0.05;
                tip = (totalIceCream * percent);
                txtTip.Text = tip.ToString("C2");
                txtTax.Text = totalOrder.ToString("C2");
                txtTotalDue.Text = (totalIceCream + totalOrder + tip).ToString("C2");
            }
            else if (radTenPercent.Checked == true)
            {
                double percent = 0.10;
                tip = (totalIceCream * percent);
                txtTip.Text = tip.ToString("C2");
                txtTax.Text = totalOrder.ToString("C2");
                txtTotalDue.Text = (totalIceCream + totalOrder + tip).ToString("C2");

            }
            else if (radFifteenPercent.Checked == true)
            {
                double percent = 0.15;
                tip = (totalIceCream * percent);
                txtTip.Text = tip.ToString("C2");
                txtTax.Text = totalOrder.ToString("C2");
                txtTotalDue.Text = (totalIceCream + totalOrder + tip).ToString("C2");
            }
            else if (radTwentyPercent.Checked == true)
            {
                double percent = 0.20;
                tip = (totalIceCream * percent);
                txtTip.Text = tip.ToString("C2");
                txtTax.Text = totalOrder.ToString("C2");
                txtTotalDue.Text = (totalIceCream + totalOrder + tip).ToString("C2");
            }

            else
            {
                txtTip.Text = tip.ToString("C2");
                txtTax.Text = totalOrder.ToString("C2");
                txtTotalDue.Text = (totalIceCream + totalOrder).ToString("C2");
            }
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
            radChocolate.Checked = true;
            chkSprinkles.Checked = true;
            radStrawberry.Checked = false;
            radSherbert.Checked = false;
            chkOreos.Checked = false;
            chkChocolateChip.Checked = false;
            radBanana.Checked = false;
            chkCereal.Checked = false;
            radCoffee.Checked = false;
            chkCookie.Checked = false;
            radVanilla.Checked = false;
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
            this.Close();
            new EmployeeOptionTab().Show();
        }

        private void EmpDashboard_Load(object sender, EventArgs e)
        {
            radSmall.Checked = true;
            radChocolate.Checked = true;
            chkSprinkles.Checked = true;
            radStrawberry.Checked = false;
            radSherbert.Checked = false;
            chkOreos.Checked = false;
            chkChocolateChip.Checked = false;
            radBanana.Checked = false;
            chkCereal.Checked = false;
            radCoffee.Checked = false;
            chkCookie.Checked = false;
            radVanilla.Checked = false;
            chkNuts.Checked = false;

            
        }
    }
}
