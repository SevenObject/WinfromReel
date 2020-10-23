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
using SteelDAL;
namespace WinfromReel
{
    public partial class ProAdd : Form
    {
        public delegate void Rep();
        public event Rep _rep;
        public ProAdd()
        {
            InitializeComponent();
        }
        ProDal dal = new ProDal();
        private void Form2_Load(object sender, EventArgs e)
        {
            //ProModel m = new ProModel();
            //lb1.Text = m.ProUnit;
            //m.ProUnit = lb1.Name;
            //m.ProDate
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProModel m = new ProModel();
            m.ProName = txt1.Text;
            m.ProUnit = txt2.Text;
            m.ProDate = DateTime.Now;
            m.ProPrice = Convert.ToInt32(txt4.Text);
            m.ProNum = Convert.ToInt32(txt5.Text);
            m.ProSta = textBox1.Text;
            int i = dal.Add(m);
            if (i > 0)
            {
                MessageBox.Show("材料成功添加");
                this.Close();
                _rep();
                // ProModel m = new ProModel();
                //Form1 f1 = new Form1();
                //f1.Show();

            }
            else
            {
                MessageBox.Show("添加故障，请检查！");
            }
        }
    }
}
