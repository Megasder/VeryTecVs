using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRESTAPI
{
    [Serializable]
    public class Producto
    {
        public long idProducto { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public float precio { get; set; }
        public float iva { get; set; }
        public int descuento { get; set; }

        public int cantidad { get; set; }

    }
}
