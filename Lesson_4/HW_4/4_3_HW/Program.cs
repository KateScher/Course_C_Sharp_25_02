// Напишите программу, которая задаёт массив из 8 элементов случайными числами
// и выводит их на экран. Оформите заполнение массива и вывод в виде функции.

int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 100);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return numbers[a];
}