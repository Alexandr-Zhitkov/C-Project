// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите число ");
int number1 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите 2 число");
int number2 = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите 3 число");
int number3 = int.Parse(Console.ReadLine()!);
if (number1 > number2 && number1 > number3)
{
  Console.WriteLine($"Наибольше число {number1}"!);
}
if (number2 > number1 && number2 > number3)
{
  Console.WriteLine($"Наибольше число {number2}"!);
}
if (number3 > number1 && number3 > number2)
{
  Console.WriteLine($"Наибольшее число {number3}"!);
}