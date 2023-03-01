// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// например:2, 3, 7 -> 7

int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

if (a > b) {
    if (a > c) {
    Console.WriteLine(a);
    }
    else {
    Console.WriteLine(c);
    }
}
else {
    if (b > c) {
        Console.WriteLine(b);
    }
    else {
        Console.WriteLine(c);
    }
}



