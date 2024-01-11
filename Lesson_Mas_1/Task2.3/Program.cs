// Дано 5 гирь с разным весом в случайном порядке. Определить вес самой тяжелой гири

int n = 5;
int[] arr = {2,6,3,9,1};
int i = 0;
int max = arr[0];

while(i < n)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i = i + 1;
}
Console.WriteLine(max);

