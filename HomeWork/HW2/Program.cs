﻿// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
//в которой находится эта точка.

int x = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);

if(x > 0 && y > 0){Console.WriteLine("1");}
    if(x < 0 && y > 0){Console.WriteLine("2");}
        if(x < 0 && y < 0){Console.WriteLine("3");}
else{Console.WriteLine("4");}
