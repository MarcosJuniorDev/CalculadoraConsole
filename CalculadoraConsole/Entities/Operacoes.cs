

namespace CalculadoraConsole.Entities
{
    internal class Operacoes
    {
        public int Resultado { get; set; }
        public int Valor1 { get; set; }
        public int Valor2 { get; set; }

        public void Soma()
        {
            Console.Write("Insira 2 valores para soma: ");
            string[] valores = Console.ReadLine().Split(" ");
            Valor1 = int.Parse(valores[0]);
            Valor2 = int.Parse(valores[1]);
            Resultado = Valor1 + Valor2;
        }
        public void Menos()
        {
            Console.Write("Insira 2 valores para subtrair: ");
            string[] valores = Console.ReadLine().Split(" ");
            Valor1 = int.Parse(valores[0]);
            Valor2 = int.Parse(valores[1]);
            Resultado = Valor1 - Valor2;
        }

        public void Dividir()
        {
            Console.Write("Insira 2 valores para dividir: ");
            string[] valores = Console.ReadLine().Split(" ");
            Valor1 = int.Parse(valores[0]);
            Valor2 = int.Parse(valores[1]);
            Resultado = Valor1 / Valor2;
            if (Resultado % 2 != 0)
            {
                Console.WriteLine("valor dado não é divisivel");
                Dividir();
            }
        }

        public void Multiplicar()
        {
            Console.Write("Insira 2 valores para multiplicar: ");
            string[] valores = Console.ReadLine().Split(" ");
            Valor1 = int.Parse(valores[0]);
            Valor2 = int.Parse(valores[1]);
            Resultado = Valor1 * Valor2;
        }


        public override string ToString()
        {
            return $"O resultado da sua operação é: {Resultado}";
        }


    }
}
