// Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе. Например, 452 -> 11, 82 -> 10, 9012 -> 12.

Console.WriteLine("Введите число:");
int SumNum(int num){
int sum = 0;
for(int i = 0 ; num > 0; i++){
sum = sum + (num % 10);
num = num / 10;
}
return sum;
}

int A = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNum(A));
