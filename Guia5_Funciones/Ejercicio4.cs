using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia5_Funciones
{
    internal class Ejercicio4
    {
        
        public void pedirNombre()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Ingrese nombre: ");
            Console.ForegroundColor = ConsoleColor.White;
            string nombre = Console.ReadLine();
            saludar(nombre);
           
        }

        public static void saludar(string nom)
        {
            Console.ForegroundColor= ConsoleColor.DarkGreen;
            Console.WriteLine($"Hola! {nom}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Oprima ENTER para terminar...");
            Console.ReadKey();
        }
    }
}
