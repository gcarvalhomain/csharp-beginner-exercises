namespace Par_ou_Impar;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o primeiro numero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.Write("Par");
        }
        else
        {
            Console.Write("Impar");
        }
    }
}