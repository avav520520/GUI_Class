using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace N09310006
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 創建一個空的字串來存儲所選主食和飲料的內容
            string mainCourse = "";
            string drink = "";

            // 檢查panel1中的checkbox控件，看哪些被選中
            foreach (Control control in panel1.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    // 如果checkbox被選中，將其文字添加到mainCourse字串中
                    mainCourse += checkBox.Text + " ";
                }
            }

            // 檢查panel2中的checkbox控件，看哪些被選中
            foreach (Control control in panel2.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    // 如果checkbox被選中，將其文字添加到drink字串中
                    drink += checkBox.Text + " ";
                }
            }

            // 去除最後多餘的空格
            mainCourse = mainCourse.Trim();
            drink = drink.Trim();

            // 檢查是否有選擇主食和飲料
            if (mainCourse != "" || drink != "")
            {
                // 獲取當前時間
                string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // 顯示所選的內容，不顯示時間
                MessageBox.Show($"主食: {mainCourse}\n飲料: {drink}", "訂單內容");

                // 儲存內容到CSV檔案
                SaveToCSV(currentTime, mainCourse, drink);
            }
            else
            {
                // 如果沒有選擇主食或飲料，顯示提示訊息
                MessageBox.Show("請選擇至少一個主食或飲料！", "提示");
            }
        }

        // 保存內容到CSV檔案的輔助方法
        private void SaveToCSV(string time, string mainCourse, string drink)
        {
            // 指定儲存CSV檔案的資料夾路徑
            string folderPath = @"C:\Users\pd964\OneDrive\桌面\GUI_Classs";

            // 如果資料夾不存在，則創建它
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // 指定CSV檔案的路徑
            string filePath = Path.Combine(folderPath, "menu.csv");

            // 檢查檔案是否存在，如果不存在則創建並添加表頭
            bool fileExists = File.Exists(filePath);
            using (StreamWriter writer = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                if (!fileExists)
                {
                    // 寫入表頭
                    writer.WriteLine("時間,主食,飲料");
                }

                // 寫入內容
                writer.WriteLine($"{time},{mainCourse},{drink}");
            }

            // 顯示訊息提示已儲存CSV檔案
            MessageBox.Show($"已儲存為 {filePath}", "CSV檔案已儲存");
        }

    }

}
