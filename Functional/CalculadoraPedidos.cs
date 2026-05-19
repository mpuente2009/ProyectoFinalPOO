using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoFinalPOO
{
    public static class CalculadoraPedidos
    {
        // FUNCIÓN PURA
        public static decimal AplicarDescuento(
            decimal total,
            decimal descuento)
        {
            return total - (total * descuento);
        }

        // LINQ WHERE + SELECT
        public static List<string>
            ObtenerProductosCostosos(
                List<Producto> productos,
                decimal minimo)
        {
            return productos
                .Where(p => p.Precio > minimo)
                .Select(p => p.Nombre)
                .ToList();
        }

        // AGGREGATE
        public static decimal
            CalcularTotalProductos(
                List<Producto> productos)
        {
            return productos.Aggregate(
                0m,
                (total, producto) =>
                    total + producto.Precio
            );
        }

        // FUNC<>
        public static decimal
            EjecutarOperacion(
                decimal valor,
                Func<decimal, decimal> operacion)
        {
            return operacion(valor);
        }
    }
}
