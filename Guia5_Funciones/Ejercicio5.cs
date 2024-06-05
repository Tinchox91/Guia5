using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia5_Funciones
{
    internal class Ejercicio5
    {
        public static void sumar(int a, int b, int c) {
            int total = a + c + b;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("El total de la suma es: "+total);
        }
        public static void potencia(int a, int b, int c)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            int total = a * c * b;
            Console.WriteLine("El producto total es: " + total);
        }
        public void pedirNumeros()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Ingresar cualquier letra para salir del bucle...");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Calculo numero "+(i+1));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese el primer numero: ");
                int a=int.Parse(Console.ReadLine());    
                Console.Write("Ingrese el segundo numero: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el tercer numero: ");
                int c = int.Parse(Console.ReadLine());
                sumar(a, b, c);
                potencia(a, b, c);
            }
        }
    }
}
