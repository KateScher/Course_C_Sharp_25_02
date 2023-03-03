// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет. 
// Напр., 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6.

Console.Write("Введите число: ");

string s_a = Console.ReadLine()!;
int a = int.Parse(s_a);

if (s_a.Length > 2){
  Console.WriteLine(s_a[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}


