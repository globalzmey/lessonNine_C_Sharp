/*
Задача 66: Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int m, n;

Console.Write("Введите значение числа M: ");
m = ReadNumberFromConsole();
Console.Write("Введите значение числа N: ");
n = ReadNumberFromConsole();

Console.Write($"M = {m}; N = {n} -> ");
Console.WriteLine(SumOfElements(m, n));

int ReadNumberFromConsole()
{
  string? input = Console.ReadLine();
  return int.Parse(input);
}

int SumOfElements(int n, int m)
{
  if (n == m) return n;
  else return SumOfElements(n + 1, m) + n;
}