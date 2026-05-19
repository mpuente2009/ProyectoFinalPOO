using Castle.DynamicProxy;
using ProyectoFinalPOO;
using ProyectoFinalPOO.AOP;

List<Producto> productos = new()
{
    new Producto("Hamburguesa", 25, 10),
    new Producto("Pizza", 40, 5),
    new Producto("Gaseosa", 8, 20)
};

// ==========================
// LÓGICA FUNCIONAL (OK)
// ==========================

var productosCostosos =
    CalculadoraPedidos.ObtenerProductosCostosos(productos, 20);

foreach (var nombre in productosCostosos)
{
    Console.WriteLine(nombre);
}

decimal total =
    CalculadoraPedidos.CalcularTotalProductos(productos);

Console.WriteLine($"Total: {total}");

decimal descuento =
    CalculadoraPedidos.EjecutarOperacion(total, t => t * 0.9m);

Console.WriteLine($"Con descuento: {descuento}");


// ==========================
// AOP + PROXY
// ==========================

var generator = new ProxyGenerator();

// servicio real
IPedidoService servicioReal = new PedidoService();

// interceptor
var interceptor = new SimpleInterceptor();

// proxy
IPedidoService servicioProxy =
    generator.CreateInterfaceProxyWithTarget(
        servicioReal,
        interceptor
    );


// ==========================
// CREAR PEDIDO (CORREGIDO)
// ==========================

// cliente de prueba (ajusta si tu constructor es distinto)
var cliente = new Cliente("Miguel");

var pedido = new Pedido(1, cliente);

// agregar productos correctamente (según tu diseño)
foreach (var producto in productos)
{
    pedido.AgregarProducto(producto);
}

// ==========================
// LLAMADA CON AOP
// ==========================

servicioProxy.CrearPedido(pedido);
