using Sunny.UI;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
namespace 班级表演小助手
{
    public partial class CopyForm : UIForm
    {
        string filePath;
        public CopyForm(int tv, string pathfile, string safepath)
        {
            InitializeComponent();
            if (tv == 1)
            {
                filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "image", safepath);
                try
                {
                    File.Copy(pathfile, filePath, true);
                    Application.ExitThread();
                }
                catch (IOException ioEx)
                {
                    MessageBox.Show("发生I/O错误: " + ioEx.Message);
                }
                catch (UnauthorizedAccessException unauthEx)
                {
                    MessageBox.Show("没有权限访问文件: " + unauthEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生异常: " + ex.Message);
                }

            }
            else if (tv == 2)
            {
                filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "vedio", safepath);
                try
                {
                    File.Copy(pathfile, filePath, true);
                    Thread.Sleep(1000);
                    Application.ExitThread();
                }
                catch (IOException ioEx)
                {
                    MessageBox.Show("发生I/O错误: " + ioEx.Message);
                }
                catch (UnauthorizedAccessException unauthEx)
                {
                    MessageBox.Show("没有权限访问文件: " + unauthEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生异常: " + ex.Message);
                }
                Application.ExitThread();
            }
        }

        private void CopyForm_Load(object sender, EventArgs e)
        {

        }


        private void CopyForm_Deactivate(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                Application.ExitThread();
            }
        }
    }
}
