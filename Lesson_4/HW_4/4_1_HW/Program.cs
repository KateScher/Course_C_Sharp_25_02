// Напишите цикл, который принимает на вход два числа (А и В) и возводит
// число А в натуральную степень В.
// 3, 5 -> 243 (3 в 5); 2, 4 -> 16

Console.WriteLine("введите число A");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("введите число B");
int b = int.Parse(Console.ReadLine()!);

int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine("A в степени B равно: " + step);
