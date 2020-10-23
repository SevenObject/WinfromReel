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
    public partial class UpdSendForm : Form
    {
        public UpdSendForm()
        {
            InitializeComponent();
        }
        public delegate void RefreshList();
        public event RefreshList _ReList;
        SendInfoDAL dal = new SendInfoDAL();
        private void btn_Save_Click(object sender, EventArgs e)
        {
            SendInfo si = new SendInfo();
            si.Id = Convert.ToInt32(this.Tag.ToString());
            si.Address = cbb_Address.Text;
            si.PName = cbb_PName.Text;
            si.Type = txt_Type.Text;
            si.Num = txt_Num.Text;
            si.Driver = txt_Driver.Text;
            si.Statu = cbb_Statu.Text;
            si.Phone = txt_Phone.Text;
            int i = dal.UpdInfo(si);
            if (i > 0)
            {
                MessageBox.Show("编辑成功");
                this.Close();
                _ReList();
            }
            else
            {
                MessageBox.Show("编辑失败");
            }
        }
    }
}
