/* LEIA  AQUI TEM ALGUMAS INFORMAÇÕES ⬇️
1 - Professor, estaria mandando logo só para eu não ficar muito atrasado, mas continuarei a melhorar esses códigos tem algumas coisas que quero fazer neles

2 - O Exercício 07 eu fiz 2. Por conta de eu não ter interpretado o texto direito. Resolvi deixar lá como uma lembrança.

*/

// Exercício 01

/*

using System;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("====Exercício 01====");
        Console.WriteLine("Qual é o seu Salario: R$ ?");
        double salario = double.Parse(Console.ReadLine());

        double aumento = 0.25;
        double novoSalario = salario * aumento;
        double novo = novoSalario + salario;

        Console.WriteLine($"Você teve um aumento de R${novoSalario} e agora seu salario é R${novo}");
        Console.WriteLine("====================");
    }
}

*/

// Exercício 02

/*
using System;


internal class Program
{
    public static void Main(Console console)
    {
        Console.WriteLine("====Exercício 02====");
        Console.WriteLine("Qual é o seu Salario: R$ ?");
        double salario = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual porcentagem deve ser acrescentada ? %");
        double aumento = double.Parse(Console.ReadLine());

        double novoSalario = salario * (aumento / 100);

        double novo = novoSalario + salario;

        Console.WriteLine($"O Salario é R${salario} e com um acrescimo de {aumento}% você recebeu um aumento de R${novo}");
        Console.WriteLine("====================");


    }
}
*/

// Exercício 03

/*
using System;


internal class Program
{
    public static void Main()
    {
        Console.WriteLine("====Exercício 03====");
        Console.WriteLine("Digite sua data de nascimento: Dia/Mês/Ano" );
        DateTime dataNascimento;
          while (!DateTime.TryParse(Console.ReadLine(), out dataNascimento) || dataNascimento > DateTime.Now)
        {
            Console.WriteLine("Data inválida. Por favor, digite uma data de nascimento válida (dd/mm/yyyy).");
            Console.Write("Digite a data de nascimento (dd/mm/yyyy): ");
        }

        DateTime dataAtual = DateTime.Now;

        int idadeAnos = dataAtual.Year - dataNascimento.Year;
        Console.WriteLine($"Sua idade em anos é: {idadeAnos} ano");

        int idadeMeses = (idadeAnos * 12) + dataAtual.Month - dataNascimento.Month;
        Console.WriteLine($"Sua idade em meses é: {idadeMeses} meses");
        
         int idadeSemanas = (idadeAnos * 52 ) + dataAtual.DayOfWeek - dataNascimento.DayOfWeek;
        Console.WriteLine($"Sua idade em Semanas é: {idadeSemanas} Semanas");

        int idadeDias = (idadeAnos * 365) + dataAtual.Day - dataNascimento.Day;
        Console.WriteLine($"Sua idade em dias é: {idadeDias} dias");
        Console.WriteLine("====================");


    }
}
*/

// Exercícios 04

/*
using System;


internal class Program
{
    public static void Main()
    {
        Console.WriteLine("====Exercício 04====");
        Console.WriteLine("Digite o peso da ração:  (em quilograma)");
        double racaoKg;
        while (!double.TryParse(Console.ReadLine(), out racaoKg)){
            Console.WriteLine("Peso Inválido. Digite um valor válido");
            Console.WriteLine("Digite um peso válido: (em quilos)");
        }

        Console.WriteLine("Digite a quantidade Diária de ração para os gatos: (em gramas)");
        double racaoG;
         while (!double.TryParse(Console.ReadLine(), out racaoG)){
            Console.WriteLine("Peso Inválido. Digite um valor válido");
            Console.WriteLine("Digite um peso válido: (em quilos)");
        }
        double convertidoG = racaoKg * 1000;
        Console.WriteLine($"{racaoKg} Quilograma convertido em Gramas fica {convertidoG} gramas");

        double quantidade = racaoG * 2 * 5;
        Console.WriteLine($"A quantidade que os dois gatos consumiram em cinco dias foi: {quantidade} gramas");

        double restante = convertidoG - quantidade;
        Console.WriteLine($"Depois de cinco dias, sobrará de ração {restante} gramas dentro do saco");
        Console.WriteLine("====================");
        

    }
}
*/

//Exercício 05

/*
using System;
using System.Threading;


internal class Program
{
    public static void Main()
    {
        Console.WriteLine("====Exercício 05====");
        Console.WriteLine("Fale um número: ");
        int A = int.Parse(Console.ReadLine());
        Console.WriteLine("Fale um número: ");
        int B = int.Parse(Console.ReadLine());

        Console.WriteLine($"Número A = {A}");
        Console.WriteLine($"Número B = {B}");

        Console.WriteLine("Aguarde uns momentos, estamos trocando os números");
        Thread.Sleep(3000);

        if(A != B){
            Console.WriteLine($"Troca Efetuada A = {B}");
        }
        if(B != A){
            Console.WriteLine($"Troca Efetuada B = {A}");
        }
        Console.WriteLine("====================");


    }
}
*/

//Exercício 06
/*
using System;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("====Exercício 06====");
        Console.WriteLine("Qual a altura ? ");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual a Largura ? ");
        double largura = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual a Comprimento ? ");
        double comprimento = double.Parse(Console.ReadLine());

        double volume = largura * altura * comprimento;

        Console.WriteLine($"O Volume é {volume}");
        Console.WriteLine("====================");

    }
}
*/

