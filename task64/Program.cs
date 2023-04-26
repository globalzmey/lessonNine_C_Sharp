/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
     Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int n;

Console.Write("Введите целое положительное число N: ");
n = ReadNumberFromConsole();
Console.Write($"N = {n} -> \"");
Console.WriteLine(NaturalNumber(n, 1) + "\"");

int ReadNumberFromConsole()
{
  string? input = Console.ReadLine();
  return int.Parse(input);
}

int NaturalNumber(int n, int m)
{
  if (n == m) return n;
  else Console.Write($"{NaturalNumber(n, m + 1)}, ");
  return m;
}