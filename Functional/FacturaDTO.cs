using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalPOO
{
    public record FacturaDTO(
        int PedidoId,
        string Cliente,
        decimal Total
    );
}
