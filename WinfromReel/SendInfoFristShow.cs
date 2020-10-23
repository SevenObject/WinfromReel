using SteelDAL;
using SteelModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinfromReel
{
    public partial class SendInfoFristShow : Form
    {
        public SendInfoFristShow()
        {
            InitializeComponent();
        }
        SendInfoDAL dal = new SendInfoDAL();
        private void SendInfoFristShow_Load(object sender, EventArgs e)
        {
            TreePic();
            BindList();
        }
        public void TreePic()
        {
            treeView1.Show();

        }
        public void BindList()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = dal.GetSendInfos();
        }
        //添加
        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddSendForm fa = new AddSendForm();
            fa._ReShow += BindList;
            fa.ShowDialog();
        }
        //查询
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            List<SendInfo> list = dal.GetSendInfos();
            string key = txt_Key.Text;
            if (!string.IsNullOrEmpty(key))
            {
                list = list.Where(s => s.PCode.Contains(key) || s.PName.Contains(key) || s.Driver.Contains(key)).ToList();
            }
            dataGridView1.DataSource = list;
        }
        //修改
        private void btn_Upd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                UpdSendForm upd = new UpdSendForm();
                upd.Tag = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].EditedFormattedValue.ToString());
                upd._ReList += BindList;
                upd.ShowDialog();
            }
            else
            {
                MessageBox.Show("请至少选中一行");
                return;
            }
        }
        /// <summary>
        ///删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn__Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("请确认信息", "删除", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].EditedFormattedValue.ToString());
                    int i = dal.DelInfo(id);
                    if (i > 0)
                    {
                        MessageBox.Show("操作成功");
                        BindList();
                    }
                }

            }
            else
            {
                MessageBox.Show("请至少选中一行");
                return;
            }
        }
    }
}
