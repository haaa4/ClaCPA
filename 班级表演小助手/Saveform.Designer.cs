namespace 班级表演小助手
{
    partial class Saveform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saveform));
            this.uiWaitingBar1 = new Sunny.UI.UIWaitingBar();
            this.SuspendLayout();
            // 
            // uiWaitingBar1
            // 
            this.uiWaitingBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiWaitingBar1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiWaitingBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiWaitingBar1.Location = new System.Drawing.Point(14, 52);
            this.uiWaitingBar1.MinimumSize = new System.Drawing.Size(70, 23);
            this.uiWaitingBar1.Name = "uiWaitingBar1";
            this.uiWaitingBar1.Size = new System.Drawing.Size(300, 29);
            this.uiWaitingBar1.TabIndex = 0;
            this.uiWaitingBar1.Text = "uiWaitingBar1";
            // 
            // Saveform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(330, 104);
            this.Controls.Add(this.uiWaitingBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Saveform";
            this.Text = "保存中";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Deactivate += new System.EventHandler(this.Saveform_Deactivate);
            this.Load += new System.EventHandler(this.Saveform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIWaitingBar uiWaitingBar1;
    }
}