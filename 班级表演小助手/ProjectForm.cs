using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Sunny.UI;

namespace 班级表演小助手
{
    public partial class ProjectForm : UIForm
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
        int mode;
        public ProjectForm(string json,int modei)
        {
            InitializeComponent();
            mode = modei;
            SetFullScreen(true);
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "json", json);
            json nowjson= new json();
            try
            {
                string jsonString = File.ReadAllText(filePath);
                nowjson = JsonConvert.DeserializeObject<json>(jsonString);
            }
            catch { }
            shortname.Text=nowjson.shortname;
            this.BackColor = nowjson.background;
            if (nowjson.tv == 0)
            {
                longname1.Visible = true;
                longname1.Text= nowjson.longname;
            }
            else if (nowjson.style == 0)
            {
                longname2.Visible= true;
                longname2.Text= nowjson.longname;
                if(nowjson.tv==1)
                {
                    pictureBox1.Visible = true; 
                    Image image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"image",nowjson.pathfile));
                    pictureBox1.Image = image;
                }
                else
                {
                    axWindowsMediaPlayer1.Visible = true;
                    axWindowsMediaPlayer1.URL = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "vedio", nowjson.pathfile);
                }
            }
            else
            {
                longname3.Visible = true;
                longname3.Text = nowjson.longname;
                if (nowjson.tv == 1)
                {
                    pictureBox2.Visible = true;
                    Image image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "image", nowjson.pathfile));
                    pictureBox2.Image = image;
                }
                else
                {
                    axWindowsMediaPlayer2.Visible = true;
                    axWindowsMediaPlayer2.URL = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "vedio", nowjson.pathfile);
                }
            }
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {

        }
        private void SetFullScreen(bool fullScreen)
        {
            if (fullScreen)
            {
                // 隐藏任务栏和其他窗口
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = true;

                // 隐藏任务栏（Windows API）
                SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, SWP_SHOWWINDOW | SWP_FRAMECHANGED);
            }
            else
            {

            }
        }

        // Windows API 声明
        private const int HWND_TOPMOST = -1;
        private const int SWP_SHOWWINDOW = 0x0040;
        private const int SWP_FRAMECHANGED = 0x0020;

        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private void ProjectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = null;
            axWindowsMediaPlayer2.URL = null;
            if(mode==2)
            {
                Thread th = new Thread(() => new MainForm().ShowDialog());
                th.Start();
            }
            Application.ExitThread();
        }
    }
}
