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

        private void SendInfoFristShow_Load(object sender, EventArgs e)
        {
            TreePic();
        }
        public void TreePic()
        {
            treeView1.Show();

        }
    }
}
