using ProyectoFinalPOO.Eventos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace ProyectoFinalPOO
{
   
    
    public class PedidoService : IPedidoService
    {

        public event EventHandler<PedidoCreadoEventArgs> PedidoCreado;
        public event EventHandler<StockActualizadoEventArgs> StockActualizado;
        public void CrearPedido(Pedido pedido)
        {
            Console.WriteLine($">>> Creando pedido #{pedido.Id} para {pedido.Cliente.Nombre}");

            // Disparar evento PedidoCreado
            PedidoCreado?.Invoke(this, new PedidoCreadoEventArgs(
                pedido.Id,
                pedido.Cliente.Nombre,
                pedido.Productos.Count
            ));

        }

        public void AgregarProducto(Pedido pedido, Producto producto)
        {
            if (producto.Stock <= 0)
                throw new Exception($"No hay stock de {producto.Nombre}");

            int stockAnterior = producto.Stock;
            pedido.AgregarProducto(producto);
            producto.Stock--;

            // Disparar evento StockActualizado
            StockActualizado?.Invoke(this, new StockActualizadoEventArgs(
                producto.Nombre,
                stockAnterior,
                producto.Stock
            ));
        }

        public decimal CalcularTotal(Pedido pedido)
        {
            return pedido.Productos.Sum(
                p => p.Precio
            );
        }
    }
}