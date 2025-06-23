using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Class1
    {
        string[] n1 = {"ENCENDIDO","APAGADO","ALERTA" };
        float tem, humo;
        string luces, sensores;
        public void Seleccion()
        {
            int op;
            do
            {
                Piso1();
                Console.ForegroundColor= ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t\t******SELECCIONE EL LUGAR A REVISAR******\n");
                Console.ResetColor();
                Console.WriteLine("\n\t*1.TEMPERATURA GENERAL");
                Console.WriteLine("\t*2.SECCIÓN A");
                Console.WriteLine("\t*3.SECCIÓN B");
                Console.WriteLine("\t*4.ALMACEN PRINCIPAL");
                Console.WriteLine("\t*5.SECCIÓN C");
                Console.WriteLine("\t*6.SECCIÓN D");
                Console.WriteLine("\t*7.SECCIÓN E");
                Console.WriteLine("\t*0.SALIR\n");
                Console.WriteLine("\tSELECCIONE UNA OPCIÓN: ");
                op = int.Parse(Console.ReadLine());
                MostrarDatos(op);
                Console.Clear();
                Console.ReadKey();
            }
            while (op!=0);


        }
        private void Piso1()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t╔═════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t║                        |                  ║                                                             ║");
            Console.WriteLine("\t║                        |                  ║     ╔═══════════════════════════════════════════════════╗   ║");
            Console.WriteLine("\t║        SECCIÓN A       |     SECCIÓN B    ║     ║                                                   ║   ║");
            Console.WriteLine("\t║        (SENSOR 2)      |    (SENSOR 3)    ║     ║                                                   ║   ║");
            Console.WriteLine("\t║                        |                  ║     ║                                                   ║   ║");
            Console.WriteLine("\t║                        |                  ║     ║                                                   ║   ║");
            Console.WriteLine("\t║                        |                  ║     ║                                                   ║   ║");
            Console.WriteLine("\t╠══════════  ═════════════════════  ════════╝     ║                                                   ║   ║");
            Console.WriteLine("\t║                                               S ║                                                   ║   ║");
            Console.WriteLine("\t║   ╔═════════════════════════════════════════╗ E ║                   ALMACEN PRINCIPAL               ║   ║");
            Console.WriteLine("\t║   ║                                         ║ N ║                      (SENSOR 4)                   ║   ║");
            Console.WriteLine("\t║   ║                SECCIÓN C                ║ S ║                                                   ║   ║");
            Console.WriteLine("\t║   ║               (SENSOR 5)                ║ O ║                                                   ║   ║");
            Console.WriteLine("\t║   ║                                         ║ R ║                                                   ║   ║");
            Console.WriteLine("\t║   ╚═════════════════   ═════════════════════╝   ╚═════════════════════════    ══════════════════════╝   ║");
            Console.WriteLine("\t║                                               1                                                         ║");
            Console.WriteLine("\t║   ╔═════════════════════════════════════════╗   ╔═══════════════════════════════════════════════════╗   ║");
            Console.WriteLine("\t║   ║                                         ║   ║                                                   ║   ║");
            Console.WriteLine("\t║   ║             SECCIÓN D                   ║   ║                  SECCIÓN E - (SENSOR 7)           ║   ║");
            Console.WriteLine("\t║   ║             (SENSOR 6)                  ║   ║                                                   ║   ║");
            Console.WriteLine("\t║   ╚═════════════════════════════════════════╝   ╚═════════════════════════    ══════════════════════    ║");
            Console.WriteLine("\t║                                                                                                         ║");
            Console.WriteLine("\t║                                                                                                         ║");
            Console.WriteLine("\t╚═════════════════════════════════════════════════════════════════════════════════════════════════════════╝\n");
            Console.ResetColor();
        }
        internal void MostrarDatos(int op)
        {
            Console.Clear();
            switch (op)
            {
                case 0:
                    Console.WriteLine("SALIENDO ...");
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\t\t\t\t*****TEMPERATURA GENERAL*****\n");
                    Console.ResetColor();
                    Datos();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\tTEMPERATURA GENERAL");
                    Console.ResetColor();
                    Datos();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\tTEMPERATURA GENERAL");
                    Console.ResetColor();
                    Datos();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\tTEMPERATURA GENERAL");
                    Console.ResetColor();
                    Datos();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\tTEMPERATURA GENERAL");
                    Console.ResetColor();
                    Datos();
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\tTEMPERATURA GENERAL");
                    Console.ResetColor();
                    Datos();
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\tTEMPERATURA GENERAL");
                    Console.ResetColor();
                    Datos();
                    break;
                default:
                    Console.WriteLine("INGRESE UN VALOR VALIDO");
                    break;
            }
            Console.ReadLine();
        }
        internal void Datos()
        {
            Console.Clear();
            Random r = new Random();
            tem = r.Next(20,200);
            Random r1 = new Random();
            humo = r1.Next(0, 51);

            if (tem >57)
            {
                Console.WriteLine("\t\t╔════════════════════════╦════════════════════════╦════════════════════════════╗");
                Console.WriteLine("\t\t║                        ║                        ║                            ║");
                Console.WriteLine("\t\t║      TEMPERATURA       ║        SENSORES        ║    LUCES ESTROBOSCÓPICAS   ║");
                Console.WriteLine("\t\t║                        ║                        ║                            ║");
                Console.WriteLine("\t\t╠════════════════════════╬════════════════════════╬════════════════════════════╣");
                Console.WriteLine("\t\t║                        ║                        ║                            ║");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t║\t  " + tem + "°C\t\t ║\t  " + n1[0] + "\t  ║\t  " + n1[0] + "\t       ║");
                Console.ResetColor();
                Console.WriteLine("\t\t║                        ║                        ║                            ║");
                Console.WriteLine("\t\t╚════════════════════════╩════════════════════════╩════════════════════════════╝\n");
                Console.ResetColor();
                Evacuacón(tem, humo);

            }
            else if (tem>30 & tem<57 )
            {
                Console.WriteLine("\t\t╔════════════════════════╦════════════════════════╦════════════════════════════╗");
                Console.WriteLine("\t\t║                        ║                        ║                            ║");
                Console.WriteLine("\t\t║      TEMPERATURA       ║        SENSORES        ║    LUCES ESTROBOSCÓPICAS   ║");
                Console.WriteLine("\t\t║                        ║                        ║                            ║");
                Console.WriteLine("\t\t╠════════════════════════╬════════════════════════╬════════════════════════════╣");
                Console.WriteLine("\t\t║                        ║                        ║                            ║");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t║\t  " + tem + "°C\t\t ║\t  " + n1[2] + "\t  ║\t  " + n1[2] + "\t       ║");
                Console.ResetColor();
                Console.WriteLine("\t\t║                        ║                        ║                            ║");
                Console.WriteLine("\t\t╚════════════════════════╩════════════════════════╩════════════════════════════╝\n");
                Console.ResetColor();
                Evacuacón(tem, humo);
            }
            else
            {
                Console.WriteLine("\t\t╔════════════════════════╦════════════════════════╦════════════════════════════╗");
                Console.WriteLine("\t\t║                        ║                        ║                            ║");
                Console.WriteLine("\t\t║      TEMPERATURA       ║        SENSORES        ║    LUCES ESTROBOSCÓPICAS   ║");
                Console.WriteLine("\t\t║                        ║                        ║                            ║");
                Console.WriteLine("\t\t╠════════════════════════╬════════════════════════╬════════════════════════════╣");
                Console.WriteLine("\t\t║                        ║                        ║                            ║");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t║\t  " + tem + "°C\t\t ║\t  " + n1[1] + "\t  ║\t  " + n1[1] + "\t       ║");
                Console.ResetColor();
                Console.WriteLine("\t\t║                        ║                        ║                            ║");
                Console.WriteLine("\t\t╚════════════════════════╩════════════════════════╩════════════════════════════╝\n");
                Console.ResetColor();
                Evacuacón(tem, humo);
            }
        }
        public void Evacuacón(float temp, float humo)
        {
            if (temp > 57 )
            {
                SoundPlayer sonido = new SoundPlayer("ALARMA.wav");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t\t\t   ¡EVACUAR INMEDIATAMENTE!\n");
                Console.WriteLine("\t\t\t\t\t    LLAMANDO A EMERGENCIAS");
                sonido.Play();
                Thread.Sleep(20000);
                sonido.Stop();
            }
            else if (temp > 40)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\t\t\t\t ¡Posible incendio! Verificar área");
            }
            else if (temp > 50 || humo > 30)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t   Condiciones anormales - Monitorear");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t\t\t   NO HAY NINGUN RASTRO DE INCENDIOS");
                Console.ResetColor();
            }
        }

    }
}
