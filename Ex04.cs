public class Ex04
{
    public static void Main()
    {
        Console.WriteLine("Informe a massa do pêndulo: ");
        double massa = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe o comprimento da corda: ");
        double comprimento = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Informe a gravidade: ");
        double gravidade = Convert.ToDouble(Console.ReadLine());

        double resultado = (2 * Math.PI) * Math.Sqrt(comprimento / gravidade);

        Console.WriteLine($"O movimento do pêndulo é de {resultado}");
    }
}
