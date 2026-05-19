using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalPOO.AOP
{
    public class ErrorHandlingInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            try
            {
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Excepción en {invocation.Method.Name}: {ex.Message}");
                // Aquí podrías loggear a archivo, lanzar excepción custom, etc.
                throw; // re-lanza para no silenciar el error
            }
        }
    }
}