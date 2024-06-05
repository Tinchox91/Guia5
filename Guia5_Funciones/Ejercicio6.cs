using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia5_Funciones
{
    internal class Ejercicio6
    {
        public static double calcularAreaCirculo(double radio)
        {
double total=3.14 * (radio * radio);
            return total;
        }
        public static double calcularAreaRectangulo(double basee, double altura)
        {
            double total =  basee*altura;
            return total;
        }
        public void solicitarDatosyMostrarResultados()
        {

            string val = "";
            do
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ingrese el area del circulo: ");
                    double t = double.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("El area del cirulo es: " + calcularAreaCirculo(t));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("ingrese el valor de la base: ");
                    double bas = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el valor de altura: ");
                    double altura = double.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("El area del rectangulo es: " + calcularAreaRectangulo(bas, altura));
                    Console.WriteLine("Desea continuar? S/N");
                    val = Console.ReadLine().ToLower();
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error al imgresar!!");
                }
                
                
            } while (val!="n");
        }
    }
}
