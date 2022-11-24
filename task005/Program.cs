// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


Console.Clear();
Console.WriteLine("Введите число №1: ");
int value1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №2: ");
int value2 = int.Parse(Console.ReadLine());

double Pow1 = Math.Pow(value1, 2);
double Pow2 = Math.Pow(value2, 2);

if (value2 > value1)
{
    if (Pow1 == value2)
    {
        Console.WriteLine("YES!");
    }
    else
    {
        Console.WriteLine("NO!");
    }
}
else
{
    if (Pow2 == value1)
    {
        Console.WriteLine("YES!");
    }
    else
    {
        Console.WriteLine("NO!");
    }

}