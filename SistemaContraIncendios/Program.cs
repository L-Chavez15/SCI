using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiBiblioteca; 

namespace SistemaContraIncendios
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static void pisos()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                //Console.WriteLine("\t=================================");
                Console.WriteLine("\t*****SISTEMA CONTRA INCENDIOS*****    ");
                //Console.WriteLine("\t=================================\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t╔═══════════════════════════════════════╗");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\tPISO 3\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t╠═══════════════════════════════════════╣");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\tPISO 2\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t╠═══════════════════════════════════════╣");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\tPISO 1\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t║\t\t\t\t\t║");
                Console.WriteLine("\t╚═══════════════════════════════════════╝\n");
                Console.ResetColor();
                string opcion;

                Console.WriteLine("INGRESE EL PISO A INSPECCIONAR:  ");
                opcion = Console.ReadLine();
            }
        }
        static void Piso1()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\t\t=========================================");
            Console.WriteLine("\t\t\t\t\t\t\t   PISO 1");
            Console.WriteLine("\t\t\t\t\t=========================================\n");
            Console.ResetColor();
            Piso1 n1 = new Piso1();
            n1.Dato1();

            Console.WriteLine("DESEA INSPECCIONAR UN APARTADO EN ESPECÍFICO ");
            Console.WriteLine("*1.si");
            Console.WriteLine("*2.no");
            int respuesta = int.Parse(Console.ReadLine().ToUpper());
            n1.eleccion(respuesta);
            Console.ReadKey();
        }
    }
}
