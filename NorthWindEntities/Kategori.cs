using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindEntities
{
    public class Kategori : EntityBase
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public string Tanimi { get; set; }
        public byte[] Resim { get; set; }

        public override string IdentityColumn { get { return "KategoriID";} }
    }
}
