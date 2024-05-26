using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_app
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public List<string> Formato { get; set; }
        public List<string> Sala { get; set; }
        public List<string> Horario { get; set; }
        public string Id { get; set; }
    }
}
