using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void system(string x)
        {

            if (x == "pause" || x == "Pause" || x == "PAUSE")
            {
                Console.Write("\npresione una tecla para continuar...");
                Console.ReadKey();
            }
            else if (x == "end" || x == "End" || x == "END")
            {

                Console.Clear();
                Console.Write("\n\n\nprecione una tecla para finalizar...");
                Console.ReadKey();
            }
            else
            {
                string p = "N";
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.Error.WriteLine("Error de funcion...");
                Console.Write("error al escribir la funcion 'system();'\n\nquieres saber las soluciones?[Y/N]\nroot~admin:: ");
                
                p = Convert.ToString(Console.ReadLine());

                if (p == "Y"||p == "y")
                {
                    Console.WriteLine("\n\npuede ser un problema de dedo como escribir pauSe o eNd o algo asi\npuede ser un problema de error de sintaxis\npuede ser un problema de la programacion de la funcion\n");
                }

                else
                {
                }

                Console.ReadKey();
            }


        }

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            int cont = 0;
            int numObjetos = 0;
            List<string> objetos = new List<string>(numObjetos);
            int numOp;
            bool flag = false;


            do
            {
                if (objetos.Count == 0)
                {
                    flag = false;
                }
                else
                {
                    flag = true;
                }

                Console.Clear();

                Console.Write("-----------------------------inserta una de las siguientes opciones-----------------------------\n\n\n\n\ningresa 1 si quieres insertar cosas en la lista\ningresa 2 si quieres eliminar cosas de la lista\ninserta 3 si quieres ver los objetos de la lista\ninserta 0 si quieres salir\n\n\nroot~admin::");
                numOp = Convert.ToInt16(Console.ReadLine());

                switch (numOp)
                {

                    case 1:
                        Console.Clear();


                        Console.Write("-----------------------------inserta una de las siguientes opciones-----------------------------\n\n\n\n\ncuantos objetos desea ingresar?\n\nroot~admin::");
                        numObjetos = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");

                        numObjetos = numObjetos + cont;

                        for (;cont < numObjetos;cont++){
                            Console.Write("ingrese el objeto "+(1 + cont)+" :");
                            objetos.Add(Console.ReadLine());
                        }
                        break;
                    case 2:

                     

                        Console.Clear();  
                        

                        int remo;
                        if (flag == true) {

                            do
                            {

                                for (int i = 0;i < objetos.Count;i++) {

                                    Console.WriteLine((i+1)+": "+objetos[i]);
                                }

                                Console.WriteLine("\n\n\nobjeto a eliminar: ");
                                remo = Convert.ToInt32(Console.ReadLine());

                                if (remo > 0)
                                {
                                    remo--;
                                    objetos.RemoveAt(remo);

                                }
                                else
                                {
                                    Console.WriteLine("ingrese un valor valido");
                                    system("pause");
                                }
                            } while (remo < 0);
                        }
                        else
                        {
                            Console.WriteLine("no hay objetos en la lista Nya!!!!!");
                            system("pause");
                        }
                        break;

                    case 3:

                        Console.Clear();

                        if (flag == true) {

                            Console.WriteLine("-----------------------------elementos de la lista-----------------------------\n\n\n");
                            for (int i = 0; i < objetos.Count; i++) {

                                Console.WriteLine((i + 1) + ": " + objetos[i]);

                            }

                            system("pause");
                        }
                        else
                        {
                            Console.Write("no hay objetos en la lista Nya!!!!!\n");
                            system("pause");
                        }
                        break;
                    default:

                        system("END");

                        break;
                }


            } while (numOp != 0);

        }
    }
}