namespace 班级表演小助手
{
    partial class ArchivesForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchivesForm));
            this.backWorker = new System.ComponentModel.BackgroundWorker();
            this.uiTabControl1 = new Sunny.UI.UITabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.message = new Sunny.UI.UIButton();
            this.uiSymbolButton5 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton4 = new Sunny.UI.UISymbolButton();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiColorPicker1 = new Sunny.UI.UIColorPicker();
            this.uiLine5 = new Sunny.UI.UILine();
            this.uiRadioButtonGroup1 = new Sunny.UI.UIRadioButtonGroup();
            this.uiLine4 = new Sunny.UI.UILine();
            this.uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiLine3 = new Sunny.UI.UILine();
            this.uiTextBox3 = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiComboDataGridView1 = new Sunny.UI.UIComboBox();
            this.uiLine1 = new Sunny.UI.UILine();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.CopyWorker = new System.ComponentModel.BackgroundWorker();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SaveWorker = new System.ComponentModel.BackgroundWorker();
            this.messagetimer = new System.Windows.Forms.Timer(this.components);
            this.uiDataGridView = new Sunny.UI.UIDataGridView();
            this.uiSymbolButton6 = new Sunny.UI.UISymbolButton();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uiSymbolButton7 = new Sunny.UI.UISymbolButton();
            this.uiTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // backWorker
            // 
            this.backWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backWorker_DoWork);
            // 
            // uiTabControl1
            // 
            this.uiTabControl1.Controls.Add(this.tabPage1);
            this.uiTabControl1.Controls.Add(this.tabPage2);
            this.uiTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControl1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.ItemSize = new System.Drawing.Size(150, 40);
            this.uiTabControl1.Location = new System.Drawing.Point(3, 38);
            this.uiTabControl1.MainPage = "";
            this.uiTabControl1.Name = "uiTabControl1";
            this.uiTabControl1.SelectedIndex = 0;
            this.uiTabControl1.Size = new System.Drawing.Size(794, 573);
            this.uiTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControl1.TabIndex = 0;
            this.uiTabControl1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uiTabControl1_MouseDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.message);
            this.tabPage1.Controls.Add(this.uiSymbolButton5);
            this.tabPage1.Controls.Add(this.uiSymbolButton4);
            this.tabPage1.Controls.Add(this.uiLabel4);
            this.tabPage1.Controls.Add(this.uiColorPicker1);
            this.tabPage1.Controls.Add(this.uiLine5);
            this.tabPage1.Controls.Add(this.uiRadioButtonGroup1);
            this.tabPage1.Controls.Add(this.uiLine4);
            this.tabPage1.Controls.Add(this.uiSymbolButton3);
            this.tabPage1.Controls.Add(this.uiComboBox1);
            this.tabPage1.Controls.Add(this.uiLine3);
            this.tabPage1.Controls.Add(this.uiTextBox3);
            this.tabPage1.Controls.Add(this.uiLabel3);
            this.tabPage1.Controls.Add(this.uiTextBox2);
            this.tabPage1.Controls.Add(this.uiLabel2);
            this.tabPage1.Controls.Add(this.uiLine2);
            this.tabPage1.Controls.Add(this.uiLabel1);
            this.tabPage1.Controls.Add(this.uiSymbolButton2);
            this.tabPage1.Controls.Add(this.uiTextBox1);
            this.tabPage1.Controls.Add(this.uiSymbolButton1);
            this.tabPage1.Controls.Add(this.uiComboDataGridView1);
            this.tabPage1.Controls.Add(this.uiLine1);
            this.tabPage1.Location = new System.Drawing.Point(0, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(794, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "项目编辑";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 26;
            // 
            // message
            // 
            this.message.Cursor = System.Windows.Forms.Cursors.Hand;
            this.message.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.message.Location = new System.Drawing.Point(473, 415);
            this.message.MinimumSize = new System.Drawing.Size(1, 1);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(308, 105);
            this.message.TabIndex = 25;
            this.message.TipsFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.message.Visible = false;
            this.message.Click += new System.EventHandler(this.message_Click);
            // 
            // uiSymbolButton5
            // 
            this.uiSymbolButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton5.Location = new System.Drawing.Point(225, 485);
            this.uiSymbolButton5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton5.Name = "uiSymbolButton5";
            this.uiSymbolButton5.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton5.Symbol = 61442;
            this.uiSymbolButton5.TabIndex = 24;
            this.uiSymbolButton5.Text = "预览";
            this.uiSymbolButton5.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton5.Click += new System.EventHandler(this.uiSymbolButton5_Click);
            // 
            // uiSymbolButton4
            // 
            this.uiSymbolButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiSymbolButton4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiSymbolButton4.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.uiSymbolButton4.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.uiSymbolButton4.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.uiSymbolButton4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton4.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.uiSymbolButton4.Location = new System.Drawing.Point(13, 485);
            this.uiSymbolButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton4.Name = "uiSymbolButton4";
            this.uiSymbolButton4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiSymbolButton4.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.uiSymbolButton4.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.uiSymbolButton4.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.uiSymbolButton4.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton4.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton4.Symbol = 61639;
            this.uiSymbolButton4.TabIndex = 23;
            this.uiSymbolButton4.Text = "保存";
            this.uiSymbolButton4.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton4.Click += new System.EventHandler(this.uiSymbolButton4_Click);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(10, 459);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(244, 23);
            this.uiLabel4.TabIndex = 22;
            this.uiLabel4.Text = "上一次修改时间：";
            // 
            // uiColorPicker1
            // 
            this.uiColorPicker1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uiColorPicker1.FillColor = System.Drawing.Color.White;
            this.uiColorPicker1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiColorPicker1.Location = new System.Drawing.Point(206, 398);
            this.uiColorPicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiColorPicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiColorPicker1.Name = "uiColorPicker1";
            this.uiColorPicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiColorPicker1.Size = new System.Drawing.Size(150, 29);
            this.uiColorPicker1.SymbolSize = 24;
            this.uiColorPicker1.TabIndex = 21;
            this.uiColorPicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiColorPicker1.Watermark = "";
            this.uiColorPicker1.ValueChanged += new Sunny.UI.UIColorPicker.OnColorChanged(this.uiColorPicker1_ValueChanged);
            // 
            // uiLine5
            // 
            this.uiLine5.BackColor = System.Drawing.Color.Transparent;
            this.uiLine5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine5.Location = new System.Drawing.Point(203, 364);
            this.uiLine5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine5.Name = "uiLine5";
            this.uiLine5.Size = new System.Drawing.Size(153, 26);
            this.uiLine5.TabIndex = 19;
            this.uiLine5.Text = "背景颜色";
            // 
            // uiRadioButtonGroup1
            // 
            this.uiRadioButtonGroup1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiRadioButtonGroup1.Items.AddRange(new object[] {
            "下方",
            "右边"});
            this.uiRadioButtonGroup1.Location = new System.Drawing.Point(13, 357);
            this.uiRadioButtonGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup1.Name = "uiRadioButtonGroup1";
            this.uiRadioButtonGroup1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup1.Size = new System.Drawing.Size(150, 97);
            this.uiRadioButtonGroup1.TabIndex = 18;
            this.uiRadioButtonGroup1.Text = "视频/图片位置";
            this.uiRadioButtonGroup1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiRadioButtonGroup1.ValueChanged += new Sunny.UI.UIRadioButtonGroup.OnValueChanged(this.uiRadioButtonGroup1_ValueChanged);
            // 
            // uiLine4
            // 
            this.uiLine4.BackColor = System.Drawing.Color.Transparent;
            this.uiLine4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine4.Location = new System.Drawing.Point(11, 329);
            this.uiLine4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine4.Name = "uiLine4";
            this.uiLine4.Size = new System.Drawing.Size(770, 29);
            this.uiLine4.TabIndex = 16;
            this.uiLine4.Text = "外观";
            // 
            // uiSymbolButton3
            // 
            this.uiSymbolButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton3.Enabled = false;
            this.uiSymbolButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton3.Location = new System.Drawing.Point(179, 292);
            this.uiSymbolButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton3.Name = "uiSymbolButton3";
            this.uiSymbolButton3.Size = new System.Drawing.Size(100, 29);
            this.uiSymbolButton3.Symbol = 61716;
            this.uiSymbolButton3.TabIndex = 15;
            this.uiSymbolButton3.Text = "选择文件";
            this.uiSymbolButton3.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton3.Click += new System.EventHandler(this.uiSymbolButton3_Click);
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiComboBox1.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiComboBox1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboBox1.Location = new System.Drawing.Point(13, 292);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(150, 29);
            this.uiComboBox1.SymbolSize = 24;
            this.uiComboBox1.TabIndex = 14;
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox1.Watermark = "";
            this.uiComboBox1.SelectedIndexChanged += new System.EventHandler(this.uiComboBox1_SelectedIndexChanged);
            // 
            // uiLine3
            // 
            this.uiLine3.BackColor = System.Drawing.Color.Transparent;
            this.uiLine3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine3.Location = new System.Drawing.Point(12, 255);
            this.uiLine3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine3.Name = "uiLine3";
            this.uiLine3.Size = new System.Drawing.Size(769, 29);
            this.uiLine3.TabIndex = 13;
            this.uiLine3.Text = "多媒体";
            // 
            // uiTextBox3
            // 
            this.uiTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox3.Location = new System.Drawing.Point(89, 147);
            this.uiTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox3.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox3.Multiline = true;
            this.uiTextBox3.Name = "uiTextBox3";
            this.uiTextBox3.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox3.ShowText = false;
            this.uiTextBox3.Size = new System.Drawing.Size(356, 100);
            this.uiTextBox3.TabIndex = 12;
            this.uiTextBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox3.Watermark = "例如：每人合唱《让我们荡起双桨》";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(9, 142);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 11;
            this.uiLabel3.Text = "详细介绍";
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox2.Location = new System.Drawing.Point(206, 113);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox2.ShowText = false;
            this.uiTextBox2.Size = new System.Drawing.Size(192, 29);
            this.uiTextBox2.TabIndex = 10;
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox2.Watermark = "例如：唱歌";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(8, 119);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(195, 23);
            this.uiLabel2.TabIndex = 9;
            this.uiLabel2.Text = "简介（尽量少于8个字符）";
            // 
            // uiLine2
            // 
            this.uiLine2.BackColor = System.Drawing.Color.Transparent;
            this.uiLine2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine2.Location = new System.Drawing.Point(12, 87);
            this.uiLine2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(769, 29);
            this.uiLine2.TabIndex = 8;
            this.uiLine2.Text = "文本";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(644, 59);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(51, 22);
            this.uiLabel1.TabIndex = 7;
            this.uiLabel1.Text = ".json";
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton2.IsCircle = true;
            this.uiSymbolButton2.Location = new System.Drawing.Point(701, 52);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Size = new System.Drawing.Size(35, 29);
            this.uiSymbolButton2.Symbol = 61543;
            this.uiSymbolButton2.TabIndex = 6;
            this.uiSymbolButton2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton2.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(336, 52);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(301, 29);
            this.uiTextBox1.TabIndex = 5;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "新的文件名";
            this.uiTextBox1.TextChanged += new System.EventHandler(this.uiTextBox1_TextChanged);
            this.uiTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uiTextBox1_KeyDown);
            this.uiTextBox1.Leave += new System.EventHandler(this.uiTextBox1_Leave);
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiSymbolButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiSymbolButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.uiSymbolButton1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.uiSymbolButton1.Location = new System.Drawing.Point(119, 485);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiSymbolButton1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.uiSymbolButton1.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton1.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton1.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.Symbol = 61460;
            this.uiSymbolButton1.TabIndex = 4;
            this.uiSymbolButton1.Text = "删除";
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiComboDataGridView1
            // 
            this.uiComboDataGridView1.DataSource = null;
            this.uiComboDataGridView1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.uiComboDataGridView1.FillColor = System.Drawing.Color.White;
            this.uiComboDataGridView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiComboDataGridView1.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.uiComboDataGridView1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboDataGridView1.Location = new System.Drawing.Point(12, 52);
            this.uiComboDataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboDataGridView1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboDataGridView1.Name = "uiComboDataGridView1";
            this.uiComboDataGridView1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboDataGridView1.Size = new System.Drawing.Size(276, 29);
            this.uiComboDataGridView1.SymbolSize = 24;
            this.uiComboDataGridView1.TabIndex = 3;
            this.uiComboDataGridView1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboDataGridView1.Watermark = "项目资源";
            this.uiComboDataGridView1.SelectedIndexChanged += new System.EventHandler(this.uiComboDataGridView1_SelectedIndexChanged);
            this.uiComboDataGridView1.RectColorChanged += new System.EventHandler(this.uiComboDataGridView1_RectColorChanged);
            // 
            // uiLine1
            // 
            this.uiLine1.BackColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLine1.Location = new System.Drawing.Point(12, 15);
            this.uiLine1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(769, 29);
            this.uiLine1.TabIndex = 2;
            this.uiLine1.Text = "选择项目";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uiSymbolButton7);
            this.tabPage2.Controls.Add(this.uiSymbolButton6);
            this.tabPage2.Controls.Add(this.uiDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(0, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(794, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "项目启用";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // CopyWorker
            // 
            this.CopyWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CopyWorker_DoWork);
            this.CopyWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CopyWorker_RunWorkerCompleted);
            // 
            // fontDialog
            // 
            this.fontDialog.Apply += new System.EventHandler(this.fontDialog_Apply);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SaveWorker
            // 
            this.SaveWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SaveWorker_DoWork);
            // 
            // messagetimer
            // 
            this.messagetimer.Interval = 3000;
            this.messagetimer.Tick += new System.EventHandler(this.messagetimer_Tick);
            // 
            // uiDataGridView
            // 
            this.uiDataGridView.AllowUserToAddRows = false;
            this.uiDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.uiDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uiDataGridView.ColumnHeadersHeight = 32;
            this.uiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.enable});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.uiDataGridView.EnableHeadersVisualStyles = false;
            this.uiDataGridView.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView.Location = new System.Drawing.Point(0, 40);
            this.uiDataGridView.Name = "uiDataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.uiDataGridView.RowTemplate.Height = 23;
            this.uiDataGridView.SelectedIndex = -1;
            this.uiDataGridView.Size = new System.Drawing.Size(794, 494);
            this.uiDataGridView.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView.TabIndex = 0;
            // 
            // uiSymbolButton6
            // 
            this.uiSymbolButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton6.Location = new System.Drawing.Point(3, 3);
            this.uiSymbolButton6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton6.Name = "uiSymbolButton6";
            this.uiSymbolButton6.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton6.Symbol = 61473;
            this.uiSymbolButton6.TabIndex = 1;
            this.uiSymbolButton6.Text = "刷新";
            this.uiSymbolButton6.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton6.Click += new System.EventHandler(this.uiSymbolButton6_Click);
            // 
            // name
            // 
            this.name.HeaderText = "项目";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 650;
            // 
            // enable
            // 
            this.enable.HeaderText = "启用";
            this.enable.Name = "enable";
            // 
            // uiSymbolButton7
            // 
            this.uiSymbolButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiSymbolButton7.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiSymbolButton7.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.uiSymbolButton7.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.uiSymbolButton7.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.uiSymbolButton7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton7.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(251)))), ((int)(((byte)(241)))));
            this.uiSymbolButton7.Location = new System.Drawing.Point(109, 3);
            this.uiSymbolButton7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton7.Name = "uiSymbolButton7";
            this.uiSymbolButton7.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.uiSymbolButton7.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(203)))), ((int)(((byte)(83)))));
            this.uiSymbolButton7.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.uiSymbolButton7.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(152)))), ((int)(((byte)(32)))));
            this.uiSymbolButton7.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton7.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton7.Symbol = 61639;
            this.uiSymbolButton7.TabIndex = 2;
            this.uiSymbolButton7.Text = "保存";
            this.uiSymbolButton7.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton7.Click += new System.EventHandler(this.uiSymbolButton7_Click);
            // 
            // ArchivesForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.uiTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArchivesForm";
            this.Text = "档案编辑";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Deactivate += new System.EventHandler(this.ArchivesForm_Deactivate);
            this.Load += new System.EventHandler(this.ArchivesForm_Load);
            this.uiTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backWorker;
        private Sunny.UI.UITabControl uiTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UIComboBox uiComboDataGridView1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UITextBox uiTextBox3;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILine uiLine3;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.ComponentModel.BackgroundWorker CopyWorker;
        private Sunny.UI.UILine uiLine4;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup1;
        private Sunny.UI.UIColorPicker uiColorPicker1;
        private Sunny.UI.UILine uiLine5;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Timer timer1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UISymbolButton uiSymbolButton4;
        private System.ComponentModel.BackgroundWorker SaveWorker;
        private Sunny.UI.UISymbolButton uiSymbolButton5;
        private Sunny.UI.UIButton message;
        private System.Windows.Forms.Timer messagetimer;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UISymbolButton uiSymbolButton6;
        private Sunny.UI.UIDataGridView uiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enable;
        private Sunny.UI.UISymbolButton uiSymbolButton7;
    }
}