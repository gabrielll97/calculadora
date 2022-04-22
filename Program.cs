using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|     Menu Interativo: Calculadora     |");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Qual tipo de operação você deseja usar?");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão");
            Console.WriteLine("5- Sair");
            Console.WriteLine("----------------------------------------");

            int esc = int.Parse(Console.ReadLine());


            switch (esc)
            {
                case 1: Adicao(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Saida(); break;
                default: Menu(); break;
            }
        }

        static void Adicao()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|     Menu Interativo: Calculadora     |");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());
            double res = n1 + n2;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"O resultado da adição é: {res}.");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|     Menu Interativo: Calculadora     |");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());
            double res = n1 - n2;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"O resultado da subtração é: {res}.");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|     Menu Interativo: Calculadora     |");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());
            double res = n1 * n2;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"O resultado da multiplicação é: {res}.");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|     Menu Interativo: Calculadora     |");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Digite o primeiro número: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double n2 = double.Parse(Console.ReadLine());
            double res = n1 / n2;
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"O resultado da divisão é: {res}.");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Menu();
        }

        static void Saida()
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("Programa Finalizado.");
            Console.WriteLine("--------------------");
            System.Environment.Exit(0);
        }
    }
}

