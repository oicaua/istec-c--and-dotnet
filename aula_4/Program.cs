using System;

namespace aula_4
{
    class Program {
            static void Main(string[] args) {
                // Console.Write("Num1: ");
                // double num1 = Convert.ToDouble(Console.ReadLine());
                // Console.Write("Num2: ");
                // double num2 = Convert.ToDouble(Console.ReadLine());
                // Console.WriteLine($"A soma é {num1+num2}\nA subtração é {num1-num2}\nA multiplicação é {num1+num2}");

                // Console.WriteLine("Crescimento de Seguidores no Instagram");
                // Console.Write("Num de Seguidores no Mês passado: ");
                // double segMesPassado = Convert.ToDouble(Console.ReadLine());
                // Console.Write("Num de Seguidores no Atualmente: ");
                // double segAtual = Convert.ToDouble(Console.ReadLine());
                // double percentual = -(((segMesPassado-segAtual) / segMesPassado) * 100);

                // Console.WriteLine($"O aumento de um mês ao outro foi de {percentual}%");

                // Console.WriteLine("Calculadora de IMC");
                // Console.Write("Escreva seu Peso: ");
                // double peso = Convert.ToDouble(Console.ReadLine());
                // Console.Write("Escreva sua Altura (em M): ");
                // double altura = Convert.ToDouble(Console.ReadLine());
                // double imc = Convert.ToInt32(peso / (altura*altura));
                // Console.WriteLine(imc);

                Console.WriteLine("Tempo de Viagem");
                Console.Write("Distância em KM: ");
                double distancia = Convert.ToDouble(Console.ReadLine());
                Console.Write("Velocidade Média em km/h: ");
                double velocidadeMedia = Convert.ToDouble(Console.ReadLine());
                double tempo = Convert.ToInt32(distancia/velocidadeMedia);
                Console.WriteLine($"O tempo para chegar ao destino é aproximadamente de {tempo}h");

            }
    }
}