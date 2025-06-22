using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MiBiblioteca; 

namespace SistemaContraIncendios
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.Clear();
            MenuPrincipal();
            Console.ReadKey();
        }
        static void MenuPrincipal()
        {
            int piso;
            do
            {
                Console.Clear();
                Pisos();
                Console.WriteLine("***PRECIONA 0 PARA SALIR***");
                Console.WriteLine("SELECCIONE UN PISO: ");
                piso = int.Parse(Console.ReadLine());

                    switch (piso)
                    {
                        case 0:
                            Console.WriteLine("*****ADIOS*****");
                            break;
                        case 1:
                            Piso1();
                            break;
                        case 2:
                            Piso2();
                            break;
                        case 3:
                            break;
                        default:
                        Console.WriteLine("INGRESE UN PISO VALIDO");
                        break;
                    }
                Console.ReadLine();
            }
            while (piso!=0);
        }
        static void Pisos()
        {
            string[] Pisos = { "Piso 1", "Piso 2", "Piso3" };
            Console.WriteLine("\t╔═══════════════════════════════════════╗");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t" + Pisos[2] + "\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t╠═══════════════════════════════════════╣");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t" + Pisos[1] + "\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t╠═══════════════════════════════════════╣");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t" + Pisos[0] + "\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t║\t\t\t\t\t║");
            Console.WriteLine("\t╚═══════════════════════════════════════╝\n");
        }
        static void Piso1()
        {
            Console.Clear();
            Class1 n1 = new Class1();
            n1.Seleccion();
            Console.ReadKey();
        }
        static void Piso2()
        {
            Console.Clear();
            Piso2 n2= new Piso2();
            n2.Seleccion();
            Console.ReadKey();
        }
        static void Piso3()
        {
            Console.Clear();
            Piso3 n3= new Piso3();
            n3.Seleccion();
            Console.ReadKey();
        }
    }
}
