using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_app
{
    public class PeliculaSeleccionada
    {
        public string Titulo { get; set; }
        public string Formato { get; set; }
        public string Sala { get; set; }
        public string Horario { get; set; }
        public string Imagen { get; set; }
        public List<string> Asientos { get; set; }
    }
}
