using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindDAL
{//Base Class

    public class BaseORM<T> : IORM<T>
    {
        Type Tipgetir { get{ return typeof(T); } }
        // Burada T tipinde bir tip var bu aslında class ın tipini getiriyor. Kategori ise kategori Listele, Urun ise Urun Listele Metodu çağrılmış oluyor bu sayede.


        //typeof(T).ToString();
        public bool Ekle(T tipnesnegelecek)
        {
            SqlCommand komut = new SqlCommand(String.Format("{0}Ekle",Tipgetir.Name),Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
           PropertyInfo[] properties = Tipgetir.GetProperties();
            foreach (PropertyInfo item in properties)
            {
                string parametreAdi = item.Name;
                object deger = item.GetValue(tipnesnegelecek);
                komut.Parameters.AddWithValue(parametreAdi,deger);
            }


            return Tools.BaglanExec(komut);
        }

        public bool Guncelle(T tipnesnegelecek)
        {
            SqlCommand komut = new SqlCommand(String.Format("{0}Guncelle", Tipgetir.Name), Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            PropertyInfo[] properties = Tipgetir.GetProperties();
            foreach (PropertyInfo item in properties)
            {
                string parametreAdi = item.Name;
                object deger = item.GetValue(tipnesnegelecek);
                komut.Parameters.AddWithValue(parametreAdi, deger);
            }


            return Tools.BaglanExec(komut);
        }

        public DataTable Listele()
        {

            SqlDataAdapter adp = new SqlDataAdapter(String.Format("{0}Listesi",Tipgetir.Name),Tools.Baglanti);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
