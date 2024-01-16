// int N = 4;
// int[] arr = new int[N];
// int i = 0;

// while (i < arr.Length)
// {
//     arr[i] = i + 1;
//     Console.Write($"{arr[i]} ");
//     i = i + 1;
// }

// int T = 10;
// int[] arr1 = new int[T];
// int i = 0;

// while (i < arr1.Length)
// {
//     arr1[i] = i + 1;
//     Console.Write($"{arr1[i]} ");
//     i = i + 1;
// }

// int N = 10;
// int[] array = { 1, 4, 6, 8, 3, 5, 22, 24, 88, 90 };
// int i = 0;

// while (i < array.Length)
// {
//     if(array[i] % 2 == 0)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     i = i + 1;
// }

int N = 10;
int[] arr = { 2, 3, 5, 6, 8, 4, 10, 13, 18, 20 };
int i = 0;
int max = arr[0];

while (i < N)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i = i + 1;
}
Console.Write(max);