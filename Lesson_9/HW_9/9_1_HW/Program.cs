// Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// М = 1; N = 5 -> "2, 4"
// М = 4; N = 8 -> "4, 6, 8"

Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);

void chet(int M, int N)
{
    if (M > N)
        return;
    if (M % 2 == 0)
    {
        Console.Write($"{ M}, ");
    }
chet(M + 1, N);

}
chet(M, N);