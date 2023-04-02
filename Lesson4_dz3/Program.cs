// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)


int[] FillMass(int size)
{
  int[] Rezult = new int[size];
  for (int i = 0; i < size; i++)
  {
    Rezult[i] = new Random().Next();
  }
  return Rezult;
}

System.Console.WriteLine("Введите размерность массива ");
int number = int.Parse(Console.ReadLine()!);
int[] massive = FillMass(number);

System.Console.WriteLine($"{String.Join("; ", massive)}");

