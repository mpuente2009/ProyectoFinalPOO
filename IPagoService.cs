using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalPOO
{
    public interface IPagoService
    {
        void ProcesarPago(Pedido pedido);
    }
}
