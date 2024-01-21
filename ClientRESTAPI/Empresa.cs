using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRESTAPI
{
    [Serializable]
    public class Empresa
    {

        public string cif { get; set; }
        public string nombre { get; set; }
        public string web { get; set; }
        public int telefono { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public string actividad { get; set; }
    }

}
