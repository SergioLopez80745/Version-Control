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

        public class IceCream
        {
            public enum flavorType { CHOCOLATE, VANILLA, STRAWBERRY, BANANA, COFFEE }
            public enum sizeType { SMALL, MEDIUM, LARGE }
            public enum toppingType { SPRINKLES, COOKIE, CHOCOLATECHIP, OREOS, CEREAL }

            public flavorType Flavor { get; set; }
            public sizeType Size { get; set; }
            public List<toppingType> Toppings { get; set; }
            public double Cost { get; set; }


            public IceCream()
            {
                Toppings = new List<toppingType>();
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
