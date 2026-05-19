using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalPOO
{
    public class SmsNotificador : INotificador
    {
        public void Notificar(string mensaje)
        {
            Console.WriteLine(
                $"SMS: {mensaje}"
            );
        }
    }
}