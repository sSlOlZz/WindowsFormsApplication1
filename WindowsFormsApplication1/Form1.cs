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
        float num1 = 0;
        float num2 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += button14.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            textBox1.Text += button2.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {


         }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7.ToString();
        }
    }

}
