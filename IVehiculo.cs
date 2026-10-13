using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Parcial
{
    public interface IVehiculo
    {
        // Define la operación que cada vehículo debe implementar.
        void Encender();

        // Define la operación para apagar el vehículo.
        void Apagar();
    }
}
