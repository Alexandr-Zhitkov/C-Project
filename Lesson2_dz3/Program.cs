// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine()!);

if (num <= 5)
{
  System.Console.WriteLine("нет, это будний день");
}
else
{
  System.Console.WriteLine("да, это выходной");
}