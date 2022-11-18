Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "alexander")
{
    Console.WriteLine("Ура, это же ALEXANDERrrrr");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}