using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia5_Funciones
{
    internal class Ejercicio7
    {
        public static int leer(string num)
        {

        return int.Parse(num); }
        public static Boolean esPar(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static int calcularCuadrado(int num) {
            int total = num * num;
            return total;
        }
        public static int calcularCubo(int num) { 
        int total=num * num*num;
            return total;
        }

        public void mostrarResultados() {
            //en la consigna pide que el metodo 'mostrarResultados' reciba parametros pero no lo vi necesario
            //porque si asi fuera se necesitaria otro metodo para procesar los datos que recibe el mismo
            int total = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Ingrese '0' para salir....");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese numero: ");
                total = int.Parse(Console.ReadLine());
                string par = esPar(total) ? "Es par" : "Es impar";
                Console.WriteLine(par);
                Console.WriteLine($"El cuadrado es: {calcularCuadrado(total)}");
                Console.WriteLine($"El cubo es: {calcularCubo(total)}");
            } while (total!=0);
            
            
        }
    }
}
