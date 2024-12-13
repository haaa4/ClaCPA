using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Sunny.UI;

namespace 班级表演小助手
{
    public partial class KnowForm : UIForm
    {
        public class json
        {
            public string shortname { get; set; }
            public string longname { get; set; }
            public string time { get; set; }
            public int tv { get; set; }
            public string pathfile { get; set; }
            public int style { get; set; }
            public Color background { get; set; }
        }
        string nowjsonname;
        public KnowForm()
        {
            InitializeComponent();
        }

        private void KnowForm_Load(object sender, EventArgs e)
        {
            this.Activate();
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "use.cps");
            int index = 0;
            List<string> list = new List<string>();
            foreach (string line in File.ReadLines(filePath))
            {
                string trimmedLine = line.Trim();
                if (!string.IsNullOrEmpty(trimmedLine))
                {
                    index++;
                    list.Add(trimmedLine);
                }
            }
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "used.cps");
            foreach (string line in File.ReadLines(filePath))
            {
                string trimmedLine = line.Trim();
                if (!string.IsNullOrEmpty(trimmedLine))
                {
                    index--;
                    list.Remove(trimmedLine);
                }
            }
            json nowjson=new json();
            Random random = new Random();
            nowjsonname = list[random.Next(0,index-1)];
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "json", nowjsonname);
            try
            {
                string jsonString = File.ReadAllText(filePath);
                nowjson = JsonConvert.DeserializeObject<json>(jsonString);
            }
            catch { }
            uiLabel2.Text=nowjson.shortname;
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            button1.Location = new Point(3 + hScrollBar1.Value, 173);

        }

        private void KnowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Thread th = new Thread(() => new MainForm().ShowDialog());
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        int time = 30;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            uiSymbolButton1.Text = "查看（"+ time.ToString()+  "）";
            if (time <= 0)
            {
                uiSymbolButton1_Click(sender, e);
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() => new ProjectForm(nowjsonname,2).ShowDialog());
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "used.cps");
            string newLine = nowjsonname+ Environment.NewLine;
            try
            {
                string fileContent = File.ReadAllText(filePath);
                string updatedContent = fileContent + newLine;
                File.WriteAllText(filePath, updatedContent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加内容到文件时出错: " + ex.Message);
            }
            Application.ExitThread();
        }
    }
}
