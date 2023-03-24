using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindDAL
{
    internal interface IORM <T>//T tip yerine göre değişiklik gösteren tip.
        // İnterface de metodun gövdesi yoktur sadece imzası vardır. Doğuştan Public dir.
        // interface den implement edilen class ların bu metotları kullanması gereklidir.
    {
        DataTable Listele();
        bool Ekle(T tipnesnegelecek);
        bool Sil(int id);
        bool Guncelle(T tipnesnegelecek);

    }
}
