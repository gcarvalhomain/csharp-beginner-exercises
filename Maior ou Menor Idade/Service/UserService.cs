using Identificar_Idade.Models;

namespace Identificar_Idade.Service;

public class UserService
{
    public static List<User> GetUsers = new List<User>()
    {
        new User
        {
            Name = "User1",
            LastName = "Client1",
            Age = 20
        },
        new User
        {
            Name = "User2",
            LastName = "Client2",
            Age = 8
        }
    };
}