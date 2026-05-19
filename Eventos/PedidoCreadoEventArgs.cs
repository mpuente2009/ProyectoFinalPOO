using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalPOO.Eventos
{
    public class PedidoCreadoEventArgs : EventArgs
    {
        public int PedidoId { get; }
        public string NombreCliente { get; }
        public int CantidadProductos { get; }

        public PedidoCreadoEventArgs(int pedidoId, string nombreCliente, int cantidadProductos)
        {
            PedidoId = pedidoId;
            NombreCliente = nombreCliente;
            CantidadProductos = cantidadProductos;

        }
    }

}
