using Identificar_Idade.Service;

namespace Identificar_Idade;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um nome: ");
        string? name = Console.ReadLine();

        var nome = UserService.GetUsers.FirstOrDefault(x => x.Name == name);
        if (nome != null)
        {
            Console.WriteLine($"Nome: {nome.Name}");
            Console.WriteLine($"LastName: {nome.LastName}");
            Console.WriteLine($"Age: {nome.Age}");
            if (nome.Age >= 18)
            {
                Console.WriteLine("Maior Idade");
            }
            else
            {
                Console.WriteLine("Menor Idade");
            }
        }
        else
        {
            Console.WriteLine("Nenhum usuario encontrado.");
        }
    }
}