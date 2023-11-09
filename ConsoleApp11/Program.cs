using ConsoleApp11;
using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            Funcionarios x;

            x = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário:");
            x.nome1 = Console.ReadLine();
            x.salario1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            x.nome2 = Console.ReadLine();
            x.salario2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaDoSalario = (x.salario1 + x.salario2) / 2;
            Console.WriteLine("Salário médio = " + mediaDoSalario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
