using System;
using System.Collections.Generic;
using System.Text;


namespace ProyectoFinalPOO
{
    public class StockEventArgs : EventArgs
    {
        public Producto Producto { get; set; }

        public int StockRestante { get; set; }
    }
}