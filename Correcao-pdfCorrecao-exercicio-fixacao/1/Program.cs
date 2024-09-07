using System;

namespace Retangulo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rentagulo ret = new Rentagulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            ret.Largura = double.Parse(Console.ReadLine());
            ret.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Área = {ret.Area()}: ");
            Console.WriteLine($"Perímetro = {ret.Perimetro()}: ");
            Console.WriteLine($"Diagonal = {ret.Diagonal()}: ");

        }
    }
}