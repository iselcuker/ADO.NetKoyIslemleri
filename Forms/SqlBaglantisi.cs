using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    public class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-MRP0OC6\SQLEXPRESS;Initial Catalog=KoyIslemleri;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
