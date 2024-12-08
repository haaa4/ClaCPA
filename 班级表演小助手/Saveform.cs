using Sunny.UI;
using System;
using System.Windows.Forms;

namespace 班级表演小助手
{
    public partial class Saveform : UIForm
    {
        public Saveform(string filePath, string jsonString)
        {
            InitializeComponent();

            Application.ExitThread();
        }

        private void Saveform_Load(object sender, EventArgs e)
        {

        }

        private void Saveform_Deactivate(object sender, EventArgs e)
        {
            this.Activate();
        }
    }
}
