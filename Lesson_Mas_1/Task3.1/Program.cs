// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 
// Программа должна выдать ответ: Да/Нет. Примеры [1 3 4 19 3], 8 => Нет [-4 3 4 1], 3 => Д


int[] arr = { 1, 5, -2, 5, 7, -8, -6 };
int a = int.Parse(Console.ReadLine()!);
bool b = false;
for (int i = 0; i < arr.Length; i++)
{
    if (a == arr[i])
        b = true;
}
if (b)
    Console.Write("Yes");
else
    Console.Write("No");
