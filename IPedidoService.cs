using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProyectoFinalPOO
{
    public interface IPedidoService
    {
        void CrearPedido(Pedido pedido);

        void AgregarProducto(
            Pedido pedido,
            Producto producto
        );

        decimal CalcularTotal(Pedido pedido);
    }
}