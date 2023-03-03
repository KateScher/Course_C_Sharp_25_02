// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// Например, 6 -> да, 7 -> да, 1 -> нет

Console.Write("Введите цифру, обозначающую день недели: ");

void dayOfWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    Console.WriteLine("Этот день выходной? -> да");
    else Console.WriteLine("Этот день выходной? -> нет");
}
dayOfWeek(int.Parse(Console.ReadLine()!));