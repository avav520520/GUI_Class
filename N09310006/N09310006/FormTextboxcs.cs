﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N09310006
{
    public partial class FormTextboxcs : Form
    {
        public FormTextboxcs()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("text box 被改變了");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text=textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox3.Text);
            int b = Int32.Parse(textBox4.Text);
            label4.Text = (a + b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox6.Text);
            int b = Int32.Parse(textBox5.Text);
            label5.Text = (a - b).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox8.Text);
            int b = Int32.Parse(textBox7.Text);
            label8.Text = (a * b).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox10.Text);
            int b = Int32.Parse(textBox9.Text);
            label11.Text = (a / b).ToString();
        }
    }
}
