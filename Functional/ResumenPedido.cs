using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalPOO.Functional
{
    // record es inmutable por naturaleza: una vez creado no se puede modificar
    public record ResumenPedido(
        int PedidoId,
        string NombreCliente,
        int CantidadProductos,
        decimal Total,
        decimal TotalConDescuento
    );
}
