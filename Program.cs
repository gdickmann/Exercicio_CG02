public class Main
{
    public static void Main()
    {
        Console.WriteLine("Informe a massa da primeira partícula: ");
        double massa1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a velocidade da primeira partícula: ");
        double velocidade1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe a massa da segunda partícula: ");
        double massa2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a velocidade da segunda partícula: ");
        double velocidade2 = Convert.ToDouble(Console.ReadLine());

        double velocidadeFinal1, velocidadeFinal2;

        velocidadeFinal1 = ((massa1 - massa2) * velocidade1 + 2 * massa2 * velocidade2) / (massa1 + massa2);
        velocidadeFinal2 = ((massa2 - massa1) * velocidade2 + 2 * massa1 * velocidade1) / (massa1 + massa2);

        Console.WriteLine($"A velocidade final da primeira partícula é de {velocidadeFinal1}");
        Console.WriteLine($"A velocidade final da segunda partícula é de {velocidadeFinal2}");
    }
}
