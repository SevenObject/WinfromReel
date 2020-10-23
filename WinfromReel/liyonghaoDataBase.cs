using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinfromReel
{
    public class liyonghaoDataBase
    {
        public SqlConnection getConn()
        {
            String strConnection = "Data Source=.;Initial Catalog=winforms;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConnection);
            return conn;

        }
    }
}
