using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1Dev
{
    public class Crud
    {
        ShoppingCart cart = new ShoppingCart()
        {
            FechaCompra = null,
            ListaItems = new List<Item>(),
            TotalCompra = null
        };
        string nombre;
        int cantidad;
        decimal precio;

        public void AgregarItem()
        {
            Console.WriteLine("----------------------- Crear Item -----------------------");
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad");
            cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el precio por unidad");
            precio = decimal.Parse(Console.ReadLine());

            cart.ListaItems.Add(new Item(nombre, cantidad, precio));

            Console.WriteLine("\n");
            Console.WriteLine("--------------------- Datos Guardados ---------------------");
        }

        private decimal ObtenerTotalCompra()
        {
            decimal total = 0;
            total = cart.ListaItems.Sum(x => x.Cantidad* x.Precio);
            return total;
        }

        public void TotalCompra()
        {
            Console.WriteLine("El total a pagar seria {0}", ObtenerTotalCompra().ToString("C"));
        }

        private int ObtenerCantidadDeItems()
        {
            return cart.ListaItems.Count;
        }

        private int ObtenerTotalDeItems()
        {
            return cart.ListaItems.Sum(x => x.Cantidad);
        }

        public bool Comprar()
        {
            if (lista_vacia())
            {
                Console.WriteLine("Aun no a agregado elementos al carrito");
                return false;
            }
            else
            {
                string respuesta = "";
                Console.WriteLine("Desea continuar con la compra:");
                Console.WriteLine("1 Si");
                Console.WriteLine("2 No");
                respuesta = Console.ReadLine();
                int num = 0;
                if (int.TryParse(respuesta, out num))
                {
                    num = int.Parse(respuesta);
                    if (num == 1)
                    {
                        DetallesCompra();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Selección invalida");
                    return false;
                }
            }
        }

        public void DetallesCompra()
        {
            cart.FechaCompra = DateTime.Now;
            cart.TotalCompra = ObtenerTotalCompra();
            Console.WriteLine(cart.FechaCompra.ToString());
            Console.WriteLine("\n");
            Console.WriteLine("Usted ha comprado lo siguiente:");
            Console.WriteLine("\n");
            lista();
            Console.WriteLine("\n");
            Console.WriteLine("un total de {0} elementos distintos", ObtenerCantidadDeItems());
            Console.WriteLine("en total {0} elementos", ObtenerTotalDeItems());
            Console.WriteLine("\n");
            Console.WriteLine("Con un costo de {0} ", cart.TotalCompra.Value.ToString("C"));
        }

        public void lista()
        {
            if (!lista_vacia())
            {
                Console.WriteLine("---- Lista ----");
                foreach (var item in cart.ListaItems)
                {
                    Console.WriteLine("_________________________");
                    Console.WriteLine("| Nombre: {0} | Cantidad: {1} | Precio: {2}", item.Nombre, item.Cantidad, item.Precio);
                }
            }
            else
            {
                Console.WriteLine("no hay ningún dato registrado");
            }
        }

        private bool lista_vacia()
        {
            //if (cart.ListaItems.Count == 0)
            //    return true;
            //else
            //    return false;

            return cart.ListaItems.Count == 0;
        }

        public void limpiar_Carrito()
        {
            cart = new ShoppingCart()
            {
                FechaCompra = null,
                ListaItems = new List<Item>(),
                TotalCompra = null
            };
        }
    }
}
