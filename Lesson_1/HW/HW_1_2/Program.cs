// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// например:2, 3, 7 -> 7

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
int more = 0;

if (a > b) {
    more = a;
}
else more = b;

if (a > c) {
    more = a;
}
else more = c;

Console.WriteLine(more);
