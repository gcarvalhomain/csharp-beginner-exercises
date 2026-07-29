namespace Operacoes_Matematicas;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o primeiro numero: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo numero: ");
        int num2 = int.Parse(Console.ReadLine());

        int soma = num1 + num2;
        int divisao = num1 / num2;
        int subtracao = num1 % num2;
        int multiplicacao = num1 % num2;

        Console.WriteLine($"A soma dos valores e:{soma}");
        Console.WriteLine($"A soma dos valores e:{divisao}");
        Console.WriteLine($"A soma dos valores e:{subtracao}");
        Console.WriteLine($"A soma dos valores e:{multiplicacao}");
    }
}