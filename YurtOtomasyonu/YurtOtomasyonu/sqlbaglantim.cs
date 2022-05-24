using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace YurtOtomasyonu
{
  public  class sqlbaglantim
    {

        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-O9RRR03;Initial Catalog=yurtOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
        
    }
}
