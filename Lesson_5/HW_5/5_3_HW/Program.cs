// Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// Например, [3, 7, 22, 2, 78] -> 76


int Find_Min_Max_diff(int[] arr)
{
    int result = 0;
    int min = 0;
    int max = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[min] > arr[i])
            min = i;
        else if (arr[max] < arr[i])
            max = i;
    }
    Console.WriteLine("min= " + arr[min] + "\tmax= " + arr[max]);
    if (arr[min] > arr[max])
        result = arr[min] - arr[max];
    else if (arr[max] > arr[min])
        result = arr[max] - arr[min];
    return result;
}
Console.Write("введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] arr = new int[size];
Console.Write("введите минимальное значение: ");
int Min = int.Parse(Console.ReadLine()!);
Console.Write("введите максимальное значение: ");
int Max = int.Parse(Console.ReadLine()!);
int temp = 0;
if (Min > Max)
{
    temp = Max;
    Max = Min;
    Min = temp;
}
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
    arr[i] = rand.Next(Min, Max);
for (int i = 0; i < arr.Length; i++)
    Console.Write(arr[i] + "\t");


Console.WriteLine("разница между минимальным и максимальным элементами массива=" + Find_Min_Max_diff(arr));
  