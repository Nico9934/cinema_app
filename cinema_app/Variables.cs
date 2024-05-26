using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_app
{
    public class Variables
    {
        // Lista de películas
        private static List<Pelicula> listaPeliculas;

        // Método para inicializar la lista de películas
        public static void InicializarPeliculas()
        {
            listaPeliculas = new List<Pelicula>();

            Pelicula pelicula1 = new Pelicula();
            pelicula1.Titulo = "Volver al futuro";
            pelicula1.Formato = new List<string> { "2D", "3D", "5D" };
            pelicula1.Sala = new List<string> { "3", "4", "5" };
            pelicula1.Horario = new List<string> { "13:00", "15:00", "17:00" };
            pelicula1.Id = "1";
            listaPeliculas.Add(pelicula1);

            Pelicula pelicula2 = new Pelicula();
            pelicula2.Titulo = "Garfield 4";
            pelicula2.Formato = new List<string> { "3D", "5D" };
            pelicula2.Sala = new List<string> { "5", "6", "7" };
            pelicula2.Horario = new List<string> { "15:30", "17:30", "21:00" };
            pelicula2.Id = "2";
            listaPeliculas.Add(pelicula2);

            Pelicula pelicula3 = new Pelicula();
            pelicula3.Titulo = "Godzilla X King";
            pelicula3.Formato = new List<string> { "4D", "5D" };
            pelicula3.Sala = new List<string> { "1", "2", "3" };
            pelicula3.Horario = new List<string> { "13:15", "18:30", "20:00" };
            pelicula3.Id = "3";
            listaPeliculas.Add(pelicula3);

            Pelicula pelicula4 = new Pelicula();
            pelicula4.Titulo = "Kung Fu Panda 4";
            pelicula4.Formato = new List<string> { "4D", "5D" };
            pelicula4.Horario = new List<string> { "20:00", "22:30", "23:15" };
            pelicula4.Sala = new List<string> { "1", "2" };
            pelicula4.Id = "4";
            listaPeliculas.Add(pelicula4);
        }

        // Pelicula seleccionada
        public static PeliculaSeleccionada seleccion = new PeliculaSeleccionada();

        public static Usuario datosUsuario = new Usuario();
        public static List<Pelicula> ObtenerPeliculas()
        {
            InicializarPeliculas();
            return listaPeliculas;
        }
    }
}