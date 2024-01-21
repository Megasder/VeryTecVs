using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRESTAPI
{
    [Serializable]
    class Compra
    {
        public long id_compra { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public int cantidad { get; set; }
    }
}
