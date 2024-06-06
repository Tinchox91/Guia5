using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia5_Funciones
{
    internal class Ejercicio3
    {
        public void bienvenida()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Bienvenid@ al programa !");
        }
        public void instrucciones()
        {
            Console.ForegroundColor= ConsoleColor.DarkGray;
            Console.WriteLine("Por favor siga las intrucciones...");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Instrucciones para lavarse las manos:\r\nSegún la Organización Mundial de la Salud (OMS):\r\n\r\nMoje sus manos con agua corriente limpia.\r\nAplique suficiente jabón en las manos para cubrir todas las superficies.\r\nFrote sus manos entre sí.\r\nFrote las palmas de las manos.\r\nEntrelace los dedos y frótelos.\r\nFrote el dorso de las manos con las palmas de las manos.\r\nFrote los pulgares con la palma de la mano opuesta.\r\nFrote la punta de los dedos con la palma de la mano opuesta.\r\nFrote sus manos durante al menos 20 segundos.\r\nEnjuague sus manos con agua corriente limpia.\r\nSeque sus manos con una toalla limpia o use un secador de manos.\r\nConsejos adicionales:\r\n\r\nUse jabón líquido, en barra o en polvo.\r\nSi no tiene agua y jabón disponibles, use un desinfectante para manos a base de alcohol con al menos un 60% de alcohol.\r\nLávese las manos con frecuencia, especialmente:\r\nAntes de comer o preparar alimentos.\r\nAntes y después de ir al baño.\r\nDespués de sonarse la nariz, toser o estornudar.\r\nDespués de cambiar pañales.\r\nDespués de tocar animales o sus desechos.\r\nDespués de tocar basura.\r\nDespués de estar en lugares públicos.");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Oprima ENTER para terminar...");
            Console.ReadKey();
        }
    }
}
