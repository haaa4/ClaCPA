using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using Newtonsoft.Json;

namespace 班级表演小助手
{
    public partial class MainForm : UIForm
    {

        class json
        {
            public string StartText;
            public string ChooseText;
            public bool transparent;
            public Color backcolor;
            public string image;
        }
        json Json;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
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

            uiLedLabel1.Text= index.ToString();
            if(index<1)
            {
                uiSymbolButton4.Enabled = false;
            }
            else
            {
                uiSymbolButton4.Enabled= true;
            }
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");
            string jsonString = File.ReadAllText(filePath);
            Json = JsonConvert.DeserializeObject<json>(jsonString);
            uiLabel2.Text= Json.StartText;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Thread th = new Thread(() => new ArchivesForm().ShowDialog());
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            catch
            {
            }
        }


        private void ArchivesWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Application.Run(new ArchivesForm());
        }

        private void ArchivesWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Enabled = true;
            this.Activate();
            uiSymbolButton3_Click(sender, e);
        }

        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            MainForm_Load(sender, e);
        }

        private void uiSymbolButton4_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() => new ChooseForm().ShowDialog());
            th.Start();
            Application.ExitThread();
        }

        private void Gettimer_Tick(object sender, EventArgs e)
        {
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

            uiLedLabel1.Text = index.ToString();
            if (index < 1)
            {
                uiSymbolButton4.Enabled = false;
            }
            else
            {
                uiSymbolButton4.Enabled = true;
            }
        }

        private void uiSymbolButton5_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() => new SetForm().ShowDialog());
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiLedLabel1_Click(object sender, EventArgs e)
        {

        }
    }

}
