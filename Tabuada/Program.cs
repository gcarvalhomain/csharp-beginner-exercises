namespace Tabuada;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o numero que deseja verificara a tabuada: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{num} x {num} = {i * num}\n");
        }
 
        Console.WriteLine("------------");
    }
}