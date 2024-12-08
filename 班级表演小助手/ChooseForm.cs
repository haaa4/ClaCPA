using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Sunny.UI;

namespace 班级表演小助手
{
    public partial class ChooseForm : UIForm
    {
        class json
        {
            public string StartText;
            public string ChooseText;
            public bool transparent;
            public Color backcolor;
            public string image;
        }
        json Json=new json();
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void ChooseForm_Load(object sender, EventArgs e)
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
            if(index<=4)
            {
                pictureBox1.Visible = false;
                if(index<=3)
                {
                    pictureBox2.Visible = false;
                }
                if(index<=2)
                {
                    pictureBox3.Visible = false;
                }
                if(index<=1)
                {
                    pictureBox5.Visible = false;
                }
            }
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");
            string jsonString = File.ReadAllText(filePath);
            Json = JsonConvert.DeserializeObject<json>(jsonString);
            uiLabel1.Text = Json.ChooseText;
            if(!Json.transparent)
            {
                this.BackColor = Json.backcolor;
            }
            Image image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "image", Json.image));
            pictureBox1.Image= image;
            pictureBox2.Image= image;
            pictureBox3.Image= image;
            pictureBox4.Image= image;
            pictureBox5.Image= image;
        }

        private void ChooseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() => new MainForm().ShowDialog());
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            Application.ExitThread();
        }

        private void uiSymbolButton1_Leave(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() => new KnowForm().ShowDialog());
            th.Start();
            Application.ExitThread();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() => new KnowForm().ShowDialog());
            th.Start();
            Application.ExitThread();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() => new KnowForm().ShowDialog());
            th.Start();
            Application.ExitThread();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() => new KnowForm().ShowDialog());
            th.Start();
            Application.ExitThread();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(() => new KnowForm().ShowDialog());
            th.Start();

            Application.ExitThread();
        }
    }
}
