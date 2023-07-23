/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetFuncAccerman(int numberM, int numberN)
{

    if (numberM == 0)
        return numberN + 1;
    else
    {
        if ((numberM > 0) && (numberN == 0))
        {
            return GetFuncAccerman(numberM - 1, 1);
        }
        else
        {
            return GetFuncAccerman(numberM - 1, GetFuncAccerman(numberM, numberN - 1));
        }
    }
}

    Console.WriteLine("input M");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input N");
    int numberN = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int number = GetFuncAccerman(numberM, numberN);
    Console.WriteLine(number);