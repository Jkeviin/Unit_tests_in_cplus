using System;

namespace Calcsns
{
    public class Calculadora
    {
        public float obtenerIva(float valor)
        {
            return valor * 0.19f;
        }

        public float obtenerReserva(float valor)
        {
            return valor * 0.09f;
        }

        public float totalPagar(float valor)
        {
            return valor + obtenerIva(valor) + obtenerReserva(valor);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hola");
        }
    }
}