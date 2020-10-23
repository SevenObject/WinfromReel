using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinfromReel
{
    public partial class liyonghao : Form
    {
        public liyonghao()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            //获取数据库连接
            liyonghaoDataBase db = new liyonghaoDataBase();
            SqlConnection conn = db.getConn();
            //打开连接
            conn.Open();
            //定义sql语句
            String sql = "select * from wins ORDER BY bc asc,bcsj asc";
            if (textBox1.Text == "")
            {
                sql = "select * from wins ORDER BY bc asc,bcsj asc";
            }
            else
            {
                sql += " where names like '%" + textBox1.Text + "%'";

            }




            //创建sql执行对象
            SqlCommand comm = new SqlCommand(sql, conn);
            //创建数据适配器
            SqlDataAdapter sda = new SqlDataAdapter();
            //执行sql语句
            sda.SelectCommand = comm;
            //创建数据集
            DataSet ds = new DataSet();
            //将对应test表数据保存到数据集合中
            sda.Fill(ds, "wins");
            //把数据集合中第一个表的数据填充到dataGirdView中
            dataGridView1.DataSource = ds.Tables[0];
            //关闭连接
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            liyonghaoadd ad = new liyonghaoadd();
            ad.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            liyonghaoDataBase db = new liyonghaoDataBase();
            SqlConnection conn = db.getConn();
            conn.Open();
            int rowindex = dataGridView1.CurrentRow.Index;
            String value0 = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            String value1 = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            String value2 = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
            String value3 = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            String value4 = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();
            String value5 = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();
            String sql = "update wins set names='" + value1 + "',BH='" + value2 + "',shlj='" + value1 + "',bc='" + value1 + "',bcsj='" + value1 + "' where id='" + value0 + "'";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("修改成功！");
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            liyonghaoDataBase db = new liyonghaoDataBase();
            SqlConnection conn = db.getConn();
            conn.Open();
            int rowindex = dataGridView1.CurrentRow.Index;
            String value0 = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            String sql = "delete from wins where id='" + value0 + "'";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("删除成功！");
            conn.Close();

        }
    }
}
