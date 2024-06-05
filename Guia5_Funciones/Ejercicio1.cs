using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia5_Funciones
{
    internal class Ejercicio1
    {
        string nom;
        int edad;
        static public void bienvenida()
        {
            Console.WriteLine("Bienvenid@ al sistema de gestion de Clientes ");
        }
        public void pedirDatos()
        {

            Console.Write("Ingrese nombre: ");
             nom=Console.ReadLine();
            Console.Write("Ingrese edad: ");
            edad = int.Parse(Console.ReadLine());
        }
public void imprimirBienvenidaDatos()
        {
            bienvenida();
            Console.WriteLine(nom);
            Console.WriteLine(edad);
        }
    }
}
