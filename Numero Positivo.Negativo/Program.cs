namespace Numero_Positivo_Negativo;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero <= 0)
        {
            Console.WriteLine("Numero negativo");
        }
        else
        {
            Console.WriteLine("Numero positivo");
        }
    }
}