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
    public partial class Form_game : Form
    {
        int min = 0, max = 100;
        int answer;

        public Form_game()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.answer = r.Next(100);
            MessageBox.Show(answer.ToString());
            label1.Text = "已隨機產生0~100的數字,請在下方作答";
            label2.Text = string.Format("請輸入{0}~{1}之間的數值", min, max);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int input = Int32.Parse(textBox1.Text);
                if (input == this.answer)
                {
                    MessageBox.Show("恭喜被我戴綠帽WaW");
                }
                else if (input < this.answer)
                {
                    this.min = input;
                }
                else if (input > this.answer)
                {
                    this.max = input;
                }

                label2.Text = string.Format("請輸入{0}~{1}之間的數值", min, max);

            }

            catch (Exception el)
            {
                MessageBox.Show("輸入錯誤 難怪老婆找別人");


            }
        }
    }
}
