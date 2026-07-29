namespace variaveis.Models;

public class User
{
    public string Name { get; set; } = string.Empty;
    public string LastName { get; set; } =  string.Empty;
    public int Age { get; set; }
    public string Gender { get; set; } = string.Empty;
    public string Password { get; set; }
    public bool Student { get; set; }
}