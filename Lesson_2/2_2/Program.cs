// Напишите программу, которая принимает на вход трёхзначное 
// число и возводит вторую цифру этого числа в степень, равную 
// третьей цифре.

Console.WriteLine("Enter number");
int a = int.Parse(Console.ReadLine()!);
int SecondNum = a / 10 % 10;
int ThirdNum = a % 10;
Console.WriteLine(Math.Pow(SecondNum, ThirdNum));
