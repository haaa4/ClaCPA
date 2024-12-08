using Newtonsoft.Json;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace 班级表演小助手
{
    public partial class StartForm : Form
    {
        class start
        {
            public bool validation;
        }
        start sta=new start();
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "start.json");
            string jsonString = File.ReadAllText(filePath);
            sta = JsonConvert.DeserializeObject<start>(jsonString);
            if(!sta.validation)
            {
                uiLabel2.Text = "正在启动中（非校验模式）";
            }
        }

        private void WorkMain_DoWork(object sender, DoWorkEventArgs e)
        {
            Application.Run(new MainForm());
        }
        string wrong = null;
        private void starttimer_Tick(object sender, EventArgs e)
        {
            starttimer.Stop();
            if (sta.validation)
            {
                uiLabel2.Text = "检查资源完整性...";
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "use.cps");
                wrong = null;
                if (!File.Exists(filePath))
                {
                    wrong = "我们无法找到use.cps\n";
                }
                filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "used.cps");
                if (!File.Exists(filePath))
                {
                    wrong = wrong + "我们无法找到used.cps\n";
                }
                if (wrong != null)
                {
                    wrong = wrong + "请尝试手动在archives文件夹中添加它们，或者，重新安装程序？";
                    this.Hide();
                    WrongWorker.RunWorkerAsync();
                    return;
                }
                filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "use.cps");
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
                for (int i = 0; i < index; i++)
                {
                    try
                    {
                        filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "json", list[i]);
                        if (!File.Exists(filePath))
                        {
                            wrong = wrong + "在“use.cps”中提到了“" + list[i] + "”，但是我们并没有找到它\n";
                        }
                    }
                    catch (Exception ex)
                    {
                        wrong = wrong + ex.ToString() + "\n";
                    }
                }
                if (wrong != null)
                {
                    wrong = wrong + "请尝试在use.cps中删除它们，或者找到被删除的文件？";
                }
                filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "used.cps");
                index = 0;
                List<string> used = new List<string>();
                foreach (string line in File.ReadLines(filePath))
                {
                    string trimmedLine = line.Trim();
                    if (!string.IsNullOrEmpty(trimmedLine))
                    {
                        index++;
                        used.Add(trimmedLine);
                    }
                }
                for (int i = 0; i < index; i++)
                {
                    if (!list.Contains(used[i]))
                    {
                        wrong = wrong + "\n在“used.cps”中提到了“" + used[i] + "”，但我们未在“use.cps”中找到它们，请尝试手动删除它";
                    }
                }
                if (wrong != null)
                {
                    this.Hide();
                    WrongWorker.RunWorkerAsync();
                    return;
                }
            }
            this.Hide();
            WorkMain.RunWorkerAsync();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void WrongWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Application.Run(new StartWrongForm(wrong));
        }
    }
}
