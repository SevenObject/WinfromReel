using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SteelModel;
using System.Data.SqlClient;
using SteelDAL;
namespace WinfromReel
{
    public partial class AddSteelMater : Form
    {
        SteelMaterDAL dal = new SteelMaterDAL();
        Form1 Form1 = new Form1();
        //声明一个委托
        public delegate void ShowSteel();
        public event ShowSteel ShowSteels;
        public AddSteelMater()
        {
            InitializeComponent();
        }
        private void AddSteelMater_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“steelprocessingDataSet1.SteelMater”中。您可以根据需要移动或删除它。
            this.steelMaterTableAdapter.Fill(this.steelprocessingDataSet1.SteelMater);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string SteelMaterials = textBox1.Text;
            string StrrlRole = textBox2.Text;
            int SteelCount = Convert.ToInt32(textBox3.Text);
            string MeasureUnit = comboBox1.Text;
            string PeopleSteel = comboBox2.Text;
            SteelMater steels = new SteelMater();
            steels.SteelMaterials = SteelMaterials;
            steels.SteelRole = StrrlRole;
            steels.SteelCount = SteelCount;
            steels.MeasureUnit = MeasureUnit;
            steels.PeopleSteel = PeopleSteel;
            var d = dal.Add(steels);
            if(d>0)
            {
                this.Close();
                ShowSteels();
            }
            else
            {
                MessageBox.Show("请重新添加订单");
            }
        }
        //添加
    }
}
