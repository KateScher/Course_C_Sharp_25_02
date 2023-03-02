// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа. Например, 456 -> 46, 782 -> 72, 918 -> 98. 

int result = new Random().Next(100, 1000);

Console.WriteLine(result);
Console.WriteLine((result / 100 * 10) + (result % 10));
