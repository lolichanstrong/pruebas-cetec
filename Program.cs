using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abarrotesFinal
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
                Console.WriteLine("\n\n");
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
                if (p == "Y" || p == "y")
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

            int valor_switchBucle = 0,valor_numLista = 0;
            List<string> lista = new List<string>(0);

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            do {

                Console.Clear();

                Console.Write("\n\n\n\n1.-ingresar productos al carrito\n2.-ver los productos del carrito\n3.-eliminar 1 producto del carrito\n4.-eliminar carrito\n0.-salir\n\nrespuesta: ");
                valor_switchBucle = Convert.ToInt16(Console.ReadLine());

                switch (valor_switchBucle) {
                    case 1:

                        Console.Clear();

                        Console.Write("ingresa la cantidad de objetos que deseas ingresar: ");
                        valor_numLista = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0;i < valor_numLista;i+=1) {
                            Console.Write("["+(1+i)+"]: ");
                            lista.Add(Console.ReadLine());

                        }

                        break;

                        case 2:
                        Console.Clear();
                        Console.Write("\n\n\n\n");

                        if (lista.Count != 0)
                        {

                            int contador_foreachCase2 = 1;
                            foreach (string prod_case2 in lista)
                            {
                                Console.WriteLine("[" + contador_foreachCase2 + "]: " + prod_case2);
                                contador_foreachCase2++;

                            }

                        }
                        else
                        {
                            Console.Write("la lista esta vacia\n\n");
                        }

                        system("pause");

                        break;

                    case 3:

                        Console.Clear();
                        Console.Write("\n\n");

                        if (lista.Count != 0)
                        {

                            int contador_foreachCase2 = 1;
                            foreach (string prod_case2 in lista)
                            {
                                Console.WriteLine("[" + contador_foreachCase2 + "]: " + prod_case2);
                                contador_foreachCase2++;

                            }
                            Console.WriteLine("\n\n\n\nnumero de producto a eliminar: ");
                            int eliminar_prod = Convert.ToInt32(Console.ReadLine());

                            if (eliminar_prod > 0 && eliminar_prod < (lista.Count + 1)) {
                                eliminar_prod--;
                                lista.RemoveAt(eliminar_prod);
                            }
                            else
                            {
                                Console.WriteLine("\n\nel valor no es valido\n\n");
                            }

                        }
                        else
                        {
                            Console.Write("la lista esta vacia\n\nno hay nada que eliminar\n\n");
                        }

                        system("pause");

                        break;

                    case 4:

                        Console.Clear();

                        if (lista.Count > 0)
                        {
                            Console.Write("\n\n\nenserio desea eliminar el carrito por completo(s/n)?");
                            char elim_desCase5 = Convert.ToChar(Console.ReadLine());
                            if (elim_desCase5 == 's' || elim_desCase5 == 'S' || elim_desCase5 == 'y' || elim_desCase5 == 'Y')
                            {
                                Console.Clear(); Console.WriteLine("\n\n\nlista eliminada");

                            }
                            else if (elim_desCase5 == 'N' || elim_desCase5 == 'n')
                            {

                                Console.WriteLine("\n\n\nokey\n");

                            }
                        }
                        else {
                            Console.Write("\n\n\nla lista ya esta vacia y no se puede eliminar\n\n");
                        }

                        system("pause");

                        break;

                    case 0:

                        Console.Clear();

                        Console.Write("\n\nenserio desea finalizar(s/n)? ");
                        char fin_programaChar = Convert.ToChar(Console.ReadLine());
                        if (fin_programaChar == 's' || fin_programaChar == 'S' || fin_programaChar == 'y' || fin_programaChar == 'Y'){
                            system("end");
                        }
                        else {
                            Console.WriteLine("\n\n\nokey\n\n");
                            system("pause");
                            valor_switchBucle = 10;
                        }


                        break;
                }

            }while (valor_switchBucle != 0);
            
        }
    }
}
