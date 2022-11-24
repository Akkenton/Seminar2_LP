// Напишите программу, которая выводит случайное число из отрезка [10, 99] и
// показывает наибольшую цифру числа.


Console.Clear();
int num = new Random().Next(10, 99);
Console.WriteLine($"Случайное число: {num}");
int secVal = num % 10;
int firstVal = num / 10;
if (secVal > firstVal)
{
    Console.WriteLine($"Большая цифра в двузначном числе: {secVal}");
}
if (secVal < firstVal)
{
    Console.WriteLine($"Большая цифра в двузначном числе: {firstVal}");
}
if (secVal == firstVal)
{
    Console.WriteLine($"Большая цифра в двузначном числе: {firstVal}");
}
