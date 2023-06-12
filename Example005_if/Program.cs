Console.Write("Введите имф пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{   
    Console.WriteLine("Ура, это же MASHA");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}