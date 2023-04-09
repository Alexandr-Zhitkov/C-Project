// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



Console.WriteLine("Введите число ");
string number = Console.ReadLine()!;
if (number.Length == 3)
{
  System.Console.WriteLine($"{number[1]}");
}
else
{
  System.Console.WriteLine("Введено неверное число");
}