Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine("Урряя это же Манька!!! ");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}