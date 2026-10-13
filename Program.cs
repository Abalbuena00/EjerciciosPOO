using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Practica_Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("==================================");
                Console.WriteLine("   BIENVENIDOS, SOY EL GRUPO DE ");
                Console.WriteLine("         UNO SOLO HOMBRE ");
                Console.WriteLine("==================================");
                Console.WriteLine("1. Estructuras de control");
                Console.WriteLine("2. Clases y objetos");
                Console.WriteLine("3. Herencia");
                Console.WriteLine("4. Polimorfismo");
                Console.WriteLine("5. Encapsulamiento");
                Console.WriteLine("6. Interfaces y abstracción");
                Console.WriteLine("0. Salir");
                Console.WriteLine("==================================");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.Clear();

                    switch (opcion)
                    {
                        case 1:
                            EjercicioEstructurasControl();

                            break;

                        case 2:
                            EjercicioClasesObjetos();
                            break;

                        case 3:
                            EjercicioHerencia();
                            break;

                        case 4:
                            EjercicioPolimorfismo();
                            break;

                        case 5:
                            EjercicioEncapsulamiento();
                            break;

                        case 6:
                            EjercicioInterfacesAbstraccion();
                            break;

                        case 0:
                            Console.WriteLine("Gracias por utilizar el programa.");
                            break;

                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }

                    if (opcion != 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                    }
                }
                else
                {
                    opcion = -1;
                    Console.WriteLine("Debe introducir un número válido.");
                    Console.ReadKey();
                }

            } while (opcion != 0);
        }

        static void EjercicioEstructurasControl()
        {
            Console.WriteLine("=== EJERCICIO 2: ESTRUCTURAS DE CONTROL ===");
            Console.WriteLine();
            int numero;


            // Parte 1: Determinar si un número es par o impar
            Console.Write("Introduzca un número entero: ");


            if (int.TryParse(Console.ReadLine(), out numero))
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine($"El número {numero} es par.");
                }
                else
                {
                    Console.WriteLine($"El número {numero} es impar.");
                }
            }
            else
            {
                Console.WriteLine("UN NUMERO ENTERO!!!");
            }

            Console.WriteLine();

            // Parte 2: Mostrar los números del 1 al 10
            Console.WriteLine("Números del 1 al 10:");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }


        static void EjercicioClasesObjetos()
        {
            Console.WriteLine("=== EJERCICIO 3: CLASES Y OBJETOS ===");
            Console.WriteLine();

            Persona persona1 = new Persona("Alex Yunior", 23);
            
            persona1.Presentarse();

        }


        static void EjercicioHerencia()
        {
            Console.WriteLine("=== EJERCICIO 4: HERENCIA ===");
            Console.WriteLine();

            // Creamos un objeto de la clase Perro.
            Perro perro = new Perro();

            // Creamos un objeto de la clase Gato.
            Gato gato = new Gato();

            // Llamamos al método heredado y sobrescrito.
            perro.HacerSonido();
            gato.HacerSonido();
        }


        static void EjercicioPolimorfismo()
        {
            Console.WriteLine("=== EJERCICIO 5: POLIMORFISMO ===");
            Console.WriteLine();

            // Creamos una lista que puede almacenar animales.
            List<Animal> animales = new List<Animal>();

            // Agregamos objetos de diferentes clases derivadas.
            animales.Add(new Perro());
            animales.Add(new Gato());

            // Recorremos la lista y ejecutamos el método de cada animal.
            foreach (Animal animal in animales)
            {
                animal.HacerSonido();
            }
        }


        static void EjercicioEncapsulamiento()
        {
            Console.WriteLine("=== EJERCICIO 6: ENCAPSULAMIENTO ===");
            Console.WriteLine();

            // Creamos un objeto de tipo CuentaBancaria.
            CuentaBancaria cuenta = new CuentaBancaria();

            // Solicitamos al usuario la cantidad que desea depositar.
            Console.Write("Introduzca el monto a depositar: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal monto))
            {
                // Realizamos el depósito.
                cuenta.Depositar(monto);

                // Consultamos y mostramos el saldo actual.
                Console.WriteLine($"Saldo actual: {cuenta.ObtenerSaldo():C}");
            }
            else
            {
                Console.WriteLine("Debe introducir una cantidad válida.");
            }
        }


        static void EjercicioInterfacesAbstraccion()
        {
            Console.WriteLine("=== EJERCICIO 7: INTERFACES Y ABSTRACCIÓN ===");
            Console.WriteLine();

            // Creamos un objeto de tipo Carro.
            Carro carro = new Carro();

            // Creamos un objeto de tipo Motocicleta.
            Motocicleta motocicleta = new Motocicleta();

            // Probamos los métodos del carro.
            Console.WriteLine("Vehículo: Carro");
            carro.Encender();
            carro.Apagar();

            Console.WriteLine();

            // Probamos los métodos de la motocicleta.
            Console.WriteLine("Vehículo: Motocicleta");
            motocicleta.Encender();
            motocicleta.Apagar();
        }




    }
}
