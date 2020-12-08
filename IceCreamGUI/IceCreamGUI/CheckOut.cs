using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//not working right number are just stings not actual numbers
//still need the list to subtract to and display change to change due


namespace IceCreamGUI
{
    public partial class CheckOut : Form
    {
        char function;
        double change = 0.0;
        string userInput = "";

        public CheckOut()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            userInput = "";
            change = 0.0;
            lblGiven.Text = "0";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblGiven.Text += "";
            userInput += "0";
            lblGiven.Text += userInput;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            lblGiven.Text += ".";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblGiven.Text += "";
            userInput += "1";
            lblGiven.Text += userInput;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblGiven.Text += "";
            userInput += "2";
            lblGiven.Text += userInput;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblGiven.Text += "";
            userInput += "3";
            lblGiven.Text += userInput;
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            lblGiven.Text += "";
            userInput += "50";
            lblGiven.Text += userInput;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblGiven.Text += "";
            userInput += "4";
            lblGiven.Text += userInput;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblGiven.Text += "";
            userInput += "5";
            lblGiven.Text += userInput;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblGiven.Text += "";
            userInput += "6";
            lblGiven.Text += userInput;
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            lblGiven.Text += "";
            userInput += "20";
            lblGiven.Text += userInput;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblGiven.Text += "";
            userInput += "7";
            lblGiven.Text += userInput;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblGiven.Text += "";
            userInput += "8";
            lblGiven.Text += userInput;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblGiven.Text += "";
            userInput += "9";
            lblGiven.Text += userInput;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            lblGiven.Text += "";
            userInput += "10";
            lblGiven.Text += userInput;
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            new EmpDashboard().Show();
            this.Hide();
        }
    }
}
