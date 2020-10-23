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
    public partial class AddSendForm : Form
    {
        public AddSendForm()
        {
            InitializeComponent();
        }
        public delegate void Refrish();
        public event Refrish _ReShow;
        SendInfoDAL dal = new SendInfoDAL();
        private void btn_Save_Click(object sender, EventArgs e)
        {
            SendInfo m = new SendInfo();
            m.Address = cbb_Address.Text;
            m.PCode = "SH233-" + (DateTime.Now).ToString();
            m.PName = cbb_PName.Text;
            m.Type = txt_Type.Text;
            m.Num = (txt_Num.Value).ToString();
            m.Driver = txt_Driver.Text;
            m.Statu = "未配送";
            m.Phone = txt_Phone.Text;
            int i = dal.AddInfo(m);
            if (i > 0)
            {
                MessageBox.Show("保存成功！");
                this.Close();
                _ReShow();
            }
        }

        private void AddSendForm_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.Tag.ToString());
            List<SendInfo> list = dal.GetInfoById(id);
            foreach (var m in list)
            {
                cbb_Address.Text = m.Address;
                txt_PCode.Text = m.PCode;
                cbb_PName.Text = m.PName;
                txt_Type.Text = m.Type;
                txt_Num.Text = m.Num;
                txt_Driver.Text = m.Driver;
                cbb_Statu.Text = m.Statu;
                txt_Phone.Text = m.Phone;
            }
        }
    }
}
