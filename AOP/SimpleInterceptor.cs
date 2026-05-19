using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy;

namespace ProyectoFinalPOO.AOP
{
    public class SimpleInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine($"[AOP] Antes de {invocation.Method.Name}");

            invocation.Proceed();

            Console.WriteLine($"[AOP] Después de {invocation.Method.Name}");
        }
    }
}
