using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N09310006
{
    public partial class N09310006 : Form
    {
        public N09310006()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox1.Text);
            label2.Text = (label)*(9/5) + 32.ToString();





        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
