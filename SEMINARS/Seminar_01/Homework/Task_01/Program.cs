/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
Console.WriteLine("Введите первое число: ");
int NumberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int NumberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Максимальное число: " + Math.Max(NumberOne,NumberTwo));
Console.WriteLine("Минимальное число: " + Math.Min(NumberOne,NumberTwo));