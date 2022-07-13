using System;

namespace Ejercicio_carro
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo1 = new Vehiculo("Geely","Rojo","KVN-197",1500);
            Console.WriteLine(vehiculo1);

            vehiculo1.informacion();
            vehiculo1.arrancar();
            Console.WriteLine("La velocidad es de : " + vehiculo1.LimiteDeVelocidad());
            Console.WriteLine("La cantidad de pasajeros es de : " + vehiculo1.Pasajeros());
            vehiculo1.apagar();
        }
    }
}
