using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1Dev
{
    class ShoppingCart
    {
        public DateTime? FechaCompra { get; set; }
        public decimal? TotalCompra { get; set; }
        public List<Item> ListaItems { get; set; }
    }
    public class Item
    {
        public Item(string nombre, int cantidad, decimal precio)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
