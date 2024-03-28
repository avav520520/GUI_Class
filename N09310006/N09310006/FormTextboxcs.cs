using System;
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
    }
}
