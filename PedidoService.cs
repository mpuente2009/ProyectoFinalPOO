using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProyectoFinalPOO
{
   
    
    public class PedidoService : IPedidoService
    {

        public event EventHandler<PedidoEventArgs>
        PedidoCreado;

        public event EventHandler<StockEventArgs>
        StockActualizado;
        public void CrearPedido(Pedido pedido)
        {
            Console.WriteLine(">>> Creando pedido en el servicio real");

            Console.WriteLine($"Pedido ID: {pedido.Id}");
            Console.WriteLine($"Cliente: {pedido.Cliente.Nombre}");
            Console.WriteLine($"Productos: {pedido.Productos.Count}");

        }

        public void AgregarProducto(
            Pedido pedido,
            Producto producto)
        {
            if (producto.Stock <= 0)
            {
                throw new Exception(
                    $"No hay stock de {producto.Nombre}"
                );
            }

            pedido.AgregarProducto(producto);

            producto.Stock--;
        }

        public decimal CalcularTotal(Pedido pedido)
        {
            return pedido.Productos.Sum(
                p => p.Precio
            );
        }
    }
}