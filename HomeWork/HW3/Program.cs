// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

Console.Write("Enter number [10, 99]: ");
int a = int.Parse(Console.ReadLine()!);
int FirstNum = a / 10;
int SecondNum = a % 10;
int max = FirstNum  > SecondNum ? FirstNum  : SecondNum;
Console.WriteLine(max);