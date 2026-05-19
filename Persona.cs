using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalPOO
{
    public abstract class Persona
    {
        public string Nombre { get; set; }

        protected Persona(string nombre)
        {
            Nombre = nombre;
        }
    }
}
