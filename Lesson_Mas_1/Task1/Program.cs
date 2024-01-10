// Как можно задавать массивы

// по одному значению с присвоением индексов
int[] arr = new int[5];
arr[0] = 6;
arr[1] = 5;
arr[2] = 1;
arr[3] = 9;
arr[4] = 2;
Console.WriteLine(arr[0]);
Console.WriteLine(arr[1]);
Console.WriteLine(arr[2]);
Console.WriteLine(arr[3]);
Console.WriteLine(arr[4]);

// в круглых скобказ, предварительно указав размер массива
int[] arr1 = new int[5] { 5; 6; 8; 9; 2 };

// без размера, сразу набор значений массива, их количество и есть размер

int[] arr2 = { 5; 6; 8; 9; 2 };