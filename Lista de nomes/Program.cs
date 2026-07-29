namespace Lista_de_nomes;

public class Program
{
    public static void Main(string[] args)
    {
        List<string> clientes = new List<string> { "User1", "User2", "User3", "User4", "User5" };
        
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"clientes: {cliente}");
        }
    }
}