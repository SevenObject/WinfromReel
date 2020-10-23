using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelModel
{
    public class ProModel
    {
        //采购的ID
        public int ProId { get; set; }
        //采购材料名
        public string ProName { get; set; }
        //采购单位
        public string ProUnit { get; set; }
        //采购日期
        public DateTime ProDate { get; set; }
        //采购价格
        public int ProPrice { get; set; }
        //采购数量
        public int ProNum { get; set; }
        //采购总价
        public int ProSum { get; set; }
        public string ProSta { get; set; }
    }
}
