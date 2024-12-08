using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace 班级表演小助手
{
    public partial class StartWrongForm : UIForm
    {
        public StartWrongForm(string wrong)
        {
            InitializeComponent();
            uiLabel2.Text = wrong;
        }

        private void StartWrongForm_Load(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
