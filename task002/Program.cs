// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int numberOne = number / 100;
int numberThree = number % 10;

Console.Write(numberOne);
Console.Write(numberThree);