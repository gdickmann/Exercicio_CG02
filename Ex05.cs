using System;

namespace MovimentoCircular
{
    class Ex05
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o raio da trajetória circular (em metros): ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a velocidade angular (em radianos por segundo): ");
            double velocidadeAngular = Convert.ToDouble(Console.ReadLine());

            // Calcular a velocidade tangente
            double velocidadeTangente = raio * velocidadeAngular;

            // Calcular a aceleração centrípeta
            double aceleracaoCentripeta = Math.Pow(velocidadeAngular, 2) * raio;

            // Exibir os resultados
            Console.WriteLine("A velocidade tangente é: " + velocidadeTangente + " m/s");
            Console.WriteLine("A aceleração centrípeta é: " + aceleracaoCentripeta + " m/s²");

            Console.ReadKey();
        }
    }
}
