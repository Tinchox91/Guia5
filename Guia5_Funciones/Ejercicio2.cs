using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia5_Funciones
{
    internal class Ejercicio2
    {
        static public int cuadrado(int num)
        {
            int total = num * num;
          


        return total; } public void potenciar()
        {
            string num = "";
            Boolean val=false;  
            do
            {
                Console.ForegroundColor = ConsoleColor.White;//Cambio de color a blanco
                val = false;
                Console.Write("ingrese un numero de un digito(0-9) o'N' para salir: ");//pido el numero
                num = Console.ReadLine();//lo leo
                num=num.ToLower();//convierto en minusculas
                try//por si el usuario ingresa caracteres erroneos uso try/catch
                {
                    if (num.Equals("n"))//comparo de que ingrese 'n'
                    {
                        val = true;
                        break;
                    }
                    else//si no ingresa 'n' sigo adelante
                    {
                        int numParse = int.Parse(num);//convierto la variable num en int
                        if (numParse >= 0 && numParse < 9)//me aseguro que el numero sea del 0 al 9
                        {
                            int total = cuadrado(numParse);
                            Console.ForegroundColor = ConsoleColor.Green;   
                            Console.WriteLine($"El cuadraado de {num} es: {total}");
                            val = false;
                        }
                        else {//por si se ingresa numero no admitido
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Valor no admitido..."); 
                        }
                        
                    }
                }
                catch (Exception)//en caso de que se ingrese caracteres erroneos ...
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error al ingresar!");
                    

                }
               
                
               

            } while (!val);
       
               
            
        
        }
    }
}
