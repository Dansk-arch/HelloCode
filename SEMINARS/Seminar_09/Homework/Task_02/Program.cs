/*
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

int GetNaturNumber(int numberM, int numberN)
{
   
    if (numberM <= numberN) 
    {
        return numberM + GetNaturNumber(numberM + 1, numberN);
    }
    else
    {
        return 0;
    }

}

Console.WriteLine("input M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input N");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int number = GetNaturNumber(numberM, numberN);
Console.WriteLine(number);