// Exercício 07
/*
using System;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("====Exercício 07====");

        Console.WriteLine("Digite o número A: ");
        int A = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o número B: ");
        int B = int.Parse(Console.ReadLine());

        int diferenca =  A - B ;
        int resultado = diferenca * diferenca;

        Console.WriteLine($"A Diferença do quadrado {A} para o {B} é = {resultado}");
        Console.WriteLine("====================");

    }
}
*/
/*
------------------------------------------------------------------------
                     ⬇️ O SEGUNDO
------------------------------------------------------------------------
*/
// Exercíco 07.2
/*
using System;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("====Exercício 07====");

        Console.WriteLine("Digite o número A: ");
        int A = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o número B: ");
        int B = int.Parse(Console.ReadLine());

        int diferenca =  A - B ;
        int diferencaAbs = Math.Abs(diferenca);

        Console.WriteLine($"A Diferença do quadrado {A} para o {B} é = {diferencaAbs}");
        Console.WriteLine("====================");

    }
}
*/

//Exercício 08

/*
using System;
using System.Threading;


internal class Program
{
    public static void Main()
    {
        Console.WriteLine("====Exercício 08====");

        Console.WriteLine("Digite a quantidade de Dolares que deseja converte para Real ? ");
        decimal dolar = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Qual a cotação do dolar ? ");
        decimal cotacao = decimal.Parse(Console.ReadLine());

        decimal real = dolar * cotacao;
        Console.WriteLine("Aguarde alguns segundos estamos convertendo!");
        Thread.Sleep(3000);

        Console.WriteLine($"Você converteu US${dolar} na cotação de US${cotacao} que ficou R${real:N} ");
        Console.WriteLine("====================");


    }
}
*/

// Exercício 09
/*
using System;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("====Exercício 09====");
        Console.Write("Digite um valor para o A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Digite um valor para o B: ");
        int B = int.Parse(Console.ReadLine());

        Console.Write("Digite um valor para o C: ");
        int C = int.Parse(Console.ReadLine());

        int resultado = (A*A) + (B*B) + (C*C);

        Console.WriteLine($"A soma do quadrado A = {A}, B = {B}, C = {C}\n");
        Console.Write($"Tem como resultado = {resultado}");
        Console.WriteLine("====================");
        
    }
}
*/

// Exercício 10
/*
using System;

internal class Program
{
    public static void Main()
    {   
        bool repetir = true;

        while(repetir){
            Console.WriteLine("====Exercício 10====");

            Console.Write("Escreva o valor de A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Escreva o valor de B: ");
            int B = int.Parse(Console.ReadLine());

            double soma = A + B;
            Console.WriteLine($"A soma dos números {A} + {B} é = {soma}");

            double subtracao = A - B;
            Console.WriteLine($"A subtração dos números {A} - {B} é = {subtracao}");

            double multiplicacao = A * B;
            Console.WriteLine($"A multiplicação dos números {A} * {B} é = {multiplicacao}");

            double divisao = A / B;
            Console.WriteLine($"A divisão dos números {A} / {B} é = {divisao}");

            Console.Write("Deseja repetir ? (s/n): ");
            string resposta = Console.ReadLine();

            if(resposta.ToLower() != "s")
            {
                repetir = false;
            }

            Console.WriteLine("Adeus!!");
            Console.WriteLine("====================");


        }

    }
}
*/

//Exercício 11
/*
using System;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("====Exercício 11====");
        Console.WriteLine("Digite o valor do RAIO: ");
        double raio = double.Parse(Console.ReadLine());

        double volume = (4.0 / 3.0) * 3.14159 * Math.Pow(raio, 3);

        Console.WriteLine($"O raio é {raio} e o volume {volume}");
        Console.WriteLine("====================");
        
    }
}
*/

// Exercício 12
/*
using System;

internal class Program
{
    public static void Main()
    {
        bool repetir = true;

        while(repetir){
            Console.WriteLine("====Exercício 12====");
            Console.WriteLine("Digite um Número");
            int numero = int.Parse(Console.ReadLine());

            int ant = numero - 1;
            Console.WriteLine($"O antecessor do número {numero} é {ant}");

            int suc = numero + 1;
            Console.WriteLine($"O sucessor do número {numero} é {suc}");

            Console.WriteLine("Deseja continuar o progama (s/n) ?");
            string respsota = Console.ReadLine();

            if(respsota.ToLower() != ("s")){

                repetir = false;
            }

            Console.WriteLine("Por Hoje é isso!");
            Console.WriteLine("====================");

        }
        
        
    }
}
*/

//Exercício 13

/*
using System;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("====Exercício 13=========");

        double a, b, c, soma, dif;

        a = 2;
        b = 3;
        c = 4;
        dif = -5;
        
        soma = a + b + c - dif; 

        dif = Math.Pow(soma,2);

        soma = Math.Sqrt(dif);

        a = c;
        b = -3;

        Console.WriteLine($"Escreva: {a}, {b}, {c}, {soma}, {dif} ");
        
        Console.WriteLine("=========================");

        Console.WriteLine("====Exercício 13=========");

        double x, y, resto, quociente;

        x = 25;
        y = 52;

        resto = 52 % 25;
        quociente = 52 / 25;

        x = resto;
        y = quociente;

        resto = x % y;
        quociente = x / y;

        Console.WriteLine($"Escreva: {resto}, {quociente}");
        Console.WriteLine("=========================");

    }
}
*/
