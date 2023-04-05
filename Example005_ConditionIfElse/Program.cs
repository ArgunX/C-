Console.Write("Введте имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Привет любимчик!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
