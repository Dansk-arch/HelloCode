/* Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int GetNumber (string decription)
{
    int number;
    Console.Write($"{decription} =>");

    while (true)
    {
        string temp = Console.ReadLine();
        if(int.TryParse(temp, out number))
        {
            return number;
        }
        Console.Write($"This number \"{temp}\" is not correct. Try again =>");
    }
}

int ExpNumber (int NumberOne, int NumberTwo)
{
    int Exp = (int) Math.Pow(NumberOne,NumberTwo);
    return Exp;
}

Console.Write(ExpNumber(GetNumber("Input first number"),GetNumber("Input second number")));

