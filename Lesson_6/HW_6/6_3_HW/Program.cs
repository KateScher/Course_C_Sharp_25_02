// Напишите программу, которая будет создавать копию заданного массива с помощью
// поэлементного копирования (для вещественных чисел) 


double[] arr = { 0.5, 0.4, 0.7, 0.2, 0.9 };

double[] copy = new double[arr.Length];
arr.CopyTo(copy, 0);

Console.WriteLine(String.Join(", ", copy));
