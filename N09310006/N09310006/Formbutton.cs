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
    public partial class Formbutton : Form
    {
        public Formbutton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text=="請按我一下")
                button1.Text="我已經被按過了";
            else if (button1.Text=="我已經被按過了")
                button1.Text="請按我一下";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "下方已被按過";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tmp = label2.Text;
            int sum = Int32.Parse(tmp)+1;
            label2.Text = sum.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {


            

        }
    }
}
