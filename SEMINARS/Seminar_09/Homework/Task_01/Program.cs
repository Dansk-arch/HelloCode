/*
Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void GetNaturNumber(int number)
{
    Console.Write($"{number},");
    if (number > 1) GetNaturNumber(number - 1);
}


Console.WriteLine("enter the output number of the sequence of numbers");

int number = Convert.ToInt32(Console.ReadLine());
GetNaturNumber(number);