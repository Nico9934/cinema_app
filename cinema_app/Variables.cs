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
            pelicula1.Formato = "2D";
            pelicula1.Sala = "4";
            pelicula1.Id = "1";
            listaPeliculas.Add(pelicula1);

            Pelicula pelicula2 = new Pelicula();
            pelicula2.Titulo = "Garfield 4";
            pelicula2.Formato = "3D";
            pelicula2.Sala = "4";
            pelicula2.Id = "2";
            listaPeliculas.Add(pelicula2);

            Pelicula pelicula3 = new Pelicula();
            pelicula3.Titulo = "Godzilla X King";
            pelicula3.Formato = "2D";
            pelicula3.Sala = "3";
            pelicula3.Id = "3";
            listaPeliculas.Add(pelicula3);

            Pelicula pelicula4 = new Pelicula();
            pelicula4.Titulo = "Kung Fu Panda 4";
            pelicula4.Formato = "2D";
            pelicula4.Sala = "3";
            pelicula4.Id = "4";
            listaPeliculas.Add(pelicula4);
        }

        // Método para obtener la lista de películas
        public static List<Pelicula> ObtenerPeliculas()
        {
            InicializarPeliculas();
            return listaPeliculas;
        }
    }
}