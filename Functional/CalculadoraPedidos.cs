using ProyectoFinalPOO.Functional;
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

        // Aggregate: acumula un string con los nombres de los productos
        public static string ResumirNombres(List<Producto> productos)
        {
            return productos.Aggregate(
                "",
                (acumulado, p) => acumulado == ""
                    ? p.Nombre
                    : acumulado + ", " + p.Nombre
            );
        }

        // Función pura que retorna un record inmutable con el resumen del pedido
        public static ResumenPedido GenerarResumen(Pedido pedido, Func<decimal, decimal> aplicarDescuento)
        {
            decimal total = pedido.Productos.Sum(p => p.Precio);

            return new ResumenPedido(
                pedido.Id,
                pedido.Cliente.Nombre,
                pedido.Productos.Count,
                total,
                aplicarDescuento(total)
            );
        }
    }
}
