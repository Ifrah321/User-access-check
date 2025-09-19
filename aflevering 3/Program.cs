// See https://aka.ms/new-console-template for more information
Console.Write("Brugernavn: ");
string username = Console.ReadLine();

Console.Write("Kodeord: ");
string password = Console.ReadLine();

Console.Write("UserId (heltal): ");
uint userId = uint.Parse(Console.ReadLine());

bool userIsAdmin = userId > 65536;

bool usernameValid = username.Length >= 3;

bool hasSpecial = password.Contains("$") || password.Contains("|") || password.Contains("@");

bool passwordValid = false;
if (userIsAdmin && password.Length >= 20 && hasSpecial)
{
    passwordValid = true;
}
else if (!userIsAdmin && password.Length >= 16 && hasSpecial)
{
    passwordValid = true;
}

Console.WriteLine();
Console.WriteLine("userIsAdmin: " + userIsAdmin);
Console.WriteLine("usernameValid: " + usernameValid);
Console.WriteLine("passwordValid: " + passwordValid);
