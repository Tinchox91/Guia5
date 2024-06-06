using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia5_Funciones
{
    internal class Ejercicio8
    {
        public static int sumar(int n1,int n2)
        {
            int total=n1+n2;
            return total;
        }
        public static int restar(int n1, int n2)
        {
            int total = n1 - n2;
            return total;
        }
        public static int multiplicar(int n1, int n2)
        {
            int total = n1 * n2;
            return total;
        }
        public static double dividir(int n1, int n2)
        {
            int total = n1 / n2;
            return total;
        }
        public void mostrarResultados()
        {
            int op = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese el primer numero: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo numero: ");
                int n2 = int.Parse(Console.ReadLine());
                double total;
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Indica la operacion deseada: ");
                Console.WriteLine("1.SUMAR");
                Console.WriteLine("2.RESTAR");
                Console.WriteLine("3.MULTIPLICAR");
                Console.WriteLine("4.DIVIDIR");
                Console.WriteLine("0.SALIR");
                op = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                switch (op)
                {
                    case 1:total = sumar(n1, n2); Console.WriteLine("Resultado: "+total); Console.WriteLine("Apreta ENTER para continuar..."); Console.ReadKey();  break;
                    case 2: total = restar(n1, n2); Console.WriteLine("Resultado: " + total); Console.WriteLine("Apreta ENTER para continuar..."); Console.ReadKey(); break;
                    case 3: total = multiplicar(n1, n2); Console.WriteLine("Resultado: " + total); Console.WriteLine("Apreta ENTER para continuar..."); Console.ReadKey(); break;
                    case 4: total = dividir(n1, n2); Console.WriteLine("Resultado: " + total); Console.WriteLine("Apreta ENTER para continuar..."); Console.ReadKey(); break;
                }
            } while (op!=0);
           

        }
    }
}
