// Задача No22.Работа в группах
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// ● 5 -> 1, 4, 9, 16, 25.
// ● 2 -> 1,4

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int stepen = 1; stepen <= number; stepen++)
{
    int result = Math.Pow(stepen, 2);
    Console.WriteLine(result);
}