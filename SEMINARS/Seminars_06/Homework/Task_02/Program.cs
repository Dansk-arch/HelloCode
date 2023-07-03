/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


(double XCoordinate, double YCoordinate) SeacIntersectionLines (double bone, double kone, double btwo, double ktwo)
{
    double XCoord = (btwo-bone)/(kone-ktwo);
    double YCoord = (kone*btwo-ktwo*bone)/(kone-ktwo);
    return (XCoordinate:XCoord, YCoordinate:YCoord);
}

double GetNumber (string decription)
{
    double number;
    Console.Write($"{decription} =>");

    while (true)
    {
        string temp = Console.ReadLine();
        if(double.TryParse(temp, out number))
        {
            return number;
        }
        else
        {
            Console.Write($"This number \"{temp}\" is not correct. Try again =>");
        }  
    }
}

double bone = GetNumber("Input b1");
double kone = GetNumber("Input k1");
double btwo = GetNumber("Input b2");
double ktwo = GetNumber("Input k2");

var tuple = SeacIntersectionLines(bone,kone,btwo,ktwo);


Console.WriteLine($"({tuple.XCoordinate};{tuple.YCoordinate})");
