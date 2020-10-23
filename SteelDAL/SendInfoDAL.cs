
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SteelModel;

namespace SteelDAL
{
    public class SendInfoDAL
    {
        DBHelper DBHelper = new DBHelper();
        public List<SendInfo> GetSendInfos()
        {
            return DBHelper.GetToList<SendInfo>("select * from SendInfo where Statu like '%配送%'");
        }
        public int AddInfo(SendInfo m)
        {
            string sql = $"insert into SendInfo values('{m.Address}','{m.PCode}','{m.PName}','{m.Type}','{m.Num}','{m.Driver}','{m.Statu}','{m.Phone}')";
            return DBHelper.ExecuteNonQuery(sql);
        }
        public int DelInfo(int id)
        {
            string sql = $"Update SendInfo set Statu='已完成' where Id={id}";
            return DBHelper.ExecuteNonQuery(sql);
        }
        public int UpdInfo(SendInfo m)
        {
            string sql = $"update SendInfo set Address= '{m.Address}',PName='{m.PName}',Type='{m.Type}',Num='{m.Num}',Driver='{m.Driver}',Statu='{m.Statu}',Phone='{m.Phone}' where Id ={m.Id}";
            return DBHelper.ExecuteNonQuery(sql);
        }
        public List<SendInfo> GetInfoById(int id)
        {
            string sql = $"select * from SendInfo where Id={id}";
            return DBHelper.GetToList<SendInfo>(sql);
        }
    }
}