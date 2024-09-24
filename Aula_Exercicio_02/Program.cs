// exercicios2-estrutura-condicional

//Exercicio01-----------------------------------------------------------
// using System;

// class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("Digite um número: ");
//         int numero = int.Parse(Console.ReadLine());

//         if(numero > 0)
//         {
//             Console.WriteLine("Esse número é positivo");
//         }
//         else
//         {
//             Console.WriteLine("Esse numero é negativo");
//         }
//     }
// }

//Exercicio02-----------------------------------------------------------

// using System;

// class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("Digite um número: ");
//         int numero = int.Parse(Console.ReadLine());

//         if(numero % 2 == 0)
//         {
//             Console.WriteLine("Esse número é PAR!");
//         }
//         else
//         {
//             Console.WriteLine("Esse núemro é IMPAR!");
//         }
//     }
// }

//Exercicio04-----------------------------------------------------------
// using System;

// class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("Digite um número: ");
//         int A = int.Parse(Console.ReadLine());

//         Console.WriteLine("Digite um número: ");
//         int B = int.Parse(Console.ReadLine());

//         if(A % B == 0 || B % A == 0  )
//         {
//             Console.WriteLine("São Multiplos");
//         }
//         else
//         {
//             Console.WriteLine("Não são Multiplos");
//         }
//     }
// }

//Exercicio04-----------------------------------------------------------
// using System;

// class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("Horas que começou: ");
//         int horasInicial = int.Parse(Console.ReadLine());

//         Console.WriteLine("Horas que terminou: ");
//         int horasTerminou = int.Parse(Console.ReadLine());
        
//         int duracao;

//         if(horasInicial < horasTerminou) 
//         {
//             duracao = horasTerminou - horasInicial;
//             Console.WriteLine($"O jogo durou {duracao} ");
//         }
//         else if(horasInicial > horasTerminou)
//         {
//             duracao = 24 - horasInicial + horasTerminou; 
//             Console.WriteLine($"O jogo durou {duracao}");
//         }
//         else
//         {
//             duracao = 24;
//             Console.WriteLine($"O jogo durou {duracao}");
//         }
//     }
// }

//Exercicio05-----------------------------------------------------------
// using System;
// using System.Globalization;

// class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("Cod: 1 - Cachorro Quente Valor R$ 4.00");
//         Console.WriteLine("Cod: 2 - X-Salada Valor R$ 4.50");
//         Console.WriteLine("Cod: 3 - X-Bacon Valor R$ 5.00");
//         Console.WriteLine("Cod: 4 - Torrada simples Valor R$ 2.00");
//         Console.WriteLine("Cod: 5 - Refrigerante R$ 1.50");
    
//         Console.WriteLine("\nEscreva o código do produto: ");
//         int codigo = int.Parse(Console.ReadLine());

//         Console.WriteLine("Fale a Quantidade: ");
//         int quantidade = int.Parse(Console.ReadLine());

//         Console.WriteLine("Digite o valor do produto: " );
//         double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//         double resultado = (double)quantidade * valor;

//         if(codigo == 1)
//         {
//             Console.WriteLine($"Você escolheu o  Cachorro Quente. E perdiu {quantidade} Cachorro Quente no valor de R${valor:F2} que ficou R${resultado:F2} ");
//         }
//         if(codigo == 2)
//         {
//             Console.WriteLine($"Você escolheu o  X-Salada. E perdiu {quantidade} X-Salada no valor de R${valor:F2} que ficou R${resultado:F2} ");
//         }
//         if(codigo == 3)
//         {
//             Console.WriteLine($"Você escolheu o  X-Bacon. E perdiu {quantidade} X-Bacon no valor de R${valor:F2} que ficou R${resultado:F2} ");
//         }
//         if(codigo == 4)
//         {
//             Console.WriteLine($"Você escolheu o  Torrada simples. E perdiu {quantidade} Torrada simples no valor de R${valor:F2} que ficou R${resultado:F2} ");
//         }
//         if(codigo == 5)
//         {
//             Console.WriteLine($"Você escolheu o  Refrigerante. E perdiu {quantidade} Refrigeranteno valor de R${valor:F2} que ficou R${resultado:F2} ");
//         }
//         else
//         {
//             Console.WriteLine("Obrigado por sua contribuição!!");
//         }
        
//     }
// }

//Exercicio06-----------------------------------------------------------
// using System;
// using System.Globalization;

// class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("Digite um valor: ");
//         double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//         if (valor < 0)
//         {
//             Console.WriteLine("Fora do Intervalo");
//         }
//         else if(valor <= 25)
//         {
//             Console.WriteLine($"Intervalo (0,25]");
//         }
//         else if( valor <= 50)
//         {
//             Console.WriteLine($"Intervalo (25,50]");
//         }
//         else if(valor <= 75)
//         {
//             Console.WriteLine($"Intervalo (50,75]");
//         }
//         else
//         {
//              Console.WriteLine($"Intervalo (75,100]");
//         }
//     } 
// }

//Exercicio06-----------------------------------------------------------

// using System;
// using System.Globalization;

// class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("Eixo X: ");
//         decimal X = decimal.Parse(Console.ReadLine());

//         Console.WriteLine("Eixo Y: ");
//         decimal Y = decimal.Parse(Console.ReadLine());

//         if(X == 0 && Y == 0)
//         {
//             Console.WriteLine("Origem");
//         }
//         else if(X == 0)
//         {
//             Console.WriteLine("Eixo X");
//         }
//         else if(Y == 0)
//         {
//             Console.WriteLine("Eixo Y");
//         }
//         else if(X > 0 && Y > 0)
//         {
//             Console.WriteLine("Eixo Q1");
//         }
//         else if(X < 0 && Y > 0)
//         {
//             Console.WriteLine("Eixo Q2");
//         }
//         else if(X < 0 && Y < 0)
//         {
//             Console.WriteLine("Eixo Q3");
//         }
//         else if( X > 0 && Y < 0)
//         {
//             Console.WriteLine("Eixo Q4");
//         }
//     }
// }

//Exercicio07-----------------------------------------------------------
using System;
using System.Globalization;

class Program
{
    public static void Main()
    {   
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Fale o seu salario: ");
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
       
        double imposto = 0.0;

        if (salario <= 2000.00)
        {
            Console.WriteLine($"Seu salario é {salario:F2} e o imposto é isento");
        }
        else if (salario <= 3000.00 )
        {
            imposto = (salario - 2000.00) * 0.08;

            Console.WriteLine($"Seu salario é {salario:F2} e o imposto é R${imposto:F2}");
        }
        else if(salario <= 4500.00)
        {
            imposto = (1000.00 * 0.08) + ((salario - 3000.00) * 0.18);

            Console.WriteLine($"Seu salario é {salario:F2} e o imposto é R${imposto:F2}");
        }
        else
        {
            imposto = (1000.00 * 0.08) + (1500.00 * 0.18) + ((salario - 4500.00) * 0.28);
           Console.WriteLine($"Seu salario é {salario:F2} e o imposto é R${imposto:F2}");
        
        }
        
    }
}