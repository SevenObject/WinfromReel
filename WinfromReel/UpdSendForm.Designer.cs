namespace WinfromReel
{
    partial class UpdSendForm
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
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.txt_PCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_Statu = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_Address = new System.Windows.Forms.TextBox();
            this.cbb_PName = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Driver = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Num
            // 
            this.txt_Num.Location = new System.Drawing.Point(150, 199);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(100, 21);
            this.txt_Num.TabIndex = 51;
            // 
            // txt_PCode
            // 
            this.txt_PCode.Location = new System.Drawing.Point(150, 43);
            this.txt_PCode.Name = "txt_PCode";
            this.txt_PCode.ReadOnly = true;
            this.txt_PCode.Size = new System.Drawing.Size(100, 21);
            this.txt_PCode.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 49;
            this.label8.Text = "配送编码";
            // 
            // cbb_Statu
            // 
            this.cbb_Statu.FormattingEnabled = true;
            this.cbb_Statu.Items.AddRange(new object[] {
            "未配送",
            "配送中",
            "已配送",
            "配送异常"});
            this.cbb_Statu.Location = new System.Drawing.Point(150, 395);
            this.cbb_Statu.Name = "cbb_Statu";
            this.cbb_Statu.Size = new System.Drawing.Size(121, 20);
            this.cbb_Statu.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 47;
            this.label7.Text = "配送状态";
            // 
            // cbb_Address
            // 
            this.cbb_Address.Location = new System.Drawing.Point(150, 252);
            this.cbb_Address.Name = "cbb_Address";
            this.cbb_Address.Size = new System.Drawing.Size(100, 21);
            this.cbb_Address.TabIndex = 46;
            // 
            // cbb_PName
            // 
            this.cbb_PName.FormattingEnabled = true;
            this.cbb_PName.Items.AddRange(new object[] {
            "圆形钢材",
            "矩形钢材",
            "球形钢材",
            "柱形钢材"});
            this.cbb_PName.Location = new System.Drawing.Point(150, 95);
            this.cbb_PName.Name = "cbb_PName";
            this.cbb_PName.Size = new System.Drawing.Size(121, 20);
            this.cbb_PName.TabIndex = 45;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(111, 447);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 44;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(150, 352);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(100, 21);
            this.txt_Phone.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 42;
            this.label6.Text = "电话";
            // 
            // txt_Driver
            // 
            this.txt_Driver.Location = new System.Drawing.Point(150, 303);
            this.txt_Driver.Name = "txt_Driver";
            this.txt_Driver.Size = new System.Drawing.Size(100, 21);
            this.txt_Driver.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 40;
            this.label5.Text = "司机";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 39;
            this.label4.Text = "地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 38;
            this.label3.Text = "数量";
            // 
            // txt_Type
            // 
            this.txt_Type.Location = new System.Drawing.Point(150, 145);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(100, 21);
            this.txt_Type.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 36;
            this.label2.Text = "规格";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 35;
            this.label1.Text = "产品名称";
            // 
            // UpdSendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 515);
            this.Controls.Add(this.txt_Num);
            this.Controls.Add(this.txt_PCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbb_Statu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbb_Address);
            this.Controls.Add(this.cbb_PName);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Driver);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdSendForm";
            this.Text = "UpdSendForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.TextBox txt_PCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_Statu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cbb_Address;
        private System.Windows.Forms.ComboBox cbb_PName;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Driver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}