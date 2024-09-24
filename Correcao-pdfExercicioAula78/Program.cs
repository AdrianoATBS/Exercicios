<<<<<<< HEAD
﻿using System;
=======
<<<<<<< HEAD
﻿using System;
=======
﻿/*
Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
N funcionários. Não deve haver repetição de id.
Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
conforme exemplos.
Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
aumento por porcentagem dada.

*/


using System;
using System.Globalization;
>>>>>>> 78a3eb8 (Subindo Exercícios)
>>>>>>> 6bdd34dfd4e20dc6326db97bb1e2335da22f7a6d

namespace Lista
{
    public class Program
    {
        public static void Main(string[] args)
        {
<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
            Console.Write("Quantos funcionários serão registrados ? ");
            int quantidade = int.Parse(Console.ReadLine()); 

            List<Salario> list = new List<Salario>();

            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine($"Trabalhador #{i}: ");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salario: ");
                double salarioInformado =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Salario(id, salarioInformado, nome ));
            }

            Console.Write("Qual o id terá um aumento ?  ");
            int novoId = int.Parse(Console.ReadLine());

            Salario salario = list.Find(x => x.Id == novoId);
            if(salario != null)
            {
                Console.Write("Qual a porcentagem do aumento ? ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                salario.aumentoSalarial(porcentagem);
            }
            else if(salario == null)
            {
                Console.WriteLine("Esse Id não existe!!");
            }

            Console.WriteLine("Lista atualizada: ");
            foreach(Salario obj in list)
            {
                Console.WriteLine(obj);
            }
>>>>>>> 78a3eb8 (Subindo Exercícios)
>>>>>>> 6bdd34dfd4e20dc6326db97bb1e2335da22f7a6d
        }
    }
}
