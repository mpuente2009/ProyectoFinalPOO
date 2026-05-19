using Castle.MicroKernel.Registration;
using Castle.Windsor;
using ProyectoFinalPOO.AOP;

namespace ProyectoFinalPOO.WindsorConfig
{
    public static class WindsorContainerConfig
    {
        public static IWindsorContainer Build()
        {
            var container = new WindsorContainer();

            container.Register(Component.For<LoggingInterceptor>().LifestyleTransient());
            container.Register(Component.For<ErrorHandlingInterceptor>().LifestyleTransient());

            container.Register(
                Component.For<IPedidoService, PedidoService>()
                    .ImplementedBy<PedidoService>()
                    .Interceptors<LoggingInterceptor, ErrorHandlingInterceptor>()
                    .LifestyleSingleton()
            );

            container.Register(
                Component.For<IPagoService>()
                    .ImplementedBy<PagoService>()
                    .Interceptors<LoggingInterceptor, ErrorHandlingInterceptor>()
                    .LifestyleTransient()
            );

            return container;
        }
    }
}