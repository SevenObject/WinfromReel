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
using SteelDAL;

namespace WinfromReel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SteelMaterDAL dal = new SteelMaterDAL();
        
        SendInfoFristShow SendInfoFristShow = new SendInfoFristShow();
        string Connecttions = "Data Source=.;Initial Catalog=Steelprocessing;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“steelprocessingDataSet.SteelMater”中。您可以根据需要移动或删除它。
            this.steelMaterTableAdapter.Fill(this.steelprocessingDataSet.SteelMater);

            TreePic();
            Show();
            ListXiaLa();
            BagroundColor();                          
        }
        public void TreePic()
        {
            treeView1.Show();
            
        }
        /// <summary>
        /// 用来设置背景色以及基础控件
        /// </summary>
        public  void BagroundColor()
        {
            label1.BackColor = Color.Transparent;
            label2.Visible = false;
            tabControl1.Visible = false;
            menuStrip1.Visible = true;
            treeView1.ExpandAll();
            
        }
        //显示
        public new void Show()
        {
            string sql = "select * from SteelMater ";
            SqlConnection connection = new SqlConnection(Connecttions);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds, "HospitalEquipment");
            connection.Close();
            DataTable dt = ds.Tables["HospitalEquipment"];
            dataGridView2.DataSource = dt;
            dataGridView1.DataSource = dt;
        }
        //显示下拉框
        public  void ListXiaLa()
        {
            string sql = " select SteelMaterials from SteelMater ";
            SqlConnection connection = new SqlConnection(Connecttions);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataAdapter sds = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sds.Fill(ds, "HospitalEquipment");
            connection.Close();
            DataTable data = ds.Tables["HospitalEquipment"];
            comboBox1.DataSource = data;
            comboBox1.DataSource = data;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            AddSteelMater addSteel = new AddSteelMater();
            addSteel.ShowSteels += Show;
            addSteel.ShowDialog();
        }


        private void tabPage1_MouseDown(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Show();
        }


        private void treeView1_Click(object sender, EventArgs e)
        {
            TreeNode tree = new TreeNode();
            if(treeView1.SelectedNode.Text=="原材料")
            {
                tabControl1.Visible = true;
            }
            if (treeView1.SelectedNode.Text == "钢板配送")
            {
                Form1 form1 = new Form1();
                form1.Close();
                SendInfoFristShow.ShowDialog();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
                menuStrip1.Visible = false;
                label2.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = true;
            label2.Visible = false;
        }


        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("确认要删除吗?", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {

                int id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].EditedFormattedValue.ToString());
                int n = dal.Delete(id);
                if (n > 0)
                {
                    
                    Show();
                }

            }
        }
    }
}
