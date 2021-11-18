using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensajeArray = String.Empty;
            decimal[] numeros = new decimal[4] { 1, 2, 0, -1 };                     
            decimal[] resultado = masMenos(numeros);

            Console.WriteLine("Función masMenos()");
            Console.WriteLine("------------------");
            Console.WriteLine("");

            foreach (var item in numeros)
            {
                mensajeArray = mensajeArray + item + ", ";
            }

            mensajeArray = mensajeArray.Substring(0, mensajeArray.Length - 2);
            Console.WriteLine("[" + mensajeArray + "]");
            Console.WriteLine("");

            Console.WriteLine("Fracción de números que son positivos: " + resultado[2]);
            Console.WriteLine("Fracción de números que son cero: " + resultado[1]);
            Console.WriteLine("Fracción de números que son negativos: " + resultado[0]);
            Console.ReadLine();

        }



        public static decimal[] masMenos(decimal[] numeros)
        {
            decimal[] result = new decimal[3];

            result[0] = Math.Round(((decimal)numeros.Where(x => x < 0).Count() / numeros.Length),2);
            result[1] = Math.Round(((decimal)numeros.Where(x => x < 1 && x >= 0).Count() / numeros.Length),2);
            result[2] = Math.Round(((decimal)numeros.Where(x => x >= 1).Count() / numeros.Length), 2);

            return result;
        }
    }
}
