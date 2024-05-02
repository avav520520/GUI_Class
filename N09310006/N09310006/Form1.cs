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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Text="我已經被按過了";
            Form form = new Formbutton();
            form.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new FormTextboxcs();

            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new Formtrycatch();

            form.Show(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new N09310006();

            form.Show(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new FormTimer2();

            form.Show();
        }
    }
}
