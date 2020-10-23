namespace WinfromReel
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("机器设备");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("原材料采购");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("原材料");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("成品");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("仓库", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("销售订单");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("职员管理");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("钢板配送");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("钢板切割系统", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.steelMaterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.steelprocessingDataSet = new WinfromReel.SteelprocessingDataSet();
            this.Add = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.原材料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.邮箱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.微信公众号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.企业采购ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.机器设备ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.原材料采购ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.职员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.钢板配送ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.仓库ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.原材料ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.成品ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.钢板切割系统AppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.steelMaterTableAdapter = new WinfromReel.SteelprocessingDataSetTableAdapters.SteelMaterTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.steelMaterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelprocessingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Location = new System.Drawing.Point(148, 93);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 508);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.BackgroundImage = global::WinfromReel.Properties.Resources._85764633565f5b2cfd0aec892932ac60_1155116455259073_b;
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.Add);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(803, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "原材料";
            this.tabPage1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabPage1_MouseDown);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.steelMaterBindingSource;
            this.comboBox1.DisplayMember = "SteelMaterials";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "SteelMaterials";
            // 
            // steelMaterBindingSource
            // 
            this.steelMaterBindingSource.DataMember = "SteelMater";
            this.steelMaterBindingSource.DataSource = this.steelprocessingDataSet;
            // 
            // steelprocessingDataSet
            // 
            this.steelprocessingDataSet.DataSetName = "SteelprocessingDataSet";
            this.steelprocessingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.Cursor = System.Windows.Forms.Cursors.Default;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Add.Location = new System.Drawing.Point(569, 51);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "进货";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView2.Location = new System.Drawing.Point(60, 101);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(645, 317);
            this.dataGridView2.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SId";
            this.Column1.HeaderText = "仓库编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SteelMaterials";
            this.Column2.HeaderText = "原材料名称";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SteelRole";
            this.Column3.HeaderText = "原材料规格";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SteelCount";
            this.Column4.HeaderText = "材料数量";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "measureUnit";
            this.Column5.HeaderText = "材料单位";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "PeopleSteel";
            this.Column6.HeaderText = "负责人";
            this.Column6.Name = "Column6";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(258, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "成品";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(649, 363);
            this.dataGridView1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.仓库ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // 仓库ToolStripMenuItem
            // 
            this.仓库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.原材料ToolStripMenuItem,
            this.成品ToolStripMenuItem});
            this.仓库ToolStripMenuItem.Name = "仓库ToolStripMenuItem";
            this.仓库ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.仓库ToolStripMenuItem.Text = "仓库";
            // 
            // 原材料ToolStripMenuItem
            // 
            this.原材料ToolStripMenuItem.Name = "原材料ToolStripMenuItem";
            this.原材料ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.原材料ToolStripMenuItem.Text = "原材料";
            // 
            // 成品ToolStripMenuItem
            // 
            this.成品ToolStripMenuItem.Name = "成品ToolStripMenuItem";
            this.成品ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.成品ToolStripMenuItem.Text = "成品";
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.BackColor = System.Drawing.Color.Silver;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.ForeColor = System.Drawing.Color.Red;
            this.treeView1.HotTracking = true;
            this.treeView1.LineColor = System.Drawing.Color.Red;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(20);
            this.treeView1.Name = "treeView1";
            treeNode10.Name = "节点1";
            treeNode10.Text = "机器设备";
            treeNode11.Name = "节点2";
            treeNode11.Text = "原材料采购";
            treeNode12.Name = "节点7";
            treeNode12.Text = "原材料";
            treeNode13.Name = "成品";
            treeNode13.Text = "成品";
            treeNode14.Name = "节点3";
            treeNode14.Text = "仓库";
            treeNode15.Name = "节点4";
            treeNode15.Text = "销售订单";
            treeNode16.Name = "节点5";
            treeNode16.Text = "职员管理";
            treeNode17.Name = "节点6";
            treeNode17.Text = "钢板配送";
            treeNode18.Name = "TELL";
            treeNode18.Text = "钢板切割系统";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18});
            this.treeView1.ShowNodeToolTips = true;
            this.treeView1.Size = new System.Drawing.Size(121, 601);
            this.treeView1.TabIndex = 1;
            this.treeView1.Visible = false;
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(142, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "欢迎登陆系统：";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Lime;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Blue;
            this.textBox1.Location = new System.Drawing.Point(121, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(871, 14);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||" +
    "|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aqua;
            this.menuStrip1.BackgroundImage = global::WinfromReel.Properties.Resources.LACP_Y5XZOCSHRF9ZMC_K_K;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.邮箱ToolStripMenuItem,
            this.微信公众号ToolStripMenuItem,
            this.企业采购ToolStripMenuItem,
            this.机器设备ToolStripMenuItem,
            this.销售订单ToolStripMenuItem,
            this.原材料采购ToolStripMenuItem,
            this.职员管理ToolStripMenuItem,
            this.钢板配送ToolStripMenuItem,
            this.仓库ToolStripMenuItem1,
            this.钢板切割系统AppToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(121, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 邮箱ToolStripMenuItem
            // 
            this.邮箱ToolStripMenuItem.Name = "邮箱ToolStripMenuItem";
            this.邮箱ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.邮箱ToolStripMenuItem.Text = "邮箱";
            // 
            // 微信公众号ToolStripMenuItem
            // 
            this.微信公众号ToolStripMenuItem.Name = "微信公众号ToolStripMenuItem";
            this.微信公众号ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.微信公众号ToolStripMenuItem.Text = "微信公众号";
            // 
            // 企业采购ToolStripMenuItem
            // 
            this.企业采购ToolStripMenuItem.Name = "企业采购ToolStripMenuItem";
            this.企业采购ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.企业采购ToolStripMenuItem.Text = "企业采购";
            // 
            // 机器设备ToolStripMenuItem
            // 
            this.机器设备ToolStripMenuItem.Name = "机器设备ToolStripMenuItem";
            this.机器设备ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.机器设备ToolStripMenuItem.Text = "机器设备";
            // 
            // 销售订单ToolStripMenuItem
            // 
            this.销售订单ToolStripMenuItem.Name = "销售订单ToolStripMenuItem";
            this.销售订单ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.销售订单ToolStripMenuItem.Text = "销售订单";
            // 
            // 原材料采购ToolStripMenuItem
            // 
            this.原材料采购ToolStripMenuItem.Name = "原材料采购ToolStripMenuItem";
            this.原材料采购ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.原材料采购ToolStripMenuItem.Text = "原材料采购";
            // 
            // 职员管理ToolStripMenuItem
            // 
            this.职员管理ToolStripMenuItem.Name = "职员管理ToolStripMenuItem";
            this.职员管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.职员管理ToolStripMenuItem.Text = "职员管理";
            // 
            // 钢板配送ToolStripMenuItem
            // 
            this.钢板配送ToolStripMenuItem.Name = "钢板配送ToolStripMenuItem";
            this.钢板配送ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.钢板配送ToolStripMenuItem.Text = "钢板配送";
            // 
            // 仓库ToolStripMenuItem1
            // 
            this.仓库ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.原材料ToolStripMenuItem1,
            this.成品ToolStripMenuItem1});
            this.仓库ToolStripMenuItem1.Name = "仓库ToolStripMenuItem1";
            this.仓库ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.仓库ToolStripMenuItem1.Text = "仓库";
            // 
            // 原材料ToolStripMenuItem1
            // 
            this.原材料ToolStripMenuItem1.Name = "原材料ToolStripMenuItem1";
            this.原材料ToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.原材料ToolStripMenuItem1.Text = "原材料";
            // 
            // 成品ToolStripMenuItem1
            // 
            this.成品ToolStripMenuItem1.Name = "成品ToolStripMenuItem1";
            this.成品ToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.成品ToolStripMenuItem1.Text = "成品";
            // 
            // 钢板切割系统AppToolStripMenuItem
            // 
            this.钢板切割系统AppToolStripMenuItem.Name = "钢板切割系统AppToolStripMenuItem";
            this.钢板切割系统AppToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.钢板切割系统AppToolStripMenuItem.Text = "钢板切割系统App";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(36, 21);
            this.toolStripMenuItem1.Text = "✖";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(882, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "▼";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // steelMaterTableAdapter
            // 
            this.steelMaterTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = global::WinfromReel.Properties.Resources._85764633565f5b2cfd0aec892932ac60_1155116455259073_b;
            this.ClientSize = new System.Drawing.Size(992, 601);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.Red;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.steelMaterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.steelprocessingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Button Add;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仓库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 原材料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成品ToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 邮箱ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 微信公众号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 企业采购ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 机器设备ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 原材料采购ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 职员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 钢板配送ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 仓库ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 原材料ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 成品ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 钢板切割系统AppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private SteelprocessingDataSet steelprocessingDataSet;
        private System.Windows.Forms.BindingSource steelMaterBindingSource;
        private SteelprocessingDataSetTableAdapters.SteelMaterTableAdapter steelMaterTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
    }
}

