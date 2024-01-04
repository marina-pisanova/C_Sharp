// Напишите программу, которая выводит третью с конца 
// цифру заданного числа или сообщает, что третьей цифры нет.

int a = int.Parse(Console.ReadLine()!);
if(a<100){Console.WriteLine("no");}
else{Console.WriteLine("yes" +a/100%10);}