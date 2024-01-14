using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchUP
{
    internal class RegistroFallas
    {
        public DateTime FechaHora { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Componente { get; set; }
        public string Falla { get; set; }
        public int Cantidad { get; set; }
        public string Comentarios { get; set; }
        public string Usuario { get; internal set; }
    }
}

// Compare this snippet from RegistroFallasConsultas.cs:
