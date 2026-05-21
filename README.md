# Proyecto Final — Paradigmas de Programación

Este proyecto es una aplicación de consola en .NET C# que simula un sistema de pedidos de restaurante. Se implementaron cuatro paradigmas de programación sobre este dominio.

## ¿De qué trata el programa?

El sistema permite crear pedidos, agregarles productos, calcular totales y procesar pagos. Todo esto sirve como base para demostrar los cuatro paradigmas requeridos.

## Paradigmas

### Programación Orientada a Objetos
Se modeló el dominio con clases como Persona, Cliente, Empleado, Producto y Pedido. Persona es abstracta y Cliente y Empleado heredan de ella. Los servicios se definen a través de interfaces (IPedidoService, IPagoService) para separar el contrato de la implementación.

### Programación Orientada a Aspectos (AOP)
Se usó Castle Windsor como contenedor de inyección de dependencias. Se implementaron dos interceptores: LoggingInterceptor que registra la entrada y salida de cada método, y ErrorHandlingInterceptor que captura excepciones de forma centralizada. El servicio real no sabe que está siendo interceptado.

### Programación Funcional
En CalculadoraPedidos se usó LINQ con Where, Select y Aggregate para trabajar con colecciones sin modificarlas. También se usaron Func como parámetros para pasar operaciones como el cálculo de descuentos. ResumenPedido y FacturaDTO son tipos record, lo que los hace inmutables por diseño.

### Programación Orientada a Eventos
PedidoService tiene dos eventos propios: PedidoCreado que se dispara al crear un pedido, y StockActualizado que se dispara al modificar el inventario. Quien quiera reaccionar a estos cambios simplemente se suscribe al evento.
