using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1Frank
{
    internal class Pelicula
    {
        // Creamos el objeto Pelicula y creamos un constructor para instanciarlo
        int año;
        string titulo, idioma, productora, director, genero, duracion;

        public Pelicula(string titulo, string idioma, string productora, string director, string genero, string duracion, int año)
        {
            this.Titulo = titulo;
            this.Idioma = idioma;
            this.Productora = productora;
            this.Director = director;
            this.Genero = genero;
            this.Duracion = duracion;
            this.Año = año;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Duracion { get => duracion; set => duracion = value; }
        public string Idioma { get => idioma; set => idioma = value; }
        public string Productora { get => productora; set => productora = value; }
        public string Director { get => director; set => director = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Año { get => año; set => año = value; }
    }


}