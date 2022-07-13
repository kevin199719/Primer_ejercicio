using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_carro
{
    class Vehiculo
    {
        //atributos
        public int Motor { get; set; }
        public string Placa { get; set; }
        public string Color { get; set; }

        public string Marca { get; set; }


        //contructor

        public Vehiculo(string marca,string color,string placa, int motor)
        {
            Marca = marca;
            Motor = motor;
            Color = color;
            Placa = placa;
        }

        //metodo

        public void arrancar()
        {
            Console.WriteLine("El vehiculo esta prendido");
        }

        public void apagar()
        {
            Console.WriteLine("El vehiculo esta apagado");
        }

        public void informacion()
        {
            Console.WriteLine("El vehiculo es marca : "+ Marca + ", es color: "+ Color + ", su placa es: "+ Placa + " y tiene una cilindrada de: "+ Motor);
        }

        public int LimiteDeVelocidad()
        {
            Random rnd = new Random();
            int velocidad = rnd.Next(1, 240);
            return velocidad;
          
        }
        public string Pasajeros()
        {
            Random rnd = new Random();
            int intPasajeros = rnd.Next(1, 4);
            string strpasajeros = intPasajeros.ToString();
            return strpasajeros; 
        }


    }
}
