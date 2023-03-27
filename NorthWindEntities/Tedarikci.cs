using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindEntities
{
    public class Tedarikci:EntityBase
    {
        public int TedarikciId { get; set; }
        public string SirketAdi  { get; set; }

        public override string IdentityColumn { get { return "TedarikciId"; } }
    }
}
