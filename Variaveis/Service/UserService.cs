using variaveis.Models;

namespace variaveis.Service;

public class UserService
{
    public static List<User> Usuarios = new()
    {
        new User
        {
            Name = "User1",
            LastName = "Cliente1",
            Age = 20,
            Gender = "Masculino",
            Password = "111111",
            Student = true
        },
        new User
        {
            Name = "User2",
            LastName = "Client2",
            Age = 10,
            Gender = "Masculino",
            Password = "222222",
            Student = true
        },
        new User
        {
            Name = "Ana",
            LastName = "Carvalho",
            Age = 18,
            Gender = "Masculino",
            Password = "333333",
            Student = false
        }
    };
}