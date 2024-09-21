//Exercicio01-----------------------------------------------------------

// using System;
// using System.Globalization;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Digite uma senha de 4 números: ");
//         int senha = int.Parse(Console.ReadLine());

//         while(senha != 2002)
//         {
//             Console.WriteLine($"{senha} Essa senha digitada está errada.");
//             senha = int.Parse(Console.ReadLine());
           
//         }
//         Console.WriteLine("Senha Certa!");
//     }
// }

//Exercicio1.1----------------------------------------------------------
// using System;
// using System.Globalization;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         int senha = 0;

//         while(senha != 2002)
//         {
//             Console.WriteLine("Digite uma senha de 4 números: ");
//             senha = int.Parse(Console.ReadLine());
//             if(senha != 2002)

//             {
//                 Console.WriteLine("Senha errada!");
                
//             }
//         }
//         Console.WriteLine("Senha certa!");
//     }
// }

//Exercicio02-----------------------------------------------------------
// using System;
// using System.Globalization;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Digite o X: ");
//         int X = int.Parse(Console.ReadLine());

//         Console.WriteLine("Digite o Y: ");
//         int Y = int.Parse(Console.ReadLine());

//         while(X != 0 && Y != 0)
//         {
//             if(X > 0 && Y > 0)
//             {
//                 Console.WriteLine("Primeiro quadrante ");
//                 break;
//             }
//             else if(X < 0 && Y > 0)
//             {
//                 Console.WriteLine("Segundo quadrante");
//                 break;
//             }
//             else if(X < 0 && Y < 0)
//             {
//                 Console.WriteLine("Terceiro quadrante");
//                 break;
//             }
//             else 
//             {
//                 Console.WriteLine("Quarto quadrante");
//                 break;
//             }
            
//         }
//        Console.WriteLine("Código Encerrado.");
//     }
// }

//Exercicio03-----------------------------------------------------------
// using System;
// using System.Globalization;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         int contadorAlcool = 0;
//         int contadorGasolina = 0;
//         int contadorDiesel = 0;

//         Console.WriteLine("Abasteça seu carro. ");
//         Console.WriteLine("1 - Álcool");
//         Console.WriteLine("2 - Gasolina");
//         Console.WriteLine("3 - Diesel");

//         Console.WriteLine("4 - Fim");
//         int resposta = int.Parse(Console.ReadLine());

//         while (resposta != 4)
//         {
//             if(resposta == 1)
//             {
//                 contadorAlcool++;
//             }
//             else if(resposta == 2)
//             {
//                 contadorGasolina++;
//             }
//             else if(resposta == 3)
//             {
//                contadorDiesel++;
                
//             }
//             resposta = int.Parse(Console.ReadLine());
            
//         }
//         Console.WriteLine($"\nÁlcool: {contadorAlcool}");
//         Console.WriteLine($"\nGasolina: {contadorGasolina}");
//         Console.WriteLine($"\nDiesel: {contadorDiesel}");
//         Console.WriteLine("\nMuito obrigado!");
//         Console.WriteLine("\nCódigo Encerrado");

//     }
// }
