// exercicios1-estrutura-sequencial

// //Exercicio 01-------------------------------------------------------
// using System;
// using System.Globalization;

// namespace Exercicio01
// {
//     class Progaman
//     {
//         public static void Main(string[] args)
//         {
//             Console.WriteLine("Digite um número: ");
//             int num1 = int.Parse(Console.ReadLine());
//             Console.WriteLine("Digite um número: ");
//             int num2 = int.Parse(Console.ReadLine());

//             double resultado =  (double)num1 +  (double)num2;
//             Console.WriteLine($"O Resultado entre {num1} + {num2} = {resultado}");
//         }
//     }
// }

//Exercicio02----------------------------------------------------------
// using System;
// using System.Globalization;
// class Program
// {
// public static void Main()
//     {
//         Console.WriteLine("Digite um numero");
//         double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//         double entrada = 3.14159;

//         double resultado = entrada * Math.Pow(numero, 2.0);
//         Console.WriteLine($"A entrada {entrada} * {numero} é igual = {resultado:F4}");

        
//     }
// }

//Exercicio03-----------------------------------------------------------
// using System;

// class Program
// {
// public static void Main()
//     {
//         Console.WriteLine("Digite um número: ");
//         int A = int.Parse(Console.ReadLine());
//         Console.WriteLine("Digite um número: ");
//         int B = int.Parse(Console.ReadLine());
//         Console.WriteLine("Digite um número: ");
//         int C = int.Parse(Console.ReadLine());
//         Console.WriteLine("Digite um número: ");
//         int D = int.Parse(Console.ReadLine());

//         int resultado = (A * B) - (C * D);

//         Console.WriteLine(resultado);
//     }
// }

//Exercico04------------------------------------------------------------
// using System;
// using System.Globalization;
// class Program
// {
// public static void Main()
//     {
        
//         Console.WriteLine("Fale seu número de funcionario: ");
//         int funcionario = int.Parse(Console.ReadLine());
//         Console.WriteLine("Fale a quantidade de horas que você trabalhou");
//         int horas = int.Parse(Console.ReadLine());
//         Console.WriteLine("Digite o valor da sua hora: ");
//         double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//         double salario= horas * valorHora;
//         Console.WriteLine($"Qual seu numero? {funcionario} ");
//         Console.WriteLine($"Seu salario é R${salario:F2}");
//     }
// }

//Exercicio05-----------------------------------------------------------
// using System;
// using System.Globalization;

// class Progam
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Código do primeiro produto: ");
//         int codigo = int.Parse(Console.ReadLine());
//         Console.WriteLine("Números de primeira Peças: ");
//         int pecas = int.Parse(Console.ReadLine());
//         Console.WriteLine("Valor Unitario: ");
//         double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//         Console.WriteLine("Código do segundo produto: ");
//         int codigo2 = int.Parse(Console.ReadLine());
//         Console.WriteLine("Números de segunda Peças: ");
//         int pecas2 = int.Parse(Console.ReadLine());
//         Console.WriteLine("Valor Unitario: ");
//         double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//         double resultado = (pecas * valor) + (pecas2 * valor2);

//         Console.WriteLine($"Código do primeiro produto {codigo} e quantidade {pecas}");
//         Console.WriteLine($"Código do segundo produto {codigo2} e quantidade {pecas2}");
//         Console.WriteLine($"Valor a pagar: {resultado:F2}");

//     }
// }

//Exercicio06-----------------------------------------------------------
using System;
using System.Globalization;

class Progam
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Valor 1: ");
        double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Valor 2: ");
        double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Valor 3: ");
        double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        double  triangulo = 0.5 * A * C;
        double circulo = 3.14159 * Math.Pow(C, 2);
        double trapezio = 0.5 * (A + B) * C ;
        double quadrado = B * B;
        double retangulo = A * B;

        Console.WriteLine($"{triangulo:F3}");
        Console.WriteLine($"{circulo:F3}");
        Console.WriteLine($"{trapezio:F3}");
        Console.WriteLine($"{quadrado:F3}");
        Console.WriteLine($"{retangulo:F3}");
    }
}
