using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IceCreamGUI
{
    public partial class frmMain : Form
    {
        public static List<IceCream> cart = new List<IceCream>();

        public frmMain()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
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
        //Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group5b;Password=group5b
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group5b;Password=group5b;");
            SqlCommand cmd = new SqlCommand("select * from group5B.Employee Where UserName ='" + txtUserId.Text + "' and Password = '" + txtPassword.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                EmployeeOptionTab ss = new EmployeeOptionTab();
                ss.Show();
            }
            else
            {
                MessageBox.Show("The UserId or Password you entered is incorrect.");
            }
        }
        private void btnMLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;Persist Security Info=True;User ID=group5b;Password=group5b;");
            SqlCommand cmd = new SqlCommand("Select * From group5B.Manager Where UserName ='" + txtUserId.Text + "' and Password = '" + txtPassword.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                ManagerDashboard ss = new ManagerDashboard();
                ss.Show();
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
