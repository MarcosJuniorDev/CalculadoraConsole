using CalculadoraConsole.Entities;

namespace CalculadoraConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool terminou = false;


            Operacoes operacoes = new Operacoes();
            Console.WriteLine("Calculadora");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - multiplicação");
            Console.WriteLine("qualquer outro botão para sair");
            Console.WriteLine();

            Console.Write("insira o numero da operação que deseja: ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (n)
            {
                case 1:
                    {
                        operacoes.Soma();
                        Console.WriteLine(operacoes);
                        break;
                    }
                case 2:
                    {
                        operacoes.Menos();
                        Console.WriteLine(operacoes);
                        break;
                    }
                case 3:
                    {
                        operacoes.Dividir();
                        Console.WriteLine(operacoes);
                        break;
                    }
                case 4:
                    {
                        operacoes.Multiplicar();
                        Console.WriteLine(operacoes);
                        break;
                    }
                    default:
                    {
                        break;
                    }
            }


        }
    }
}