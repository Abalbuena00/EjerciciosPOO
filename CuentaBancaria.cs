using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Parcial
{
    public class CuentaBancaria
    {
        // Atributo privado: solo se puede acceder directamente desde esta clase.
        private decimal saldo;

        // Constructor: inicializa la cuenta con un saldo de cero.
        public CuentaBancaria()
        {
            saldo = 0;
        }

        // Permite depositar dinero en la cuenta.
        public void Depositar(decimal monto)
        {
            // Evitamos depósitos de cantidades iguales o menores que cero.
            if (monto <= 0)
            {
                Console.WriteLine("El monto debe ser mayor que cero.");
                return;
            }

            // Actualizamos el saldo de la cuenta.
            saldo += monto;

            Console.WriteLine("Depósito realizado correctamente.");
        }

        // Permite consultar el saldo sin modificarlo.
        public decimal ObtenerSaldo()
        {
            return saldo;
        }
    }
}
