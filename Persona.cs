using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Parcial
{
    public class Persona
    {
        private string Nombre { get; set; }
        private int Edad { get; set; }

        public Persona (string Nombre,int Edad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
        }

        public Persona ()
        {

        }

        public void Presentarse()
        {
            Console.WriteLine(
                $"Hola, mi nombre es {Nombre} y tengo {Edad} años."
            );
        }


    }
}
