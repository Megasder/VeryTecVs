using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRESTAPI
{
    [Serializable]
    internal class Cliente
    {
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int telefono { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string historial { get; set; }

        public float dinero { get; set; }
    }
}
