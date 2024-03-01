using System;
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a distância em metros: ");
        double distancia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o tempo em segundos: ");
        double tempo = Convert.ToDouble(Console.ReadLine());

        double velocidadeMedia = distancia / tempo;

        Console.WriteLine("A velocidade média é: " + velocidadeMedia + " m/s");
    }
}
