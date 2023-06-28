/*
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным вещественной частью элементов массива.
[3.1, 7.01, 22.002] => 0.1 - 0.002 = 0.098
*/


double [] CreateDoubleArray (int size, int min, int max)
{
    double [] array = new double [size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.NextDouble()*(max-min)+min;
    }
    return array;   
}

int [] ReTypeArray (double [] array)
{
    int size = array.Length;
    int [] NewArray = new int [size];
    for (int i = 0; i < size; i++)
    {
        NewArray[i] = (int)array[i];
    }
    return NewArray; 
}

double [] GetRNambersInArray (double [] DoubleArray, int [] IntArray)
{
    int size=DoubleArray.Length;
    double [] RArray = new double [size];
    for (int i = 0; i < size; i++)
    {
        RArray[i]=DoubleArray[i]-IntArray[i];
    }
    return RArray;
}

(double MinInDoubleArray,double MaxInDoubleArray, double ResultMaxMinForDoubleArray) SeachMinMaxInDoubleArray (double [] ArrayWithRNumber)
{
    double min=ArrayWithRNumber[0];
    double max=ArrayWithRNumber[0];
    foreach (double item in ArrayWithRNumber)
    {
        min = item<min ? item : min;
        max = item>max ? item : max;
    }
    double result = max-min;
    return (MinInDoubleArray: min,MaxInDoubleArray:max,ResultMaxMinForDoubleArray:result);
}

string PrintArrayDouble (double [] array)
{
    return string.Join(", ", array);
}

string PrintArrayInt (int [] array)
{
    return string.Join(", ", array);
}


double [] Array = CreateDoubleArray(3,-10, 10);
int [] NewArray = ReTypeArray(Array);
double [] RArray = GetRNambersInArray(Array, NewArray);
var tuple = SeachMinMaxInDoubleArray(RArray);
// Console.WriteLine($"Original array with numbers double type [{PrintArrayDouble(Array)}] ->");
// Console.WriteLine($"Array with numbers int type [{PrintArrayInt(NewArray)}] ->");
// Console.WriteLine($"Array with Real Numbers [{PrintArrayDouble(RArray)}] ->");
Console.WriteLine($"In array with numbers double type [{PrintArrayDouble(Array)}]");
Console.WriteLine($" difference real parts numbers [{PrintArrayDouble(RArray)}]");
Console.WriteLine($" between Max value is {tuple.MaxInDoubleArray} and Min value is {tuple.MinInDoubleArray}");
Console.WriteLine($" result is {tuple.ResultMaxMinForDoubleArray}");

