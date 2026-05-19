using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalPOO
{
    public class PedidoEventArgs : EventArgs
    {
        public Pedido Pedido { get; set; }
    }
}
