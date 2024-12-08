using Newtonsoft.Json;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace 班级表演小助手
{
    public partial class ArchivesForm : UIForm
    {
        List<string> play = new List<string>();
        int index = 0, uicom;
        string file, save;
        json nowjson = new json();
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
        /// <summary>
        /// 突出显示一个信息框
        /// </summary>
        /// <param name="messageget">信息内容</param>
        /// <param name="color">信息框背景颜色</param>
        private void messageshow(string messageget,Color color)
        {
            message.Text = messageget;
            message.FillColor = color;
            message.FillColor2=color;
            message.FillPressColor = color;
            message.FillSelectedColor = color;
            message.Visible = true;
            messagetimer.Enabled = true;
        }
        private bool RemoveNameFromFile(string fileName, string nameToRemove)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return false;
            }

            List<string> lines = new List<string>();

            try
            {
                // 读取所有行到列表中  
                lines = File.ReadAllLines(filePath).ToList();

                // 查找并删除给定的名字  
                bool nameFound = lines.RemoveAll(line => line.Trim() == nameToRemove) > 0;

                if (nameFound)
                {
                    // 将修改后的列表写回文件  
                    File.WriteAllLines(filePath, lines);
                }
                return nameFound;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }
        private void back()
        {
            backWorker.RunWorkerAsync();
            Application.ExitThread();
        }
        public ArchivesForm()
        {
            InitializeComponent();
        }

        private void ArchivesForm_Load(object sender, EventArgs e)
        {
            uiComboDataGridView1_SelectedIndexChanged(sender, e);
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "use.cps");
            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadLines(filePath))
                {
                    string trimmedLine = line.Trim();
                    if (!string.IsNullOrEmpty(trimmedLine))
                    {
                        index++;
                        play.Add(trimmedLine);
                    }
                }
                uiComboDataGridView1.DataSource = play;
                uiComboDataGridView1.SelectedIndex = 0;
            }
            List<string> tv = new List<string>();
            tv.Add("无");
            tv.Add("图片");
            tv.Add("视频");
            uiComboBox1.DataSource = tv;
            uiComboBox1.SelectedIndex = 0;
        }

        private void backWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Application.Run(new MainForm());
        }


        private void ArchivesForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ArchivesForm_Deactivate(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if (uiComboDataGridView1.Text == "")
            {
                messageshow("你这删除啥呢", Color.Red);
                return;
            }
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "use.cps");
            RemoveNameFromFile(filePath, uiComboDataGridView1.Text);
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "used.cps");
            RemoveNameFromFile(filePath, uiComboDataGridView1.Text);
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "json", uiComboDataGridView1.Text);
            try
            {
                // 检查文件是否存在以避免可能的异常
                if (File.Exists(filePath))
                {
                    File.Delete(filePath); // 删除文件
                    Console.WriteLine("文件删除成功。");
                }
                else
                {
                    Console.WriteLine("文件不存在。");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("无法删除文件：" + ex.Message);
            }
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "use.cps");
            uiComboDataGridView1.DataSource = null;
            if (File.Exists(filePath))
            {
                play.Clear();
                foreach (string line in File.ReadLines(filePath))
                {
                    string trimmedLine = line.Trim();
                    if (!string.IsNullOrEmpty(trimmedLine))
                    {
                        index++;
                        play.Add(trimmedLine);
                    }
                }
                uiComboDataGridView1.DataSource = play;
                uiComboDataGridView1.SelectedIndex = 0;
                uiTextBox1.Watermark = "删除成功！";
                if(shit==null)
                {
                    messageshow("删除成功！",Color.Red);
                }

            }
        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiTextBox1_Leave(object sender, EventArgs e)
        {

        }
        string shit = null, shitanother = null;
        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            if (play.Contains(uiTextBox1.Text))
            {
                MessageBox.Show(uiTextBox1.Text + "已存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (uiTextBox1.Text == "" || uiTextBox1.Text == null)
            {
                if (shit == null)
                {
                    MessageBox.Show("文件名不得为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (shit == null)
                uiTextBox1.Text = uiTextBox1.Text + ".json";
            else
                uiTextBox1.Text = shitanother;
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "use.cps");
            string newLine = uiTextBox1.Text + Environment.NewLine;
            play.Add(uiTextBox1.Text);
            try
            {
                // 读取现有文件内容
                string fileContent = File.ReadAllText(filePath);

                // 添加新的一行到文件内容末尾
                string updatedContent = fileContent + newLine;

                // 将更新后的内容写回文件
                File.WriteAllText(filePath, updatedContent);


                try
                {
                    filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "json", uiTextBox1.Text);
                    json json = new json
                    {
                        time = DateTime.Now.ToString(),
                        background = Color.White
                    };

                    string jsonString = JsonConvert.SerializeObject(json, Formatting.Indented);
                    if (shit != null)
                    {
                        jsonString = shit;
                    }
                    File.WriteAllText(filePath, jsonString);
                    uiComboDataGridView1.DataSource = null;
                    uiComboDataGridView1.DataSource = play;
                    uiComboDataGridView1.SelectedIndex = play.Count - 1;
                    uiTextBox1.Text = null;
                    uiTextBox1.Watermark = "添加成功！";
                    if (shit != null)
                    {
                        uiTextBox1.Watermark = "保存成功";
                        shit = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("添加内容到文件时出错: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加内容到文件时出错: " + ex.Message);
            }

        }

        private void uiTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                uiSymbolButton2_Click(sender, e);
            }
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiComboBox1.SelectedIndex > 0)
            {
                uiSymbolButton3.Enabled = true;
            }
            else
            {
                uiSymbolButton3.Enabled = false;
            }
            uicom = uiComboBox1.SelectedIndex;
        }
        Thread newThread;
        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            if (uiComboBox1.SelectedIndex == 1)
                newThread = new Thread(new ThreadStart(Getphoto));
            else
                newThread = new Thread(new ThreadStart(Getvedio));
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();

        }
        private void Getphoto()
        {
            openFileDialog.Filter = "jpg图片|*.jpg|png图片|*.png|动图|*.glf|所有文件|*.*";
            openFileDialog.ShowDialog();
        }
        private void Getvedio()
        {
            openFileDialog.Filter = "媒体文件|*.mp4|所有文件|*.*";
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            nowjson.pathfile = openFileDialog.SafeFileName;
            file = openFileDialog.FileName;
            save = openFileDialog.SafeFileName;
            CopyWorker.RunWorkerAsync();
        }

        private void uiRadioButtonGroup1_ValueChanged(object sender, int index, string text)
        {
            nowjson.style = uiRadioButtonGroup1.SelectedIndex;
        }

        private void uiColorPicker1_ValueChanged(object sender, Color value)
        {
            nowjson.background = uiColorPicker1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newThread = new Thread(new ThreadStart(GetFont));
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }
        private void GetFont()
        {
            fontDialog.ShowDialog();
        }

        private void fontDialog_Apply(object sender, EventArgs e)
        {

        }
        bool isfirstopen = true;
        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = nowjson.pathfile;
            if(uiSymbolButton3.Enabled==false&&label1.Text!=null&&isfirstopen)
            {
                uiComboDataGridView1_SelectedIndexChanged(sender, e);
                isfirstopen = false;
            }
        }

        private void uiSymbolButton4_Click(object sender, EventArgs e)
        {
            if(uiComboDataGridView1.Text=="")
            {
                messageshow("你这保存啥呢",Color.Red);
                return;
            }
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.UseShellExecute = true;
            processInfo.FileName = Application.ExecutablePath;
            processInfo.Verb = "runas";
            nowjson.shortname = uiTextBox2.Text;
            nowjson.longname = uiTextBox3.Text;
            if(openFileDialog.SafeFileName!= "openFileDialog1")
                nowjson.pathfile = openFileDialog.SafeFileName;
            nowjson.tv = uiComboBox1.SelectedIndex;
            nowjson.background = uiColorPicker1.Value;
            nowjson.style = uiRadioButtonGroup1.SelectedIndex;
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "json", uiTextBox1.Text);
            string jsonString = JsonConvert.SerializeObject(nowjson, Formatting.Indented);
            try
            {
                shit = jsonString;
                shitanother = uiComboDataGridView1.Text;
                uiSymbolButton1_Click(sender, e);
                uiSymbolButton2_Click(sender, e);
                messageshow("保存成功！", Color.Green);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CopyWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void uiSymbolButton5_Click(object sender, EventArgs e)
        {
            if (uiComboDataGridView1.Text == "")
            {
                messageshow("你这预览啥呢，想要白板请到希沃白板", Color.Red);
                return;
            }
            uiSymbolButton4_Click(sender, e);
            Thread th = new Thread(() => new ProjectForm(uiComboDataGridView1.Text,1).ShowDialog());
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void message_Click(object sender, EventArgs e)
        {
            message.Visible = false;
            messagetimer.Enabled = false;
        }

        private void messagetimer_Tick(object sender, EventArgs e)
        {
            message.Visible = false;
            messagetimer.Enabled = false;
        }

        private void uiComboDataGridView1_RectColorChanged(object sender, EventArgs e)
        {

        }
        int indexanother;
        private void uiSymbolButton6_Click(object sender, EventArgs e)
        {
            uiDataGridView.ClearRows();
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
                    uiDataGridView.Rows.Add(1);
                    
                }
            }
            for(int i=1;i<=index;i++)
            {
                uiDataGridView[0, i-1].Value = list[i-1];
            }
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "used.cps");
            foreach (string line in File.ReadLines(filePath))
            {
                string trimmedLine = line.Trim();
                if (!string.IsNullOrEmpty(trimmedLine))
                {
                    list.Remove(trimmedLine);
                }
            }
            for(int i=1;i<=index;i++)
            {
                if (list.Contains(uiDataGridView[0,i-1].Value))
                {
                    uiDataGridView[1,i-1].Value=true;
                }
                else
                {
                    uiDataGridView[1, i - 1].Value = false;
                }
            }
            indexanother = index;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton7_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "use.cps");
            int index = 0;
            List<string> list = new List<string>();
            foreach (string line in File.ReadLines(filePath))
            {
                string trimmedLine = line.Trim();
                if (!string.IsNullOrEmpty(trimmedLine))
                {
                    list.Add(trimmedLine);
                    index++;
                }
            }
            filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "used.cps");
            foreach (string line in File.ReadLines(filePath))
            {
                string trimmedLine = line.Trim();
                if (!string.IsNullOrEmpty(trimmedLine))
                {
                    list.Remove(trimmedLine);
                }
            }
            for (int i=1;i<=indexanother;i++)
            {
                filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "used.cps");
                string newLine;
                if ((bool)uiDataGridView[1,i-1].Value==true)
                {
                    if (!list.Contains(uiDataGridView[0,i-1].Value))
                    {
                        RemoveNameFromFile(filePath, uiDataGridView[0,i-1].Value.ToString());                       
                    }
                }
                else
                {
                    if(list.Contains(uiDataGridView[0, i - 1].Value))
                    {
                        newLine = uiDataGridView[0,i-1].Value.ToString() + Environment.NewLine;
                        // 读取现有文件内容
                        string fileContent = File.ReadAllText(filePath);

                        // 添加新的一行到文件内容末尾
                        string updatedContent = fileContent + newLine;

                        // 将更新后的内容写回文件
                        File.WriteAllText(filePath, updatedContent);
                    }
                }
            }
            uiSymbolButton6_Click(sender, e);
        }

        private void uiTabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            uiSymbolButton6_Click(sender, e);
        }

        private void SaveWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "json", uiTextBox1.Text);
            string jsonString = JsonConvert.SerializeObject(nowjson, Formatting.Indented);
            Application.Run(new Saveform(filePath, jsonString));
        }

        private void uiComboDataGridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "archives", "json", uiComboDataGridView1.Text);
            try
            {
                string jsonString = File.ReadAllText(filePath);
                nowjson = JsonConvert.DeserializeObject<json>(jsonString);
            }
            catch { }

            uiTextBox2.Text = nowjson.shortname;
            uiTextBox3.Text = nowjson.longname;
            uiRadioButtonGroup1.SelectedIndex = nowjson.style;
            uiColorPicker1.Value = nowjson.background;
            uiComboBox1.SelectedIndex = nowjson.tv;
            if (nowjson.tv == null || nowjson.tv == 0)
            {
                uiComboBox1.SelectedIndex = 0;
            }
            else if (nowjson.tv == 1)
            {
                uiComboBox1.SelectedIndex = 1;
            }
            else
            {
                uiComboBox1.SelectedIndex = 2;
            }
            uiRadioButtonGroup1.SelectedIndex = nowjson.style;
            if (nowjson.style == null)
                uiRadioButtonGroup1.SelectedIndex = 0;
            uiLabel4.Text = "上次修改时间为：" + nowjson.time;
        }

        private void CopyWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Application.Run(new CopyForm(uicom, file, save));
        }
    }
}
