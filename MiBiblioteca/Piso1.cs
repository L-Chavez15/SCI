using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Piso1
    {
        public void Dato1()
        {
            Console.WriteLine("\t╔═════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t║                                                                                                         ║");
            Console.WriteLine("\t║   ╔═════════════════════════════════════════╗   ╔═══════════════════════════════════════════════════╗   ║");
            Console.WriteLine("\t║   ║                     |                   ║   ║                                                   ║   ║");
            Console.WriteLine("\t║   ║      SS.HH          |      SS.HH        ║   ║                                                   ║   ║");
            Console.WriteLine("\t║   ║      DAMAS          |    CABALLEROS     ║   ║                                                   ║   ║");
            Console.WriteLine("\t║   ║     (SENSOR 2)      |     SENSOR 3)     ║   ║                                                   ║   ║");
            Console.WriteLine("\t║   ║                     |                   ║   ║                                                   ║   ║");
            Console.WriteLine("\t║   ╚════════  ═════════════════════  ════════╝   ║                                                   ║   ║");
            Console.WriteLine("\t║                                               S ║                                                   ║   ║");
            Console.WriteLine("\t║   ╔═════════════════════════════════════════╗ E ║                       COMEDOR                     ║   ║");
            Console.WriteLine("\t║   ║                                         ║ N ║                      (SENSOR 4)                   ║   ║");
            Console.WriteLine("\t║   ║                SECCIÓN A                ║ S ║                                                   ║   ║");
            Console.WriteLine("\t║   ║               (SENSOR 4)                ║ O ║                                                   ║   ║");
            Console.WriteLine("\t║   ║                                         ║ R ║                                                   ║   ║");
            Console.WriteLine("\t║   ╚═════════════════════════════════════════╝   ║                                                   ║   ║");
            Console.WriteLine("\t║                                               1 ║                                                   ║   ║");
            Console.WriteLine("\t║   ╔═════════════════════════════════════════╗   ╚═════════════════════════    ══════════════════════╝   ║");
            Console.WriteLine("\t║   ║                                         ║                                                           ║");
            Console.WriteLine("\t║   ║             PARTIDAS LISTAS             ║   ╔═══════════════════════════════════════════════════╗   ║");
            Console.WriteLine("\t║   ║                                         ║   ║                                                   ║   ║");
            Console.WriteLine("\t║   ╚═════════════════════════════════════════╝   ║             ALMACEN DE ACABADOS                   ║   ║");
            Console.WriteLine("\t║                                                 ║               (Sección C)                         ║   ║");
            Console.WriteLine("\t║                                                 ║                                                   ║   ║");
            Console.WriteLine("\t║                                                 ╚═══════════════════════════════════════════════════╝   ║");
            Console.WriteLine("\t║                                                                                                         ║");
            Console.WriteLine("\t╚═════════════════════════════════════════════════════════════════════════════════════════════════════════╝\n");
            Console.ReadKey();
            Console.Clear();
            float tem;
            Random R = new Random();
            tem = R.Next(20, 200);
            float humo;
            Random R1 = new Random();
            humo = R1.Next(0, 51);
            Piso1 n1 = new Piso1();

            if (tem > 50)
            {
                Console.WriteLine("\t╔════════════════════════╦════════════════════════╦════════════════════════════╗");
                Console.WriteLine("\t║                        ║                        ║                            ║");
                Console.WriteLine("\t║      TEMPERATURA       ║        SENSORES 1      ║    LUCES ESTROBOSCÓPICAS   ║");
                Console.WriteLine("\t║                        ║                        ║                            ║");
                Console.WriteLine("\t╠════════════════════════╬════════════════════════╬════════════════════════════╣");
                Console.WriteLine("\t║                        ║                        ║                            ║");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t║\t  " + tem + "°C" + "\t\t ║\t  ENCENDIDO\t  ║\t  ENCENDIDO\t       ║");
                Console.ResetColor();
                Console.WriteLine("\t║                        ║                        ║                            ║");
                Console.WriteLine("\t╚════════════════════════╩════════════════════════╩════════════════════════════╝");
                Evacuacón(tem, humo);
            }

            else
            {
                Console.WriteLine("\t╔════════════════════════╦════════════════════════╦════════════════════════════╗");
                Console.WriteLine("\t║                        ║                        ║                            ║");
                Console.WriteLine("\t║      TEMPERATURA       ║        SENSORES        ║    LUCES ESTROBOSCÓPICAS   ║");
                Console.WriteLine("\t║                        ║                        ║                            ║");
                Console.WriteLine("\t╠════════════════════════╬════════════════════════╬════════════════════════════╣");
                Console.WriteLine("\t║                        ║                        ║                            ║");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t║\t  " + tem + "°C" + "\t\t ║\t  APAGADO\t  ║\t  APAGADO\t       ║");
                Console.ResetColor();
                Console.WriteLine("\t║                        ║                        ║                            ║");
                Console.WriteLine("\t╚════════════════════════╩════════════════════════╩════════════════════════════╝");
                Evacuacón(tem, humo);
            }
        }
        public void Evacuacón(float temp, float sensores)
        {
            if (temp > 80 || sensores > 70)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t\t\t¡EVACUAR INMEDIATAMENTE!");
                Console.WriteLine("\t\t\t\t\t LLAMANDO A EMERGENCIAS");
            }
            else if (temp > 70 || sensores > 50)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("¡Posible incendio! Verificar área");
            }
            else if (temp > 50 || sensores > 30)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Condiciones anormales - Monitorear");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t NO HAY NINGUN RASTRO DE INCENDIOS");
            }
            Console.ResetColor();
        }
        public void eleccion(int op)
        {
            do
            {
                Console.Clear();
                if (op == 1)
                {
                    Console.WriteLine("\t\t*****SELECCIONE EL LUGAR A ANALIZAR *****");
                    Console.WriteLine("1.APARTADO GENERAL");
                    Console.WriteLine("2.SS.HH DAMAS");
                    Console.WriteLine("3.SS.HH CABALLEROS");
                    Console.WriteLine("4.SECCIÓN A");
                    Console.WriteLine("5.ALMACEN DE ACABADOS\n");
                    int opcion = int.Parse(Console.ReadLine());
                    Console.WriteLine("SELECCIONASTE LA OPCIÓN: ");

                }
                else if (op == 2)
                {


                }
                else
                {
                    Console.WriteLine("Opción no válida, por favor intente de nuevo.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Dato1();

                }
                Console.ReadKey();
            }
            while (op != 2);


        }
    }
}
