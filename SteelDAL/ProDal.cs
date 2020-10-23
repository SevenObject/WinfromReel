using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteelModel;
namespace SteelDAL
{
    public class ProDal
    {
        DBHelper db = new DBHelper();
        //显示
        public List<ProModel> Show()
        {
            //string sql = "select *,ProPrice*ProNum as ProSum from Procurement where ProSta='1'";
            string sql = "select *,ProPrice*ProNum as ProSum from Procurement where ProSta='1'";
            //select ProName, ProUnit, ProDate, ProPrice, ProNum, ProPrice*ProNum as ProSum from Procurement where ProSta = '1'
            return db.GetToList<ProModel>(sql);
        }
        public List<ProModel> GetPro(string proname)
        {
            string sql = $"select * from Procurement where ProSta=1 and ProName like '%{proname}%'";
            return db.GetToList<ProModel>(sql);
        }
        public List<ProModel> Shows(string name)
        {
            string sql = $"select * from Procurement where ProName='{name}'";
            return db.GetToList<ProModel>(sql);
        }
        //添加
        public int Add(ProModel m)
        {
            string sql = $"insert into Procurement values('{m.ProName}','{m.ProUnit}','{m.ProDate}',{m.ProPrice},{m.ProNum},default)";

            //if (!string.IsNullOrEmpty(name))
            //{
            //    sql += $" and ProName='{name}'";
            //}
            return db.ExecuteNonQuery(sql);
        }
        //删除
        public int Del(int id)
        {
            string sql = $"update Procurement set ProSta=0 where ProId='{id}'";
            return db.ExecuteNonQuery(sql);
        }
        //修改
        public int Update(ProModel m)
        {
            string sql = $"update Procurement set ProName='{m.ProName}',ProUnit='{m.ProUnit}',ProPrice={m.ProPrice},ProNum={m.ProNum} where ProId={m.ProId}";
            return db.ExecuteNonQuery(sql);
        }
        public List<ProModel> GetId(int id)
        {
            string sql = $"select * from Procurement where ProId={id}";
            return db.GetToList<ProModel>(sql);
        }
    }
}
