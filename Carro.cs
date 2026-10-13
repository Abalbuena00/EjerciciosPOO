using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Parcial
{
    // Carro implementa el contrato definido por IVehiculo.
    public class Carro : IVehiculo
    {
        // Implementación del método para encender el carro.
        public void Encender()
        {
            Console.WriteLine("El carro ha encendido el motor.");
        }

        // Implementación del método para apagar el carro.
        public void Apagar()
        {
            Console.WriteLine("El carro ha apagado el motor.");
        }
    }
}
