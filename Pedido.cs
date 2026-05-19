using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalPOO
{
    namespace ProyectoFinalPOO
    {
        public class Producto
        {
            public string Nombre { get; set; }

            public decimal Precio { get; set; }

            public int Stock { get; set; }

            public Producto(string nombre, decimal precio, int stock)
            {
                Nombre = nombre;
                Precio = precio;
                Stock = stock;
            }
        }
    }
}
