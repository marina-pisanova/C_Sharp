﻿// Напишите программу, которая будет принимать на вход два 
// числа и выводить, является ли второе число кратным первому. 
// Если второе число некратно первому, то программа выводит 
// остаток от деления.


int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if(a%b==0){Console.WriteLine("yes");}
else{Console.WriteLine("no" + a%b);}
