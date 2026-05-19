using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;


namespace ProyectoFinalPOO.AOP
{
    public class LoggingInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine($"[LOG] Entrando a: {invocation.Method.Name}");
            Console.WriteLine($"[LOG] Argumentos: {string.Join(", ", invocation.Arguments)}");

            invocation.Proceed(); // ejecuta el método real

            Console.WriteLine($"[LOG] Saliendo de: {invocation.Method.Name}");
            if (invocation.ReturnValue != null)
                Console.WriteLine($"[LOG] Retorno: {invocation.ReturnValue}");
        }
    }
}
