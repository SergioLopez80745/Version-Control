using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IceCreamGUI
{
    public partial class frmMain : Form
    {
        public static List<iceCream> cart = new List<iceCream>();

        public frmMain()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        public class iceCream
        {
            public enum flavorType { CHOCOLATE, VANILLA, STRAWBERRY, BANANA, COFFEE, SHERBERT }
            public enum sizeType { SMALL, MEDIUM, LARGE }
            public enum toppingType { SPRINKLES, COOKIE, CHOCOLATECHIP, OREOS, CEREAL, NUTS }

            public flavorType Flavor { get; set; }
            public sizeType Size { get; set; }
            public List<toppingType> Toppings { get; set; }
            public double Cost { get; set; }


            public iceCream()
            {
                Toppings = new List<toppingType>();
            }

            public override string ToString()
            {
                string newToppings = string.Join(", ", Toppings);

                return Size + " / " + Flavor + " / " + newToppings;
            }

            public void Calculate()
            {
                double total = 0;

                if (Size == sizeType.SMALL)
                    total += 2.00;
                if (Size == sizeType.MEDIUM)
                    total += 3.00;
                if (Size == sizeType.LARGE)
                    total += 4.00;

                if (Toppings.Count > 2)
                    total += (Toppings.Count - 2) * 0.49;

                Cost = total;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == "Employee" && txtPassword.Text == "Password")
            {
                new EmployeeOptionTab().Show();
               txtPassword.UseSystemPasswordChar = true;
                this.Hide();
            }
            
            else if (txtUserId.Text == "Manager" && txtPassword.Text == "Password")
            {
                new ManagerDashboard().Show();
                txtPassword.UseSystemPasswordChar = true;
                this.Hide();
            }

            else
            {
                MessageBox.Show("The UserId or Password you entered is incorrect.");
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
