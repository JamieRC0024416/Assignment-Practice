using System;
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
    }
}
