// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Clear();
Console.WriteLine("Введите число для проверки");
int number = int.Parse(Console.ReadLine());
if ((number % 7 == 0) && (number % 23 == 0))
{
    Console.WriteLine($"Кратно одновременно!");
}
else
{
    Console.WriteLine($"Не кратно одновременно!");
}
