namespace Metodo_calculo;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o primeiro valor: ");
        int valor1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        int valor2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a operacao que deseja calcular o valor +, -, * ou /: ");
        string operacao = Console.ReadLine();
        
        switch (operacao)
        {
            case "+":
                Console.WriteLine($"Resultador: {valor1 + valor2}");
                break;
            case "-":
                Console.WriteLine($"Resultado: {valor1 - valor2}");
                break;
            case "*":
                Console.WriteLine($"Resultado: {valor1 * valor2}");
                break;
            case "/":
                Console.WriteLine($"Resultado: {valor1 / valor2}");
                break;
            default:
                Console.WriteLine("Valores invalidos.");
                break;
        }
    }
}