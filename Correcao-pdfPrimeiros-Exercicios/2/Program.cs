using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios f1 = new Funcionarios();
            Funcionarios f2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write($"Nome: ");
            f1.Nome = Console.ReadLine();
            
            Console.Write($"Salário: ");
            f1.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write($"Nome: ");
            f2.Nome = Console.ReadLine();

            Console.Write($"Salário: ");
            f2.Salario = decimal.Parse(Console.ReadLine());
        
            decimal ResolverCalculo = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine($"Salário Médio = {ResolverCalculo}");
        }
    }
}