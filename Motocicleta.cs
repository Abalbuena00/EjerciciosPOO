using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Parcial
{
    // Motocicleta también implementa la interfaz IVehiculo.
    public class Motocicleta : IVehiculo
    {
        // Implementación específica para encender la motocicleta.
        public void Encender()
        {
            Console.WriteLine("La motocicleta ha encendido su motor.");
        }

        // Implementación específica para apagar la motocicleta.
        public void Apagar()
        {
            Console.WriteLine("La motocicleta ha apagado su motor.");
        }
    }
}
