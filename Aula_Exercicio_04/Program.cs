//Exercicio 01----------------------------------------------------------

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Fale um valor: ");
//         int valor = int.Parse(Console.ReadLine());


//         for(int i = 1; i<= valor; i++)
//         {
//             if(i % 2 != 0)
//             {
//                 Console.WriteLine($"Os valores impares são {i}");
//             }

//         }
        
//     }
// }

//Exercicio 02----------------------------------------------------------

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Passe alguns valores: ");
//         int valores = int.Parse(Console.ReadLine());

//         int dentro = 0;
//         int intervalor = 0;

//         for (int i = 0; i < valores; i++)
//         {
//             Console.Write($"Valor #{i}: " );
//             int valor = int.Parse(Console.ReadLine());
            
//             if(valor >= 10 && valor <= 20)
//             {
//                 dentro = dentro + 1;
//             }
//             else
//             {
//                 intervalor = intervalor + 1;
//             }
 
//         }
//         Console.WriteLine($"{dentro} in");
//         Console.WriteLine($"{intervalor} out");
//     }
// }

//Exercicio 03----------------------------------------------------------

// using System;
// using System.Globalization;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Fale o número de vezes de repetição: ");
//         int repetir = int.Parse(Console.ReadLine());

//         for (int i = 0; i < repetir; i++)
//         {
//             string[] line = Console.ReadLine().Split(' ');

//             double a = double.Parse(line[0], CultureInfo.InvariantCulture);
//             double b = double.Parse(line[1], CultureInfo.InvariantCulture);
//             double c = double.Parse(line[2], CultureInfo.InvariantCulture);

//             double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

//             Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
//         }
//     }
// }

//Exercicio 04----------------------------------------------------------

// using System;
// using System.Globalization;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Digite o número de pares: ");
//         int numero = int.Parse(Console.ReadLine());

//         for(int i = 0; i < numero; i++)
//         {
//             Console.WriteLine($"Par {i + 1}");
//             Console.WriteLine("Digite o numerador: ");
//             double numerador = double.Parse(Console.ReadLine());

//             Console.WriteLine("Digite o denominador: ");
//             double denominador = double.Parse(Console.ReadLine());

//             if(denominador == 0)
//             {
//                 Console.WriteLine("Divisão impossivel");
//             }
//             else
//             {
//                 double resultado = numerador / denominador;
//                 Console.WriteLine($"Resultado: {resultado}");
//             }
//         }        

    
//     }
// }

//Exercicio 05----------------------------------------------------------

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Digite os numeros de vezes: ");
//         int fatorial = int.Parse(Console.ReadLine());

//         int fat = 1;

//         for (int i = 1; i <= fatorial; i++)
//         {
//             fat = fat * i;
//         }
//         Console.WriteLine(fat);
//     }
// }

//Exercico 06-----------------------------------------------------------

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Digite um número inteiro: ");
//         int inteiro = int.Parse(Console.ReadLine());


//         for (int i = 1; i <= inteiro; i++)
//         {
//             if(inteiro % i == 0)
//             {
//                 Console.WriteLine(i);
//             }
//         }
        
//     }
// }

//Exercicio 07----------------------------------------------------------

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero: ");
        int numero = int.Parse(Console.ReadLine());

        for(int i = 1; i <= numero; i++)
        {
            int primeiro = i;
            int segundo = i *i;
            int terceiro = i* i* i;
            Console.WriteLine($"{primeiro}, {segundo}, {terceiro}");
        }

    }
}