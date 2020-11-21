using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Test
{
    public partial class frmMain : Form
    {
        public static List<IceCream> cart = new List<IceCream>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = NZXT2080TI\SQLEXPRESS; Initial Catalog = IceCreamData; Integrated Security = True;");
            SqlCommand cmd = new SqlCommand("Select * From Employee Where UserName ='" + txtUserId.Text + "' and Password = '"+ txtPassword.Text + "'",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                EmployeeTab ss = new EmployeeTab();
                ss.Show();
            }
            else
            {
                MessageBox.Show("The UserId or Password you entered is incorrect.");
            }

        }

        private void btnMLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = NZXT2080TI\SQLEXPRESS; Initial Catalog = IceCreamData; Integrated Security = True;");
            SqlCommand cmd = new SqlCommand("Select * From Manager Where UserName ='" + txtUserId.Text + "' and Password = '" + txtPassword.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                ManagerTab ss = new ManagerTab();
                ss.Show();
            }
            else
            {
                MessageBox.Show("The UserId or Password you entered is incorrect.");
            }
        }

        public class IceCream
        {
            public enum flavorType { CHOCOLATE, VANILLA, STRAWBERRY, BANANA, COFFEE, SHERBERT }
            public enum sizeType { SMALL, MEDIUM, LARGE }
            public enum toppingType { SPRINKLES, COOKIE, CHOCOLATECHIP, OREOS, CEREAL, NUTS }

            public flavorType Flavor { get; set; }
            public sizeType Size { get; set; }
            public List<toppingType> Toppings { get; set; }
            public double Cost { get; set; }


            public IceCream()
            {
                Toppings = new List<toppingType>();
            }

            public override string ToString()
            {
                string iceCreamstring;
                iceCreamstring = Size + " " + Flavor + "   ";
                foreach (toppingType t in Toppings)
                {
                    iceCreamstring += t.ToString() + " ";
                }
                return iceCreamstring;
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
    }
}
