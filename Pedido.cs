using System;
using System.Collections.Generic;
using System.Text;

using System.Collections.Generic;

namespace ProyectoFinalPOO
{
    public class Pedido
    {
        public int Id { get; set; }

        public Cliente Cliente { get; set; }

        private List<Producto> productos = new();

        public IReadOnlyList<Producto> Productos => productos;

        public Pedido(int id, Cliente cliente)
        {
            Id = id;
            Cliente = cliente;
        }

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }
    }
}