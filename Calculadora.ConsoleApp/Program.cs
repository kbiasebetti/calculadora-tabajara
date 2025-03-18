

using System.Reflection.Metadata.Ecma335;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Vetores
            string[] historicoOperacoes = new string[100];
            int contadorHistorico = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("--------------------------");
                Console.WriteLine("Calculadora Tabajara");
                Console.WriteLine("--------------------------");

                Console.WriteLine("1- Soma");
                Console.WriteLine("2- Subtração");
                Console.WriteLine("3- Multiplicação");
                Console.WriteLine("4- Divisão");
                Console.WriteLine("5- Tabuada");
                Console.WriteLine("6- Histórico de Operações");
                Console.WriteLine("X- Sair do Programa");
                Console.WriteLine("------------------------------------");
                Console.Write("Escolha o método a ser efetuado pela calculadora: ");

                string metodoEscolhido = Console.ReadLine();

                if (metodoEscolhido == "X")
                    break;

                else if (metodoEscolhido == "5")
                {
                    Console.WriteLine("----------");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("----------");

                    Console.Write("Digite o valor desejado para ver a tabuada: ");
                    int valorTabuada = Convert.ToInt32(Console.ReadLine());

                    // 1- contador = Variável de Controle
                    // 2- Condição
                    // 3- Mecanismo de Incrementação (Looping) = contador = contador + 1
                    for (int contador = 1; contador <= 10; contador++)
                    {
                        string linhaTabuada = $"{valorTabuada} x {contador} = {valorTabuada * contador}";
                        Console.WriteLine(linhaTabuada);
                    }

                    Console.ReadLine();
                    continue;
                }

                else if (metodoEscolhido == "6")
                {
                    Console.WriteLine("--------------------------");
                    Console.WriteLine("Histórico de Operações");
                    Console.WriteLine("--------------------------");

                    for (int contador = 0; contador <= contadorHistorico; contador++)
                    {
                        Console.WriteLine(historicoOperacoes[contador]);
                    }

                    Console.ReadLine();
                    continue;
                }

                Console.Write("Digite o primeiro valor: ");
                double primeiroValor = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo valor: ");
                double segundoValor = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                if (metodoEscolhido == "1")
                {
                    resultado = primeiroValor + segundoValor;
                    historicoOperacoes[contadorHistorico] = $"{primeiroValor} + {segundoValor} = {resultado}";
                }

                else if (metodoEscolhido == "2")
                {
                    resultado = primeiroValor - segundoValor;
                    historicoOperacoes[contadorHistorico] = $"{primeiroValor} - {segundoValor} = {resultado}";
                }

                else if (metodoEscolhido == "3")
                {
                    resultado = primeiroValor * segundoValor;
                    historicoOperacoes[contadorHistorico] = $"{primeiroValor} * {segundoValor} = {resultado}";
                }

                else if (metodoEscolhido == "4")
                {
                    while (segundoValor == 0)
                    {
                        Console.Write("> Digite o segundo número novamente: ");
                        segundoValor = Convert.ToDouble(Console.ReadLine());
                    }
                    resultado = primeiroValor / segundoValor;
                    historicoOperacoes[contadorHistorico] = $"{primeiroValor} / {segundoValor} = {resultado}";
                }

                else
                    continue;

                contadorHistorico++;

                Console.WriteLine("Resultado: " + resultado.ToString("F2"));
                Console.ReadLine();
            }
        }
    }
}