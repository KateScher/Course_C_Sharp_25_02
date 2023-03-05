// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// Пример: 14212 -> нет, 23432 -> да, 12821 -> да.

Console.WriteLine ("Введите 5-ти значное число: ");

string number = Console.ReadLine()!;
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number [1] == number[3])
    {
        Console.WriteLine(number + "Yes, this numer is palindrom");
    }

    else
    {
        Console.WriteLine(number + " No, this numer is not palindrom");
    }
}
else
{
    Console.WriteLine ("Введите пятизначное число");
}


