using System;

namespace Funcionario01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nFuncionário: {func}");

            Console.WriteLine("Deseja aumentar o salário em qual porcentagem? ");
            double porcentagem = double.Parse(Console.ReadLine());
            func.AumentarSalario(porcentagem);

            Console.WriteLine($"\nDados Atualizados: {func}");
        }
    }
}