
Console.Write("Введите номер четверти: ");
int quarterNumber = int.Parse(Console.ReadLine());
if (quarterNumber > 0 & quarterNumber < 5)
{
    if (quarterNumber == 1)
    {
        Console.WriteLine("x > 0 и y > 0");
    }
    if (quarterNumber == 2)
    {
        Console.WriteLine("x < 0 и y > 0");
    }
    if (quarterNumber == 3)
    {
        Console.WriteLine("x < 0 и y < 0");
    }
    if (quarterNumber == 4)
    {
        Console.WriteLine("x > 0 и y < 0");
    }
}
else
{
    Console.WriteLine("Просьба указать номер четверти (1, 2, 3, 4)");
}