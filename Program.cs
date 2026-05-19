using ProyectoFinalPOO;
using ProyectoFinalPOO.Functional;
using ProyectoFinalPOO.WindsorConfig;

// ========================
// CONTENEDOR WINDSOR (IoC)
// ========================
var container = WindsorContainerConfig.Build();

IPedidoService pedidoService = container.Resolve<IPedidoService>();
IPagoService pagoService = container.Resolve<IPagoService>();


// Suscribirse a eventos del servicio real
var servicioReal = container.Resolve<PedidoService>();

servicioReal.PedidoCreado += (sender, e) =>
{
    Console.WriteLine($"[EVENTO] Pedido creado — ID: {e.PedidoId} | Cliente: {e.NombreCliente} | Productos: {e.CantidadProductos}");
};

servicioReal.StockActualizado += (sender, e) =>
{
    Console.WriteLine($"[EVENTO] Stock actualizado — {e.NombreProducto}: {e.StockAnterior} -> {e.StockNuevo}");
};

// ========================
// LÓGICA FUNCIONAL
// ========================
List<Producto> productos = new()
{
    new Producto("Hamburguesa", 25, 10),
    new Producto("Pizza", 40, 5),
    new Producto("Gaseosa", 8, 20)
};

var productosCostosos = CalculadoraPedidos.ObtenerProductosCostosos(productos, 20);
foreach (var nombre in productosCostosos)
    Console.WriteLine(nombre);

decimal total = CalculadoraPedidos.CalcularTotalProductos(productos);
decimal descuento = CalculadoraPedidos.EjecutarOperacion(total, t => t * 0.9m);
Console.WriteLine($"Total: {total}  |  Con descuento: {descuento}");

// Aggregate
string nombres = CalculadoraPedidos.ResumirNombres(productos);
Console.WriteLine($"Productos: {nombres}");

// ========================
// CREAR Y PROCESAR PEDIDO
// ========================
var cliente = new Cliente("Miguel");
var pedido = new Pedido(1, cliente);

foreach (var producto in productos)
    pedido.AgregarProducto(producto);

// record inmutable
ResumenPedido resumen = CalculadoraPedidos.GenerarResumen(pedido, t => t * 0.9m);
Console.WriteLine($"Resumen: Pedido #{resumen.PedidoId} | Cliente: {resumen.NombreCliente} | Total: {resumen.Total} | Con descuento: {resumen.TotalConDescuento}");

// Windsor invoca los interceptores automáticamente
// Los eventos se disparan dentro de CrearPedido
pedidoService.CrearPedido(pedido);

// Demostrar StockActualizado agregando un producto con el servicio real
servicioReal.AgregarProducto(pedido, new Producto("Jugo", 12, 8));

// ========================
// LIBERAR CONTENEDOR
// ========================
container.Dispose();