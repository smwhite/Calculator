using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool noDecimal = true;

        public Form1()
        {
            InitializeComponent();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void nine_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void eight_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "8";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "7";
        }

        private void four_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "6";
        }

        private void three_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "3";
        }

        private void two_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "2";
        }

        private void one_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "1";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (display.Text != string.Empty && noDecimal)
            {
                if((float.Parse(display.Text)) != 0)
                {
                   display.Text = display.Text + "0";
                }
            }
            else
            {
                display.Text = display.Text + "0";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            preformOp("+");

        }

        private void subtract_Click(object sender, EventArgs e)
        {
            preformOp("-");
        }

        private void divide_Click(object sender, EventArgs e)
        {
            preformOp("/");
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            preformOp("*");
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (savedNumber.Text != string.Empty && display.Text != string.Empty )
            {
                float x = float.Parse(savedNumber.Text);
                float y = float.Parse(display.Text);
                float z = 0;
                switch (operation.Text)
                {
                    case "+":
                        z = x + y;
                        savedNumber.Text = z.ToString();
                        break;

                    case "-":
                        z = x - y;
                        savedNumber.Text = z.ToString();
                        break;

                    case "/":
                        if (y != 0)
                        {
                            z = x / y;
                            savedNumber.Text = z.ToString();
                        }
                        break;

                    case "*":
                        z = x * y;
                        savedNumber.Text = z.ToString();
                        break;


                }
                display.Clear();
                noDecimal = true;
                operation.Text = "=";
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            display.Clear();
            operation.Clear();
            savedNumber.Clear();
            noDecimal = true;
        }

        private void preformOp(string op)
        {
            if (savedNumber.Text == string.Empty || (savedNumber.Text != string.Empty && operation.Text == "="))
            {
                savedNumber.Text = display.Text;
                display.Clear();
                operation.Text = op;
                noDecimal = true;
            }
            if (savedNumber.Text != string.Empty && display.Text == string.Empty)
            {
                operation.Text = op;
            }
            if (savedNumber.Text != string.Empty && display.Text != string.Empty)
            {
                float x = float.Parse(savedNumber.Text);
                float y = float.Parse(display.Text);
                float z = 0;
                switch (operation.Text)
                {
                    case "+":
                        z = x + y;
                        savedNumber.Text = z.ToString();
                        break;

                    case "-":
                        z = x - y;
                        savedNumber.Text = z.ToString();
                        break;

                    case "/":
                        if (y != 0)
                        {
                            z = x / y;
                            savedNumber.Text = z.ToString();
                        }
                        break;

                    case "*":
                        z = x * y;
                        savedNumber.Text = z.ToString();
                        break;

                }

                display.Clear();
                operation.Text = op;
                noDecimal = true;
            }
        }

        private void point_Click(object sender, EventArgs e)
        {
            if(noDecimal)
            {
                if( display.Text == string.Empty)
                {
                    display.Text = display.Text + "0";
                }
                display.Text = display.Text + ".";
                noDecimal = false;
            }
        }

        private void negative_Click(object sender, EventArgs e)
        {
            if(display.Text == string.Empty)
            {
                display.Text = display.Text + "-";
            }
            if (display.Text[0] != '-')
            {
                display.Text = "-" + display.Text;
            }
        }
    }
}
