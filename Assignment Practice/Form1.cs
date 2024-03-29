﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calculate the area of a rectangle
            try
            {
                double Width, Height, Area;
                Width = Convert.ToDouble(textBox1.Text);
                Height = Convert.ToDouble(textBox2.Text);
                Area = Width * Height;
                label1.Text = "area = " + Area;
            }
            catch
            {
                MessageBox.Show("Type in two numbers");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Calculate the area of a triangle
            try
            {
                double Base, Height, Area;
                Base = Convert.ToDouble(textBox3.Text);
                Height = Convert.ToDouble(textBox4.Text);
                Area = Base * Height / 2;
                label6.Text = "area = " + Area;
            }
            catch
            {
                MessageBox.Show("Type in two numbers");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Calculate the area of a circle
            try
            {
                double Radius, Area;
                Radius = Convert.ToDouble(textBox5.Text);
                Area = 3.14 * Radius * Radius;
                label7.Text = "area = " + Area;
            }
            catch
            {
                MessageBox.Show("Type in a number");
            }
        }
    }
}
