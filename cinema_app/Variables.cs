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

            // Películas actuales
            Pelicula pelicula1 = new Pelicula();
            pelicula1.Titulo = "Spider-Man: No Way Home";
            pelicula1.Formato = new List<string> { "2D", "3D", "IMAX" };
            pelicula1.Sala = new List<string> { "3", "4", "5" };
            pelicula1.Horario = new List<string> { "13:00", "15:00", "17:00" };
            pelicula1.Id = "1";
            pelicula1.Image = "https://cloudfront-us-east-1.images.arcpublishing.com/copesa/MDMG3XXXDFHETJHSBR2QEIXKQI.jpg";
            listaPeliculas.Add(pelicula1);

            Pelicula pelicula2 = new Pelicula();
            pelicula2.Titulo = "Jurassic World: Dominion";
            pelicula2.Formato = new List<string> { "3D", "IMAX" };
            pelicula2.Sala = new List<string> { "5", "6", "7" };
            pelicula2.Horario = new List<string> { "15:30", "17:30", "21:00" };
            pelicula2.Id = "2";
            pelicula2.Image = "https://es.web.img2.acsta.net/pictures/22/04/25/10/39/2475018.jpg";
            listaPeliculas.Add(pelicula2);

            Pelicula pelicula3 = new Pelicula();
            pelicula3.Titulo = "Avatar 2";
            pelicula3.Formato = new List<string> { "3D", "4DX" };
            pelicula3.Sala = new List<string> { "1", "2", "3" };
            pelicula3.Horario = new List<string> { "13:15", "18:30", "20:00" };
            pelicula3.Id = "3";
            pelicula3.Image = "https://es.web.img3.acsta.net/pictures/22/11/02/15/37/0544148.jpg";
            listaPeliculas.Add(pelicula3);

            Pelicula pelicula4 = new Pelicula();
            pelicula4.Titulo = "Matrix Resurrections";
            pelicula4.Formato = new List<string> { "2D", "IMAX" };
            pelicula4.Horario = new List<string> { "20:00", "22:30", "23:15" };
            pelicula4.Sala = new List<string> { "1", "2" };
            pelicula4.Id = "4";
            pelicula4.Image = "https://m.media-amazon.com/images/M/MV5BMGJkNDJlZWUtOGM1Ny00YjNkLThiM2QtY2ZjMzQxMTIxNWNmXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_FMjpg_UX1000_.jpg";
            listaPeliculas.Add(pelicula4);

            // Películas clásicas
            Pelicula pelicula5 = new Pelicula();
            pelicula5.Titulo = "Volver al futuro";
            pelicula5.Formato = new List<string> { "2D", "3D", "5D" };
            pelicula5.Sala = new List<string> { "3", "4", "5" };
            pelicula5.Horario = new List<string> { "13:00", "15:00", "17:00" };
            pelicula5.Id = "5";
            pelicula5.Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTLohJoEUF6TFEzWkru80nI3DDm5XkFzKh4fV8VQroxjA&s";
            listaPeliculas.Add(pelicula5);

            Pelicula pelicula6 = new Pelicula();
            pelicula6.Titulo = "Los cazafantasmas";
            pelicula6.Formato = new List<string> { "2D", "3D" };
            pelicula6.Sala = new List<string> { "5", "6", "7" };
            pelicula6.Horario = new List<string> { "15:30", "17:30", "21:00" };
            pelicula6.Id = "6";
            pelicula6.Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRNaPPs0_oXnAwMdEsia7RsBKxZMwxIgmQIJmn3wFSTiQ&s";
            listaPeliculas.Add(pelicula6);

            Pelicula pelicula7 = new Pelicula();
            pelicula7.Titulo = "The Godfather";
            pelicula7.Formato = new List<string> { "2D" };
            pelicula7.Sala = new List<string> { "1", "2", "3" };
            pelicula7.Horario = new List<string> { "13:15", "18:30", "20:00" };
            pelicula7.Id = "7";
            pelicula7.Image = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_.jpg";
            listaPeliculas.Add(pelicula7);

            Pelicula pelicula8 = new Pelicula();
            pelicula8.Titulo = "indiana jones y el llamado del destino";
            pelicula8.Formato = new List<string> { "2D" };
            pelicula8.Horario = new List<string> { "20:00", "22:30", "23:15" };
            pelicula8.Sala = new List<string> { "1", "2" };
            pelicula8.Id = "8";
            pelicula8.Image = "https://pics.filmaffinity.com/Indiana_Jones_y_el_dial_del_destino-145866922-large.jpg";
            listaPeliculas.Add(pelicula8);

            // Otras películas adicionales
            Pelicula pelicula9 = new Pelicula();
            pelicula9.Titulo = "Titanic";
            pelicula9.Formato = new List<string> { "2D", "IMAX" };
            pelicula9.Sala = new List<string> { "3", "4", "5" };
            pelicula9.Horario = new List<string> { "14:00", "16:30", "19:00" };
            pelicula9.Image = "https://http2.mlstatic.com/D_NQ_NP_862166-MLA52537211584_112022-O.webp";
            listaPeliculas.Add(pelicula9);

            Pelicula pelicula10 = new Pelicula();
            pelicula10.Titulo = "The Shawshank Redemption";
            pelicula10.Formato = new List<string> { "2D" };
            pelicula10.Sala = new List<string> { "5", "6", "7" };
            pelicula10.Horario = new List<string> { "13:45", "16:15", "19:45" };
            pelicula10.Id = "10";
            pelicula10.Image = "https://images-cdn.ubuy.co.in/6351416337e9de157a371824-shawshank-redemption-movie-poster-us.jpg";
            listaPeliculas.Add(pelicula10);

            Pelicula pelicula11 = new Pelicula();
            pelicula11.Titulo = "The Dark Knight";
            pelicula11.Formato = new List<string> { "2D", "IMAX" };
            pelicula11.Sala = new List<string> { "1", "2", "3" };
            pelicula11.Horario = new List<string> { "14:30", "17:00", "20:30" };
            pelicula11.Id = "11";
            pelicula11.Image = "https://es.web.img2.acsta.net/medias/nmedia/18/66/74/01/20350623.jpg";
            listaPeliculas.Add(pelicula11);

            Pelicula pelicula12 = new Pelicula();
            pelicula12.Titulo = "Forrest Gump";
            pelicula12.Formato = new List<string> { "2D" };
            pelicula12.Horario = new List<string> { "13:30", "16:00", "18:30" };
            pelicula12.Sala = new List<string> { "1", "2" };
            pelicula12.Id = "12";
            pelicula12.Image = "https://pics.filmaffinity.com/Forrest_Gump-212765827-large.jpg";
            listaPeliculas.Add(pelicula12);

            Pelicula pelicula13 = new Pelicula();
            pelicula13.Titulo = "El señor de los anillos";
            pelicula13.Formato = new List<string> { "2D" };
            pelicula13.Sala = new List<string> { "3", "4", "5" };
            pelicula13.Horario = new List<string> { "13:45", "16:15", "19:45" };
            pelicula13.Id = "13";
            pelicula13.Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQwjvtARVQAFZvjgby4i1ev7I2h0OgHcG8YoQ&s";
            listaPeliculas.Add(pelicula13);

            Pelicula pelicula14 = new Pelicula();
            pelicula14.Titulo = "The Matrix";
            pelicula14.Formato = new List<string> { "2D", "IMAX" };
            pelicula14.Sala = new List<string> { "5", "6", "7" };
            pelicula14.Horario = new List<string> { "14:30", "17:00", "20:30" };
            pelicula14.Id = "14";
            pelicula14.Image = "https://i.ebayimg.com/images/g/QFQAAOSwAQpfjaA6/s-l1600.jpg";
            listaPeliculas.Add(pelicula14);

            Pelicula pelicula15 = new Pelicula();
            pelicula15.Titulo = "El club de la pelea";
            pelicula15.Formato = new List<string> { "2D" };
            pelicula15.Horario = new List<string> { "13:30", "16:00", "18:30" };
            pelicula15.Sala = new List<string> { "1", "2" };
            pelicula15.Id = "15";
            pelicula15.Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSmQXCDmqYbQ4Rz27Z5U5Vg1GcE1Cr2PaqJLg&s";
            listaPeliculas.Add(pelicula15);

            Pelicula pelicula16 = new Pelicula();
            pelicula16.Titulo = "El silencio de los inocentes";
            pelicula16.Formato = new List<string> { "2D" };
            pelicula16.Sala = new List<string> { "3", "4", "5" };
            pelicula16.Horario = new List<string> { "13:45", "16:15", "19:45" };
            pelicula16.Id = "16";
            pelicula16.Image = "https://m.media-amazon.com/images/I/81SVDO6WcrL.jpg";
            listaPeliculas.Add(pelicula16);
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