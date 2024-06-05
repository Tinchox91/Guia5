using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia5_Funciones
{
    internal class Inicio
    {
        static void Main(string[] args)
        {
            int op =1;
            do
            {
               Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Indica el ejercicio que desea probar...");
                Console.WriteLine("1.Bienvenida al cliente y su edad");
                Console.WriteLine("2.Cuadrado de un numero");
                Console.WriteLine("3.Practica");
                Console.WriteLine("4.Saludo y nombre");
                Console.WriteLine("5.Realizar 10 sumas y productos");
                Console.WriteLine("6.Calculos Geometricos");
                Console.WriteLine("7.Desarrollo Versatil con multiples Metodos");
                Console.WriteLine("8.Calculadora");
                Console.WriteLine("0.Salir");
                
                try//uso try/catch para evitar errores de tipeo...
                {
                    op=int.Parse(Console.ReadLine());
                    switch (op)
                    {//instancio un objeto de cada clase por ejercicio
                        case 2: Ejercicio2 ejercicio2 = new Ejercicio2(); ejercicio2.potenciar(); break;
                        case 1: Ejercicio1 ejercicio1 = new Ejercicio1();ejercicio1.imprimirBienvenidaDatos(); break;
                        case 3: Ejercicio3 ejercicio3 = new Ejercicio3();ejercicio3.bienvenida();ejercicio3.instrucciones(); break;
                        case 4: Ejercicio4 ejercicio4 = new Ejercicio4();ejercicio4.pedirNombre(); break;
                        case 5: Ejercicio5 ejercicio5 = new Ejercicio5();ejercicio5.pedirNumeros(); break;
                        case 6: Ejercicio6 ejercicio6 = new Ejercicio6();ejercicio6.solicitarDatosyMostrarResultados(); break;
                        case 7: Ejercicio7 ejercicio7 = new Ejercicio7();ejercicio7.mostrarResultados(); break;
                        case 8: Ejercicio8 ejercicio8 = new Ejercicio8();ejercicio8.mostrarResultados(); break;
                        case 0:break;
                    }
                    Console.ReadKey();//para que no se cierre la app
                    Console.Clear();//que mejor cuando se resetea la pantalla
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error de ingreso!");
                }
                
                
            } while (op!=0);

        }
    }
}
