using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRESTAPI
{
    [Serializable]
    class Usuario
    {
        public String password { get; set; }
        public int? rol { get; set; }
        public String descripcion { get; set; }
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public String dni { get; set; }
        public int? telefono { get; set; }
        public String email { get; set; }
        public String direccion { get; set; }
        public String numidentificacion { get; set; }


    }
}
