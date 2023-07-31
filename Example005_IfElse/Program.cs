Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if (username.ToLower() == "mikhail")
{
    Console.WriteLine("Шабат-шалом, Mikhail");
}
else 
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}