using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1Dev
{
    public class Menu:Crud
    {
        string opcion = "";

        public void inicio()
        {
            do
            {
                encabezado();
            } while (opcion != "0");
        }

        private void encabezado()
        {
            Console.WriteLine("----- Menú Principal -----");
            Console.WriteLine("\n");
            Console.WriteLine("1 [Agregar Item]");
            Console.WriteLine("2 [Listar Items]");
            Console.WriteLine("3 [Ver total]");
            Console.WriteLine("4 [Comprar]");
            Console.WriteLine("0 [Salir]");
            Console.WriteLine("\n");
            Console.WriteLine("Selecciones una opción");
            opcion = Console.ReadLine();
            seleccion_menu(opcion);
        }

        public void seleccion_menu(string op)
        {
            if (op == "")
            {

            }
            switch (op)
            {
                case "1":
                    Console.Clear();
                    AgregarItem();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    lista();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    TotalCompra();
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    if (Comprar())
                    {
                        limpiar_Carrito();
                    }
                    retornar_menu();
                    Console.ReadKey();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                case "r":
                    Console.Clear();
                    encabezado();
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Selección invalida");
                    break;
            }
        }

        public void retornar_menu()
        {
            string op;
            Console.WriteLine("presiones r para retornar al menú principal");
            op = Console.ReadLine();
            seleccion_menu(op);
        }
    }
}
