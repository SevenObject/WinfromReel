namespace WinfromReel
{
    partial class SendInfoFristShow
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Driver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeView1 = new System.Windows.Forms.TreeView();
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Key = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Upd = new System.Windows.Forms.Button();
            this.btn_ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PName,
            this.Type,
            this.Num,
            this.Driver,
            this.Statu,
            this.Phone,
            this.Address,
            this.PCode});
            this.dataGridView1.Location = new System.Drawing.Point(184, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(796, 307);
            this.dataGridView1.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 41.2662F;
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // PName
            // 
            this.PName.DataPropertyName = "PName";
            this.PName.FillWeight = 103.8904F;
            this.PName.HeaderText = "产品名称";
            this.PName.Name = "PName";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.FillWeight = 103.8904F;
            this.Type.HeaderText = "规格";
            this.Type.Name = "Type";
            // 
            // Num
            // 
            this.Num.DataPropertyName = "Num";
            this.Num.FillWeight = 44.4451F;
            this.Num.HeaderText = "数量";
            this.Num.Name = "Num";
            // 
            // Driver
            // 
            this.Driver.DataPropertyName = "Driver";
            this.Driver.FillWeight = 103.8904F;
            this.Driver.HeaderText = "配送司机";
            this.Driver.Name = "Driver";
            // 
            // Statu
            // 
            this.Statu.DataPropertyName = "Statu";
            this.Statu.FillWeight = 103.8904F;
            this.Statu.HeaderText = "配送状态";
            this.Statu.Name = "Statu";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.FillWeight = 103.8904F;
            this.Phone.HeaderText = "电话";
            this.Phone.Name = "Phone";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 103.8904F;
            this.Address.HeaderText = "收货地址";
            this.Address.Name = "Address";
            // 
            // PCode
            // 
            this.PCode.DataPropertyName = "PCode";
            this.PCode.FillWeight = 103.8904F;
            this.PCode.HeaderText = "配送编码";
            this.PCode.Name = "PCode";
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
            this.treeView1.Size = new System.Drawing.Size(121, 606);
            this.treeView1.TabIndex = 2;
            this.treeView1.Visible = false;
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
            this.menuStrip1.TabIndex = 5;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(466, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "配送单信息";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(210, 180);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "新增配送单";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // txt_Key
            // 
            this.txt_Key.Location = new System.Drawing.Point(454, 180);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.Size = new System.Drawing.Size(100, 21);
            this.txt_Key.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "关键字查询";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Upd
            // 
            this.btn_Upd.Location = new System.Drawing.Point(736, 173);
            this.btn_Upd.Name = "btn_Upd";
            this.btn_Upd.Size = new System.Drawing.Size(75, 23);
            this.btn_Upd.TabIndex = 10;
            this.btn_Upd.Text = "编辑";
            this.btn_Upd.UseVisualStyleBackColor = true;
            // 
            // btn_
            // 
            this.btn_.Location = new System.Drawing.Point(874, 173);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(75, 23);
            this.btn_.TabIndex = 9;
            this.btn_.Text = "删除";
            this.btn_.UseVisualStyleBackColor = true;
            // 
            // SendInfoFristShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinfromReel.Properties.Resources._85764633565f5b2cfd0aec892932ac60_1155116455259073_b;
            this.ClientSize = new System.Drawing.Size(992, 606);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Upd);
            this.Controls.Add(this.btn_);
            this.Controls.Add(this.txt_Key);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SendInfoFristShow";
            this.Text = "SendInfoFristShow";
            this.Load += new System.EventHandler(this.SendInfoFristShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Driver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Statu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCode;
        private System.Windows.Forms.TreeView treeView1;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Key;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Upd;
        private System.Windows.Forms.Button btn_;
    }
}