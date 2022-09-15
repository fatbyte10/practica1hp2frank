﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1Frank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sw = 10;
            Catalogo catalogo = new Catalogo();

            while (sw != 0)
            {
                Console.Clear();

                Console.WriteLine("+--------BIENVENIDO FRANK´S MOVIES--------+");
                Console.WriteLine("Ingrese 1 para agregar una pelicula");
                Console.WriteLine("Ingrese 2 para actulizar una pelicula");
                Console.WriteLine("Ingrese 3 para ver catalogo");
                Console.WriteLine("Ingrese 4 para buscar pelicula por nombre");
                Console.WriteLine("Ingrese 5 para buscar pelicula por director");
                Console.WriteLine("Ingrese 6 para buscar pelicula por genero");
                Console.WriteLine("Ingrese 0 para salir");
                Console.WriteLine("+-----------------------------------------+");

                sw = int.Parse(Console.ReadLine());

                Console.Clear();

                if (sw == 1)
                {
                    catalogo.AgregarPelicula();
                }
                else if (sw == 2)
                {
                    catalogo.ActualizarPelicula();
                }
                else if (sw == 3)
                {
                    catalogo.VerCatalogo();
                }
                else if (sw == 4)
                {
                    catalogo.BuscarPorNombre();
                }
                else if (sw == 5)
                {
                    catalogo.BuscarPorDirector();
                }
                else if (sw == 6)
                {
                    catalogo.BuscarPorGenero();
                }
            }
        }
    }
}