﻿using System;
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
            display.Text = display.Text + "0";
        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void subtract_Click(object sender, EventArgs e)
        {

        }

        private void divide_Click(object sender, EventArgs e)
        {

        }

        private void multiply_Click(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {

        }
    }
}