// 5 задача с 5 гирями, найти максимальную, с FOREACH
int n = 5;
int[] arr = { 3, 6, 1, 8, 2 };
int i = 0;
int max = arr[0];

max = arr[0];
foreach (int e in arr)
{
    if (e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);
