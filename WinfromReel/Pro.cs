using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SteelDAL;
using SteelModel;
namespace WinfromReel
{
    public partial class Pro : Form
    {
        public Pro()
        {
            InitializeComponent();
        }
        ProDal dal = new ProDal();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //dataGridView1.DataSource = dal.Show();
            //dataGridView1.Name = "ProName";
            //dataGridView1.DataBindings = "ProId";
            //dataGridView1.Rows = "";

        }
        public void BindShow()
        {
            //dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = dal.Show();
            //dataGridView1.Name = "ProName";
            //dataGridView1.SelectionChanged = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BindShow();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = null;
            //ProModel m = new ProModel();
            var proname = textBox1.Text;
            //            textBox1.Text = proname;
            List<ProModel> list = dal.GetPro(proname);
            if (!string.IsNullOrEmpty(proname))
            {
                list = list.Where(s => s.ProName.Contains(proname)).ToList();
            }
            dataGridView1.DataSource = list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProAdd f2 = new ProAdd();
            //f2.Tag = dal.Add(m);
            f2._rep += BindShow;
            f2.ShowDialog();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("是否确认删除", "删除", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].EditedFormattedValue.ToString());
                    int i = dal.Del(id);
                    if (i > 0)
                    {
                        MessageBox.Show("操作成功");
                        BindShow();
                    }
                }
            }
            else
            {
                MessageBox.Show("至少选择一行");
                return;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ProUpt f3 = new ProUpt();
                f3.Tag = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].EditedFormattedValue.ToString());
                f3._pro += BindShow;
                f3.ShowDialog();
            }
            else
            {
                MessageBox.Show("请至少选中一行");
                return;
            }
        }
    }
}
