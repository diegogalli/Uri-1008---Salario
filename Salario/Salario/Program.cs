using System;
using System.Globalization;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero, horas;
            double valorHora, salario;

            numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            horas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horas;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
             }
    }   
}
