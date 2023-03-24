using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindDAL
{
    public class Tools
    {
        private static SqlConnection _baglanti = new SqlConnection( "SERVER=DESKTOP-TUMHS1A\\NA; DATABASE = Northwind; INTEGRATED SECURITY= TRUE");
       

        public static SqlConnection Baglanti { 
            get { return _baglanti; }
            set {}
            }

        public static bool BaglanExec(SqlCommand komut) 
            
            {
            try
            {
                if (komut.Connection.State == ConnectionState.Closed)
                {
                    komut.Connection.Open();
                }

                int sonuc = komut.ExecuteNonQuery();
                return sonuc > 0 ? true : false;

            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                if (komut.Connection.State == ConnectionState.Open)
                {
                    komut.Connection.Close();
                }
            }
            
            }
    }
}
