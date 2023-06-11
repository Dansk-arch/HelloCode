/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.WriteLine("Введите первое число: ");
int NumberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int NumberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число: ");
int NumberThree = Convert.ToInt32(Console.ReadLine());


if(NumberOne>NumberTwo)
{
    Console.WriteLine("Максимальное число: " + Math.Max(NumberOne,NumberThree));
}
else
{
    Console.WriteLine("Максимальное число: " + Math.Max(NumberTwo,NumberThree));
}
    

