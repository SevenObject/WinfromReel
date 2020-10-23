
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SteelModel;

namespace SteelDAL
{
    public class SteelMaterDAL
    {
        DBHelper DBHelper = new DBHelper();
        public int Add(SteelMater steel)
        {
            string sql = $"insert into SteelMater values('{steel.SteelMaterials}','{steel.SteelRole}','{steel.SteelCount}','{steel.MeasureUnit}','{steel.PeopleSteel}')";
            return DBHelper.ExecuteNonQuery(sql);
        }
        public int Update(SteelMater s)
        {
            string sql = $"update SteelMater set SteelMaterials='{s.SteelMaterials}',SteelRole='{s.SteelRole}',SteelCount='{s.SteelCount}',MeasureUnit='{s.MeasureUnit}',PeopleSteel='{s.PeopleSteel}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
        public int Delete(int id)
        {
            string sql = $"delete from SteelMater where Sid='{id}'";
            return DBHelper.ExecuteNonQuery(sql);
        }
    }
}