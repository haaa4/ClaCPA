using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Sunny.UI;
using Sunny.UI.Win32;

namespace 班级表演小助手
{
    public partial class SetForm : UIForm
    {
        class json {
            public string StartText;
            public string ChooseText;
            public bool transparent;
            public Color backcolor;
            public string image;
        }
        class start {
            public bool validation;
        }


        public SetForm()
        {
            InitializeComponent();
        }

        private void SetForm_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");
            string jsonString = File.ReadAllText(filePath);
            Json = JsonConvert.DeserializeObject<json>(jsonString);
            uiTextBox1.Text = Json.StartText;
            uiTextBox2.Text = Json.ChooseText;
            uiSwitch1.Active = Json.transparent;
            uiColorPicker1.Value = Json.backcolor;
            if (Json.image == "班徽")
            {
                filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "image", "班徽.png");
                Image image = Image.FromFile(filePath);
                pictureBox1.Image = image;
                openFileDialog1.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "image", "班徽.png");
            }
            else
            {
                filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "image", Json.image);
                Image image = Image.FromFile(filePath);
                pictureBox1.Image = image;
                openFileDialog1.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "image", Json.image);
            }
            uiSwitch1_ValueChanged(sender,uiSwitch1.Active);
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "start.json");
            jsonString = File.ReadAllText(filePath);
            sta = JsonConvert.DeserializeObject<start>(jsonString);
            uiSwitch2.Active = sta.validation;
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            json nowjson=new json();
            nowjson.StartText = "开始你的项目吧！";
            nowjson.ChooseText = "选择一个吧！";
            nowjson.transparent = true;
            nowjson.backcolor = Color.White;
            nowjson.image = "班徽";
            string updatedJsonString = JsonConvert.SerializeObject(nowjson, Formatting.Indented);
            string filepath= Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");
            File.WriteAllText(filepath, updatedJsonString);
            SetForm_Load(sender, e);
        }
        json Json=new json();
        start sta=new start();
        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void uiSwitch1_ValueChanged(object sender, bool value)
        {
            if (value)
            {
                uiColorPicker1.Enabled = false;
            }
            else
            {
                uiColorPicker1.Enabled = true;
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Json.image = openFileDialog1.SafeFileName;
            Thread th = new Thread(() => new CopyForm(1,openFileDialog1.FileName,openFileDialog1.SafeFileName).ShowDialog());
            th.Start();
            Thread.Sleep(500);
            Image image=Image.FromFile(Path.Combine( AppDomain.CurrentDomain.BaseDirectory, "image",Json.image));
            pictureBox1.Image=image;
        }

        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            Json.StartText = uiTextBox1.Text;
            Json.ChooseText=uiTextBox2.Text;
            Json.transparent = uiSwitch1.Active;
            Json.backcolor=uiColorPicker1.Value;
            string updatedJsonString = JsonConvert.SerializeObject(Json, Formatting.Indented);
            string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");
            File.WriteAllText(filepath, updatedJsonString);
            Application.Restart();
        }

        private void uiSymbolButton4_Click(object sender, EventArgs e)
        {
            Json.image = "班徽";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "image", "班徽.png");
            Image image = Image.FromFile(filePath);
            pictureBox1.Image = image;
            openFileDialog1.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "image", "班徽.png");
        }

        private void uiSwitch2_ValueChanged(object sender, bool value)
        {
            if (value)
            {
                sta.validation = true;
            }
            else
            {
                sta.validation = false;
            }
            string updatedJsonString = JsonConvert.SerializeObject(sta, Formatting.Indented);
            string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "start.json");
            File.WriteAllText(filepath, updatedJsonString);

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string applicationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "json");
            ProcessStartInfo startInfo = new ProcessStartInfo(applicationPath);
            Process.Start(startInfo);
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            string applicationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "use.cps");
            ProcessStartInfo startInfo = new ProcessStartInfo(applicationPath);
            Process.Start(startInfo);
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            string applicationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "used.cps");
            ProcessStartInfo startInfo = new ProcessStartInfo(applicationPath);
            Process.Start(startInfo);
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            string applicationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");
            ProcessStartInfo startInfo = new ProcessStartInfo(applicationPath);
            Process.Start(startInfo);
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            string applicationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "start.json");
            ProcessStartInfo startInfo = new ProcessStartInfo(applicationPath);
            Process.Start(startInfo);
        }

        private void uiSymbolButton5_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/haaa4/ClaCPA";
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
    }
}
