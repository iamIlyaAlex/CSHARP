// Массивы!!! Урок2 - 2-Лекция

// int[] arr = new int[5]; // new int[5] - выделение памяти
// arr[0] = 1; // array - имя, 1,3,5,7,9 - элементы массива
// arr[1] = 3; // [0], [1], [2], [3], [4] - индекс массива
// arr[2] = 5;
// arr[3] = 7;
// arr[4] = 9;
// Console.WriteLine(arr[0]);
// Console.WriteLine(arr[1]);
// Console.WriteLine(arr[2]);
// Console.WriteLine(arr[3]);
// Console.WriteLine(arr[4]);

// int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };

// int[] arr3 = { 1, 2, 3, 4, 5 }; // можно не использовать "new int[5]" - так как нам известно, 
// сколько элементов,  и для создания небольших массивов

// Задача1
// Заполнение и вывод произвольного массива
// Создать массив и заполнить его целыми числами от 1 до N, N - произвольное натуральное число. Вывести элемента массива на экран.

// Этапы решения!
// Первый - ВВод N
// Второй - Создание массива
// Третий - Заполнение массива
// Четвёртый - Вывод массива на экран

// int n = 10;

// int[] arr = new int[n];
// int i = 0;

// while (i < n) // можно пользоваться свойством массива arr.length
// {
//     arr[i] = i + 1;
//     // Console.Write(arr[i]);
//     // Console.Write(' ');
//     Console.Write($"{arr[i]}  ");
//     i = i + 1;
// }

// int n = 10;

// int[] numbers = { 1, 3, 5, 6, 8, 4, 10, 13, 18, 20 };
// Console.WriteLine("Четные числа:");
// foreach (int number in numbers)
// {
//     if (number % 2 == 0)
//     {
//         Console.WriteLine(number);
//     }
// }

// Console.WriteLine("Нечетные числа:");
// foreach (int number in numbers)
// {
//     if (number % 2 != 0)
//     {
//         Console.WriteLine(number);
//     }
// }


// c FOR циклом!!!
// int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Console.WriteLine("Четные числа:");
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         Console.WriteLine(array[i]);
//     }
// }

// Console.WriteLine("Нечетные числа:");
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 != 0)
//     {
//         Console.WriteLine(array[i]);
//     }
// }


// while (i < array.Length)
// {
//     if (array[i] % 2 == 0)
//     {
//         Console.Write($"Чётные числа массива: {array[i]} ");
//     }
//     i = i + 1;

//     if (array[i] % 2 == 1)
//     {    
//         Console.Write($"Нечётные числа массива: {array[i]} ");
//     }
//     i = i + 1;
// }



// int n = 11;
// int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Console.WriteLine("Чётные числа массива: ");
// for (int i = 0; i < array.Length; i += 2)
//     Console.Write("  " + array[i]);

// Console.WriteLine("Нечётные числа массива: ");
// for (int i = 1; i < array.Length; i += 2)
//     Console.Write("  " + array[i]);



// Вывод ЧЁТНЫХ ЧИСЕЛ !!! 
// int n = 5; НЕ НУЖНО ПИСАТЬ!!!
// int[] array = {1,2,3,5,6};
// int i = 0;

// while(i < array.Length)
//  {
//     if(array[i] % 2 == 0)
//     {
//         Console.Write(array[i]);
//     }
//     i = i + 1;
//  }


// Вывод НЕЧЁТНЫХ ЧИСЕЛ !!! 
// int[] array = {1,2,3,5,6};
// int i = 0;

// while(i < array.Length)
//  {
//     if(array[i] % 2 == 1)
//     {
//         Console.Write(array[i]);
//     }
//     i = i + 1;
//  }