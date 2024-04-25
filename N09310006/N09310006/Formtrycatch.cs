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
    public partial class Formtrycatch : Form
    {
        public Formtrycatch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(textBox1.Text);
                button1.Text = (input + 100).ToString();
                throw new IndexOutOfRangeException();
                     
            }
            catch(System.FormatException)
            {
                MessageBox.Show("輸入的格式有問題");
            }
            catch(Exception)
            {
                MessageBox.Show("發生問題了，什麼問題不知道");
            }
            finally
            {
                MessageBox.Show("執行到最後");
            }
        }
    }
}
