using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N09310006
{
    public partial class FormTimer2 : Form
    {
        int second;
        public FormTimer2()
        {
            InitializeComponent();
            this.second = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void FormTimer2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}秒", this.second);
            this.second++;
            
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            second=0;
            label1.Text=$"0秒";
        }
    }
}
