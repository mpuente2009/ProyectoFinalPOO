using ProyectoFinalPOO;

List<Producto> productos = new()
{
    new Producto("Hamburguesa", 25, 10),
    new Producto("Pizza", 40, 5),
    new Producto("Gaseosa", 8, 20)
};

var productosCostosos =
    CalculadoraPedidos
        .ObtenerProductosCostosos(
            productos,
            20);

foreach (var nombre in productosCostosos)
{
    Console.WriteLine(nombre);
}

decimal total =
    CalculadoraPedidos
        .CalcularTotalProductos(
            productos);

Console.WriteLine(
    $"Total: {total}"
);

decimal descuento =
    CalculadoraPedidos
        .EjecutarOperacion(
            total,
            t => t * 0.9m
        );

Console.WriteLine(
    $"Con descuento: {descuento}"
);
