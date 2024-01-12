// int[] array = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };
//         int count = CountElementsInRange(array, 10, 90);
//         Console.WriteLine("Количество элементов, значения которых лежат в интервале [10, 90]: " + count);

//     static int CountElementsInRange(int[] array, int minRange, int maxRange)
//     {
//         int count = 0;
//         int i = 0;

//         while (i < array.Length)
//         {
//             if (array[i] >= minRange && array[i] <= maxRange)
//             {
//                 count++;
//             }
//             i++;
//         }

//         return count;
//     }


// int[] array = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };
// int countFor = CountElementsInRangeWithFor(array, 10, 90);
// int countWhile = CountElementsInRangeWithWhile(array, 10, 90);

// Console.WriteLine("Количество элементов, значения которых лежат в интервале [10, 90] (с использованием цикла for): " + countFor);
// Console.WriteLine("Количество элементов, значения которых лежат в интервале [10, 90] (с использованием цикла while): " + countWhile);

// static int CountElementsInRangeWithFor(int[] array, int minRange, int maxRange)
// {
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= minRange && array[i] <= maxRange)
//         {
//             count++;
//         }
//     }

//     return count;
// }

// static int CountElementsInRangeWithWhile(int[] array, int minRange, int maxRange)
// {
//     int count = 0;
//     int i = 0;

//     while (i < array.Length)
//     {
//         if (array[i] >= minRange && array[i] <= maxRange)
//         {
//             count++;
//         }
//         i++;
//     }

//     return count;
// }

// int[] numbers = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };
// int minRange = 10;
// int maxRange = 90;
// int countFor = CountItemRangeWithFor(numbers, minRange, maxRange);
// int countWhile = CountItemRangeWithWhile(numbers, minRange, maxRange);

// Console.Write("Количество элементов массива, попадающих в диапазон [{0}, {1}] (с использованием цикла for): ", minRange, maxRange);
// Console.WriteLine(countFor);

// Console.Write("Количество элементов массива, попадающих в диапазон [{0}, {1}] (с использованием цикла while): ", minRange, maxRange);
// Console.WriteLine(countWhile);

// static int CountItemRangeWithFor(int[] numbers, int minRange, int maxRange)
// {
//     int count = 0;

//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] >= minRange && numbers[i] <= maxRange)
//         {
//             count++;
//         }
//     }

//     return count;
// }

// static int CountItemRangeWithWhile(int[] numbers, int minRange, int maxRange)
// {
//     int count = 0;
//     int i = 0;

//     while (i < numbers.Length)
//     {
//         if (numbers[i] >= minRange && numbers[i] <= maxRange)
//         {
//             count++;
//         }
//         i++;
//     }

//     return count;
// }


// int[] array = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };
// int minRange = 10;
// int maxRange = 90;
// int countFor = CountItemRangeWithFor(array, minRange, maxRange);
// int countWhile = CountItemRangeWithWhile(array, minRange, maxRange);

// PrintResult(countFor);
// PrintResult(countWhile);

// static int CountItemRangeWithFor(int[] array, int minRange, int maxRange)
// {
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= minRange && array[i] <= maxRange)
//         {
//             count++;
//         }
//     }

//     return count;
// }

// static int CountItemRangeWithWhile(int[] array, int minRange, int maxRange)
// {
//     int count = 0;
//     int i = 0;

//     while (i < array.Length)
//     {
//         if (array[i] >= minRange && array[i] <= maxRange)
//         {
//             count++;
//         }
//         i++;
//     }

//     return count;
// }

// static void PrintResult(int result)
// {
//     Console.WriteLine("Количество элементов массива, попадающих в заданный диапазон: " + result);
// }


// int[] array = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };

// int result = CountItemsRange(array, 10, 90);
// Console.Write(result);

// static int CountItemsRange(int[] array, int minRange, int maxRange)
// {
//     int count = 0;

//     foreach (int item in array)
//     {
//         if (item >= minRange && item <= maxRange)
//         {
//             count++;
//         }
//     }

//     return count;
// }