using variaveis.Service;

namespace variaveis;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite seu primeiro nome:");
        string? name = Console.ReadLine();
        
        var user = UserService.Usuarios.FirstOrDefault(u => u.Name == name);
        if (user != null)
        {
            Console.WriteLine($"Nome: {user.Name}");
            Console.WriteLine($"Senha: {user.Password}");
            Console.WriteLine($"LastName: {user.LastName}");
            Console.WriteLine($"Age: {user.Age}");
            Console.WriteLine($"Estudante? {user.Student}");
        }
        else
        {
            Console.WriteLine("Nenhum usuario encontrado");
        }
    }
}
