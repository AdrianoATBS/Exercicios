// É da Video aula 18

using System;
using System.Globalization;

string produto1 = "Computador";
string produto2 = "Mesa de escritório";

byte idade = 30;
int codigo = 5290;
char genero = 'M';

double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.234567;

Console.WriteLine("Produtos: ");
Console.WriteLine($"{produto1}, cujo preço é R$ {preco1:F2}");
Console.WriteLine($"{produto2}, cujo preço é R$ {preco2}");

Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero {genero}");

Console.WriteLine($"Media com oito casas decimais: {medida}");
Console.WriteLine($"Media com oito casas decimais: {medida:F3}");
Console.WriteLine($"Media com oito casas decimais: {medida.ToString("F3", CultureInfo.InvariantCulture)}");

// Usar o Culture dessa maneira não tem como fazer de uma outra maneira (NÃO QUE EU SAIBA)