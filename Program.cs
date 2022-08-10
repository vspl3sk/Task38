// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();

double[] CreateArrayRndInd(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(rnd.Next(min, max + 1)) / 10;
    }
    return arr;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

double[] array = CreateArrayRndInd(5, 1, 999);
PrintArray(array);
Console.WriteLine();

double minNum = array[0];
double maxNum = array[0];

for (int m = 0; m < array.Length; m++)
{
    if (maxNum < array[m]) maxNum = array[m];
    if (minNum > array[m]) minNum = array[m];
}
double res = maxNum - minNum;
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива - > {res}");