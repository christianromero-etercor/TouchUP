using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchUP
{
    internal class Articulo
    {
        public int Id { get; set; }
        public string Puesto { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public byte[] Imagen { get; set; }
    }
}

// Compare this snippet from ProductoConsultas.cs:
