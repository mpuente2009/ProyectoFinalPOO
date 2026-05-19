using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalPOO
{
    public class Empleado : Persona
    {
        public string Cargo { get; set; }

        public Empleado(string nombre, string cargo)
            : base(nombre)
        {
            Cargo = cargo;
        }
    }
}
