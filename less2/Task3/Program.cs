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

// int N = 10;
// int[] arr = { 2, 3, 5, 6, 8, 4, 10, 13, 18, 20 };
// int i = 0;
// int max = arr[0];

// while (i < N) // While
// {
//     if (arr[i] > max)
//     {
//         max = arr[i];
//     }
//     i = i + 1;
// }
// Console.WriteLine(max);

// max = arr[0];
// for (int j = 0; j < N; j++) // For
// {
//     if (arr[j] > max)
//     {
//         max = arr[j];
//     }
// }
// Console.WriteLine(max);

// max = arr[0];
// foreach (int e in arr) // Foreach
// {
//     if (e > max)
//     {
//         max = e;
//     }
// }
// Console.WriteLine(max);


// Проход по элемнтам массива:
// int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write($"{arr[i]} ");
// }

// Задача где число итераций фиксированно:
// int N = 100;
// int sum = 0;

// for (int i = 1; i < N; i++)
// {
//     sum = sum + i;
// }
// Console.Write(sum);