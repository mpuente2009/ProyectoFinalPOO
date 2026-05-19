using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalPOO
{
    public class EmailNotificador : INotificador
    {
        public void Notificar(string mensaje)
        {
            Console.WriteLine(
                $"EMAIL: {mensaje}"
            );
        }
    }
}
