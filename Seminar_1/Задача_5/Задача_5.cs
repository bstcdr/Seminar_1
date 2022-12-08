/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456->6 782->2 918->8
*/
string N = Console.ReadLine();

if (int.Parse(N) < 100 || int.Parse(N) > 999)
{
    Console.WriteLine("Не трехзначное число");
}
else 
{
    Console.WriteLine(N[2]);
}