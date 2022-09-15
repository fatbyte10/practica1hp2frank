using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1Frank
{
    internal class Catalogo
    {
        //Catalogo sera un objeto solo con un atributo el cual es una lista de peliculas
        List<Pelicula> peliculas = new List<Pelicula>();

        //Con este metodo podemos validar si la pelicula existe
        public int ValidarPelicula(string nombrePelicula)
        {
            int index = this.peliculas.FindIndex(pelicula => pelicula.Titulo == nombrePelicula);

            return index;
        }

        /*
        Con este metodo creamos un objeto tipo pelicula esta hecho solo para
        pedir todos los atributos menos el titulo que lo pasamos como parametro
        para no generar redundancia
        */
        public Pelicula CrearPelicula(string titulo)
        {
            int año;
            string idioma, productora, director, genero, duracion;

            Console.WriteLine("Ingrese el idioma");
            idioma = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre de la productora");
            productora = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del director");
            director = Console.ReadLine();
            Console.WriteLine("Ingrese el genero de la pelicula");
            genero = Console.ReadLine();
            Console.WriteLine("Ingrese la duracion de la pelicula");
            duracion = Console.ReadLine();
            Console.WriteLine("Ingrese el año de lanzamiento de la pelicula");
            año = int.Parse(Console.ReadLine());

            Pelicula pelicula = new Pelicula(titulo, idioma, productora, director, genero, duracion, año);

            return pelicula;
        }

        /*
        Con este metodo agregamos una pelicula a la lista,
        validamos si ya exitste si es asi
        tenemos la posibilidad de actualizarla
        si no existe, creamos una pelicula y la agregamos a la lista
        */
        public void AgregarPelicula()
        {
            int año, posicion, sw;
            string titulo, idioma, productora, director, genero, duracion;

            Console.WriteLine("Ingrese el nombre de la pelicula");
            titulo = Console.ReadLine();
            posicion = ValidarPelicula(titulo);
            if (posicion == -1)
            {

                Pelicula pelicula = CrearPelicula(titulo);
                this.peliculas.Add(pelicula);
            }
            else
            {
                Console.WriteLine("La pelicula ya existe, desea actualizarla? ingrese 1 para actualizar o 0 para salir");
                sw = int.Parse(Console.ReadLine());
                if (sw == 1)
                {
                    Console.WriteLine("Ingrese el nombre de la pelicula");
                    titulo = Console.ReadLine();
                    Pelicula pelicula = CrearPelicula(titulo);
                    this.peliculas[posicion] = pelicula;
                }
            }
        }

        /*
        Metodo para actualizar una pelicula del catalogo,
        calidamos si existe la palicula,
        si es asi actualizamos los datos.
        */
        public void ActualizarPelicula()
        {
            int posicion;
            string titulo;

            Console.WriteLine("Ingrese el nombre de la pelicula");
            titulo = Console.ReadLine();
            posicion = ValidarPelicula(titulo);

            if (posicion == -1)
            {
                Console.WriteLine("Esta pelicula no existe en el catalogo");
            }
            else
            {
                Console.WriteLine("Ingrese el nombre de la pelicula");
                titulo = Console.ReadLine();
                Pelicula pelicula = CrearPelicula(titulo);
                this.peliculas[posicion] = pelicula;
            }
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadLine();
        }

        /*
        Con este metodo buscamos una pelicula en el catalogo
        por el nombre de la pelicula
        */
        public void BuscarPorNombre()
        {
            int posicion;
            string titulo;

            Console.WriteLine("Ingrese el nombre de la pelicula");
            titulo = Console.ReadLine();
            posicion = ValidarPelicula(titulo);

            if (posicion == -1)
            {
                Console.WriteLine("Esta pelicula no existe en el catalogo");
            }
            else
            {
                Console.WriteLine("*--------------------{0}------------------*", titulo);
                Console.WriteLine("Pelicula: {0}", this.peliculas[posicion].Titulo);
                Console.WriteLine("Idioma:  {0}", this.peliculas[posicion].Idioma);
                Console.WriteLine("Productora: {0}", this.peliculas[posicion].Productora);
                Console.WriteLine("Director: {0}", this.peliculas[posicion].Director);
                Console.WriteLine("Genero: {0}", this.peliculas[posicion].Genero);
                Console.WriteLine("Duracion: {0}", this.peliculas[posicion].Duracion);
                Console.WriteLine("Año: {0}", this.peliculas[posicion].Año);
                Console.WriteLine("*-----------------------------------------*");
            }
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadLine();
        }

        /*
        Con este metodo buscamos las peliculas en el catalogo
        de un director en especifico
        */
        public void BuscarPorDirector()
        {
            int posicion;
            string director;

            Console.WriteLine("Ingrese el nombre del director");
            director = Console.ReadLine();

            posicion = this.peliculas.FindIndex(pelicula => pelicula.Director == director); ;

            if (posicion == -1)
            {
                Console.WriteLine("Este director no existe en el catalogo");
            }
            else
            {
                Console.WriteLine("+-------PELICULAS DEL DIRECTOR {0}--------+", director);
                foreach (Pelicula pelicula in this.peliculas)
                {
                    if (pelicula.Director == director)
                    {
                        Console.WriteLine("*-----------------------------------------*");
                        Console.WriteLine("Pelicula: {0}", pelicula.Titulo);
                        Console.WriteLine("Idioma:  {0}", pelicula.Idioma);
                        Console.WriteLine("Productora: {0}", pelicula.Productora);
                        Console.WriteLine("Director: {0}", pelicula.Director);
                        Console.WriteLine("Genero: {0}", pelicula.Genero);
                        Console.WriteLine("Duracion: {0}", pelicula.Duracion);
                        Console.WriteLine("Año: {0}", pelicula.Año);
                        Console.WriteLine("*-----------------------------------------*");
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadLine();
        }

        /*
        Con este metodo buscamos las peliculas en el catalogo
        por un genero especifico
        */
        public void BuscarPorGenero()
        {
            int posicion;
            string genero;

            Console.WriteLine("Ingrese el genero");
            genero = Console.ReadLine();

            posicion = this.peliculas.FindIndex(pelicula => pelicula.Genero == genero); ;

            if (posicion == -1)
            {
                Console.WriteLine("Este genero no existe en el catalogo");
            }
            else
            {
                Console.WriteLine("+------------PELICULAS DE {0}------------+", genero);
                foreach (Pelicula pelicula in this.peliculas)
                {
                    if (pelicula.Genero == genero)
                    {
                        Console.WriteLine("*-----------------------------------------*");
                        Console.WriteLine("Pelicula: {0}", pelicula.Titulo);
                        Console.WriteLine("Idioma:  {0}", pelicula.Idioma);
                        Console.WriteLine("Productora: {0}", pelicula.Productora);
                        Console.WriteLine("Director: {0}", pelicula.Director);
                        Console.WriteLine("Genero: {0}", pelicula.Genero);
                        Console.WriteLine("Duracion: {0}", pelicula.Duracion);
                        Console.WriteLine("Año: {0}", pelicula.Año);
                        Console.WriteLine("*-----------------------------------------*");
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadLine();
        }

        /*
        Con este metodo podemos ver el catalogo completo
        */
        public void VerCatalogo()
        {
            Console.WriteLine("+-----------------CATALOGO----------------+");
            foreach (Pelicula pelicula in this.peliculas)
            {
                Console.WriteLine("*-----------------------------------------*");
                Console.WriteLine("Pelicula: {0}", pelicula.Titulo);
                Console.WriteLine("Idioma:  {0}", pelicula.Idioma);
                Console.WriteLine("Productora: {0}", pelicula.Productora);
                Console.WriteLine("Director: {0}", pelicula.Director);
                Console.WriteLine("Genero: {0}", pelicula.Genero);
                Console.WriteLine("Duracion: {0}", pelicula.Duracion);
                Console.WriteLine("Año: {0}", pelicula.Año);
                Console.WriteLine("*-----------------------------------------*");
            }
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadLine();
        }
    }
}