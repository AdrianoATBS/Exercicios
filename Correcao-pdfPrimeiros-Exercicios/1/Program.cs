using System;

namespace Programa
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pessoas p1 = new Pessoas();
            Pessoas p2 = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa: ");

            Console.WriteLine("Nome: ");
            p1.Nome = Console.ReadLine();

            Console.WriteLine("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Nome: ");
            p2.Nome = Console.ReadLine();

            Console.WriteLine("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());
            if(p1.Idade > p2.Idade)
            {
                Console.WriteLine($"A idade da pessoa {p1.Nome} é maior ");
            }
            else if(p2.Idade > p1.Idade)
            {
                Console.WriteLine($"A idade da pessoa {p2.Nome} é maior ");
            }
            else
            {
                Console.WriteLine($"A idade da pessoa {p1.Nome} e da pessoa {p2.Nome} são iguais");
            }
        }
    }
}