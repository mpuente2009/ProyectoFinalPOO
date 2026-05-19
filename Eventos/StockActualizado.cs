using System;
using System.Collections.Generic;
using System.Text;


namespace ProyectoFinalPOO.Eventos
{
    public class StockActualizadoEventArgs : EventArgs
    {
        public string NombreProducto { get; }
        public int StockAnterior { get; }
        public int StockNuevo { get; }

        public StockActualizadoEventArgs(string nombreProducto, int stockAnterior, int stockNuevo)
        {
            NombreProducto = nombreProducto;
            StockAnterior = stockAnterior;
            StockNuevo = stockNuevo;
        }
    }
}