using System;

namespace Pousada
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];

            Console.Write("Quantas quartos serão alugados ?   ");
            int q = int.Parse(Console.ReadLine());


            for (int i = 1; i <= q; i++)
            {
                Console.Write($"\nAluguel #{i}: ");

                Console.Write("\nNome: ");
                string nome = Console.ReadLine();
                
                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quartos: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }  
            Console.WriteLine("\nQuartos ocupados: ");
            for(int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine($"{i}: {vect[i]}");
                }
            }     
        }
    }
}
