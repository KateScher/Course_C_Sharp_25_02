// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7     -2     -0,2
// 1    -3,3   8     -9,9
// 8     7,8  -7,1    9


int m = 3, n = 4;
double[,] arr = new double[m, n];
Random rand = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr [i,j] = (double)rand.Next(-100,100)/10;
        Console.Write(arr[i,j] + "\t");
    }
    Console.WriteLine();
}

