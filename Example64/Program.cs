/* Задача 64:  Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"n={n}, m={m}");
if (m>n)
for (int i = n; i <= m; i++)
    Console.Write($" {i}");
else
    for (int i = m; i <= n; i++)
        Console.Write($" {i}");