// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// Например, [3, 7, 23, 12] -> 26; [-4, -6, 4, 67] -> 0

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

int SumOdd(int[] arr)
{
    int odd = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
            odd += arr[i];
    }
    return odd;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
Console.WriteLine("Сумма элементов на нечётных позициях: " + SumOdd(mass));
