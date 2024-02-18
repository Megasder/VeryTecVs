using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRESTAPI
{
    internal class CompraDataGridModel
    {
        public long id {  get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public int cantidad { get; set; }

        public string clienteDni { get; set; }
        public string productoNom { get; set; }

        public string productoCat { get; set; }

    }
}
