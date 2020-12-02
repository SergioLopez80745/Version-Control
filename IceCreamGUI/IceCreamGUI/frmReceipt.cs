using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Net.Mail;

namespace IceCreamGUI
{
    public partial class frmReceipt : Form
    {
        public frmReceipt()
        {
            InitializeComponent();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            EmployeeOptionTab ss = new EmployeeOptionTab();
            ss.Show();
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            int iceCreamNum = 0;

            foreach (frmMain.IceCream I in frmMain.cart)
            {
                iceCreamNum++;

                lstSummary.Items.Add(("Ice Cream #" + iceCreamNum.ToString()));
                lstSummary.Items.Add((I.Size.ToString() + "Flavor: " + I.Flavor.ToString()));
                lstSummary.Items.Add("Toppings:");


                foreach (frmMain.IceCream.toppingType topping in I.Toppings)
                    lstSummary.Items.Add(topping.ToString());
                lstSummary.Items.Add(("Item cost: " + I.Cost.ToString("C2")));
                lstSummary.Items.Add(" ");

            }

            double totalIceCream = 0.0;



            foreach (frmMain.IceCream icecream in frmMain.cart)
                totalIceCream += icecream.Cost;

            double tax = 8.25;
            double totalOrder = (totalIceCream * tax) / 100;

            txtSubTotal.Text = totalIceCream.ToString("C2");

            txtTax.Text = totalOrder.ToString("C2");
            txtTotalBalance.Text = (totalIceCream + totalOrder).ToString("C2");
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            //need code that prompts user for email, will then send contents in the list box to user's email
        }
        private PrintDocument document = new PrintDocument();

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //prints list box 
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = document;
            ppd.Document.DocumentName = "Receipt";
            document.PrintPage += document_PrintPage;
            ppd.ShowDialog();

        }

        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.PageUnit = GraphicsUnit.Millimeter;
            int leading = 10;
            int leftMargin = 25;
            int topMargin = 10;

            
            StringFormat FmtRight = new StringFormat() { Alignment = StringAlignment.Far };
            StringFormat FmtLeft = new StringFormat() { Alignment = StringAlignment.Near };
            StringFormat FmtCenter = new StringFormat() { Alignment = StringAlignment.Near };

            StringFormat fmt = FmtRight;

            using (Font font = new Font("Arial Narrow", 12f))
            {
                SizeF sz = e.Graphics.MeasureString("_|", Font);
                float h = sz.Height + leading;

                for (int i = 0; i < lstSummary.Items.Count; i++)
                    e.Graphics.DrawString(lstSummary.Items[i].ToString(), font, Brushes.Black,
                                          leftMargin, topMargin + h * i, fmt);
            }
        }

    }
    }

