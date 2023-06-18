/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetCoordinateArg ()
{
    Console.WriteLine("Введите последовательно координаты А(Х,У,W), В(Х,У,W)");
    int Coordinate = Convert.ToInt32(Console.ReadLine());
    return Coordinate; 
}

int [] GetArrayCoordinate (int CoordX, int CoordY, int CoordZ)
{
    int [] GetArrayCoordinateXYZ = {CoordX, CoordY, CoordZ};
    return GetArrayCoordinateXYZ;
}

double GetDistance(int[] GetArrayA, int[] GetArrayB)
{
    int pow = 2;
    double sum = 0;
    for (int i = 0; i < 3; i++) //3 т.к. трехмерное пространство - 3 координаты
    {
        sum = sum +  Math.Pow((GetArrayA[i]-GetArrayB[i]),pow);
    }
    double distance = Math.Sqrt(sum);
    return distance;
}

void WriteDist (double number)
{
    Console.WriteLine(number);
}


int[] ArrayA = GetArrayCoordinate(GetCoordinateArg(),GetCoordinateArg(),GetCoordinateArg());
int[] ArrayB = GetArrayCoordinate(GetCoordinateArg(),GetCoordinateArg(),GetCoordinateArg());
double DistanceAB = GetDistance(ArrayA,ArrayB);
WriteDist(DistanceAB);
