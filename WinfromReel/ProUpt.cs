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
    public partial class ProUpt : Form
    {
        public ProUpt()
        {
            InitializeComponent();
        }
        ProDal dal = new ProDal();

        public delegate void Pro();
        public event Pro _pro;
        private void button1_Click(object sender, EventArgs e)
        {
            ProModel m = new ProModel();
            m.ProId = Convert.ToInt32(this.Tag);
            m.ProName = txt1.Text;
            m.ProUnit = txt2.Text;
            //m.ProDate = DateTime.Now;
            m.ProPrice = Convert.ToInt32(txt4.Text);
            m.ProNum = Convert.ToInt32(txt5.Text);
            //m.ProSta =textBox1.Text;
            //var obj = { };
            //int id = Convert.ToInt32(this.Tag);
            int i = dal.Update(m);
            if (i > 0)
            {
                MessageBox.Show("材料成功修改");
                this.Close();
                //ProModel m = new ProModel();                    
                _pro();
            }
            else
            {
                MessageBox.Show("修改故障，请检查！");
            }

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.Tag.ToString());
            List<ProModel> list = dal.GetId(id);
            foreach (var m in list)
            {
                //ProModel m = new ProModel();
                //this.Tag = m.ProId;
                txt1.Text = m.ProName;
                txt2.Text = m.ProUnit;
                //m.ProDate = DateTime.Now;
                txt4.Text = Convert.ToString(m.ProPrice);// Convert.ToInt32(txt4.Text);            
                txt5.Text = Convert.ToString(m.ProNum);
                //textBox1.Text =Convert.ToString(m.ProSta);
            }
        }
    }
}
