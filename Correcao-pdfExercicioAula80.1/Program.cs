/*
Fazer um programa para ler dois números inteiros M e N, e depois ler uma matriz de M linhas por N colunas contendo números inteiros, podendo haver repetições. Em seguida, ler um número inteiro X que pertence à matriz. Para cada ocorrência de X, mostrar os valores à esquerda, acima, à direita e abaixo de X, quando houver, conforme exemplo.
*/

using System;
using System.Threading;

namespace Matriz
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("O número terá que ser construido com base em número de linhas e em números de coluna");
            Console.WriteLine("Ex:\n3 Linhas e 4 Colunas\n3 - 5 7 9 16 \n4 - 10 9 17 23 \n5 - 8 32 10 2 ");
            Thread.Sleep(2000);
            Console.WriteLine("Escreva dois números");
            string[] line = Console.ReadLine().Split();
            
            Console.WriteLine("Digite os números");

            int linhas = int.Parse(line[0]);
            int colunas = int.Parse(line[1]);

            int [,] mat = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                string[] values = Console.ReadLine().Split(" ");
                for (int j = 0; j < colunas; j++)
                {
                    mat[i,j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < linhas; i++)
            {
                for(int j = 0; j < colunas; j++)
                {
                    if(mat[i,j] == x)
                    {
                        Console.WriteLine($"Posição {i}, {j},:");
                        if(j > 0)
                        {
                            Console.WriteLine($"Esquerda: {mat[i,j - 1]} ");
                        }
                        if(i > 0)
                        {
                            Console.WriteLine($"Cima: {mat[i -1, j]}");
                        }
                        if(j < colunas -1 )
                        {
                            Console.WriteLine($"Direita: {mat[i, j + 1]}");
                        }
                        if(i < linhas -1)
                        {
                            Console.WriteLine($"Baixo: {mat[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}