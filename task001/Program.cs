// Напишите программу, которая выводит случайное число из отрезка [10, 99] и
// показывает наибольшую цифру числа.


Console.Clear();
int num = new Random().Next(10, 99);
Console.WriteLine($"Случайное число: {num}");
int secVal = num % 10;
int firstVal = num / 10;

int max = firstVal;
if (secVal > firstVal)
{
    max = secVal;
}
Console.WriteLine($"Максимальное число - {max}");

