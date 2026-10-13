using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Parcial
{
    // Clase base de la que heredarán otros animales.
    public class Animal
    {
        // Método que podrán utilizar las clases derivadas.
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }
    }

    // Perro hereda de la clase Animal.
    public class Perro:Animal
    {
        // Sobrescribe el método heredado para mostrar su sonido.
        public override void HacerSonido()
        {
            Console.WriteLine("Perro: Guau, Guau");
        }
        

    }

    // Gato también hereda de la clase Animal.
    public class Gato : Animal
    {
        // Sobrescribe el método para mostrar el sonido del gato.
        public override void HacerSonido()
        {
            Console.WriteLine("Gato: Miau ");
        }

    }
}

