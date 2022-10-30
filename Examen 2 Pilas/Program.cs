using System;
using System.Collections.Generic;
using Examen_2_Pilas.GUI;

namespace Examen_2_Pilas
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("- - - - - - - - - - - - - - - - - -");
                Console.WriteLine("Balanceador de equasiones");
                Console.WriteLine("- - - - - - - - - - - - - - - - - -\n\n");
                new Main().program();
                Console.WriteLine("Presiona cualquier tecla para continuar, escape para salir");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}

