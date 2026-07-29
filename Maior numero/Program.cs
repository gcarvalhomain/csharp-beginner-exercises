namespace Maior_numero;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o primeiro numero: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo numero: ");
        int numero2 = int.Parse(Console.ReadLine());
        Console.Write("Digite o terceiro numero: ");
        int numero3 = int.Parse(Console.ReadLine());

        if (numero >= numero2 && numero >= numero3)
        {
            Console.WriteLine($" O maior valor e: {numero} .");
        }

        if (numero2 >= numero && numero2 >= numero3)
        {
            Console.WriteLine($" O maior valor e: {numero2}");
        }
        else
        {
            Console.WriteLine($" O maior valor e: {numero3}.");
        }
    }
}