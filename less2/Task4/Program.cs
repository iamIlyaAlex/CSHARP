// // 1 задача
// while (true) // Бесконечный цикл
//         {
//             Console.Write("Введите целое число или 'q' для выхода: ");
//             string? input = Console.ReadLine();

//             if (input == "q")
//             {
//                 Console.WriteLine("Программа завершена. ");
//                 break;
//             }

//             int number;
//             if (int.TryParse(input, out number))
//             {
//                 int sum = 0;
//                 int digit = Math.Abs(number);

//                 while (digit > 0)
//                 {
//                     sum += digit % 10;
//                     digit /= 10;
//                 }

//                 if (sum % 2 == 0)
//                 {
//                     Console.WriteLine("Сумма цифр числа чётная. Программа завершена.");
//                     break;
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Некорректный ввод. Попробуйте снова. ");
//             }
//         }


// while (true)
// {
//     Console.WriteLine("Введите целое число или 'q' для выхода:");
//     string input = Console.ReadLine();

//     if (input == "q")
//     {
//         Console.WriteLine("Программа завершена.");
//         return;
//     }

//     bool isNumber = true;
//     int number = 0;

//     for (int i = 0; i < q; i++)
//     {
//         if (input[i] >= '0' && input[i] <= '9')
//         {
//             number = number * 10 + (input[i] - '0');
//         }
//         else
//         {
//             isNumber = false;
//             break;
//         }
//     }

//     if (isNumber)
//     {
//         int sum = 0;
//         int tempNumber = Math.Abs(number);

//         while (tempNumber > 0)
//         {
//             sum += tempNumber % 10;
//             tempNumber /= 10;
//         }

//         if (sum % 2 == 0)
//         {
//             Console.WriteLine("Сумма цифр числа чётная. Программа завершена.");
//             return;
//         }
//     }
//     else
//     {
//         Console.WriteLine("Некорректный ввод. Попробуйте снова.");
//     }
// }


// {
//     while (true)
//     {
//         Console.Write("Введите целое число или 'q' для выхода: ");
//         string? input = Console.ReadLine();

//         if (input == "q")
//         {
//             return;
//         }

//         int number;
//         if (int.TryParse(input, out number))
//         {
//             if (number < 0)
//             {
//                 number = -number;
//             }

//             int sum = 0;
//             int digit = number;

//             while (digit > 0)
//             {
//                 sum += digit % 10;
//                 digit /= 10;
//             }

//             if (sum % 2 == 0)
//             {
//                 return;
//             }
//         }
//     }
// }



//  int[] numbers = new int[10]; // Задаем массив размером 10

//         Random random = new Random(); // Создаем экземпляр класса Random

//         // Заполняем массив случайными трехзначными числами
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = random.Next(100, 1000);
//         }

//         int count = 0; // Переменная для подсчета количества четных чисел

//         // Перебираем элементы массива и проверяем, является ли число четным
//         foreach (int number in numbers)
//         {
//             if (Convert.ToInt32(number) % 2 == 0)
//             {
//                 count++;
//             }
//         }

//         Console.WriteLine("Количество четных чисел: " + count);


// Задача 2
// {
//     int[] numbers = new int[10]; // Задаем массив размером 10
//     Random random = new Random(); // Создаем экземпляр класса генератор чисел
//     int count = 0; // Переменная для подсчета количества чётных чисел

//     for (int i = 0; i < numbers.Length; i++) // Заполняем массив случайными трехзначными числами
//     {
//         numbers[i] = random.Next(100, 1000); // Случайное число от 100 до 999
//         Console.Write(numbers[i] + " "); // Вывод сгенерированных чисел


//         // Перебираем элементы массива и проверяем, является ли число чётным
//         if (numbers[i] % 2 == 0)
//         {
//             count++; // Увеличиваем счетчик чётных чисел
//         }
//     }
//     Console.WriteLine($"\nКоличество чётных чисел в массиве: {count}"); // Вывод количества чётных чисел в массиве
// }


// int[] array = { 1, 2, 1000, 123, 99 };
//     {
//         Console.WriteLine("Исходный массив:");
//         PrintArray(array);

//         // Переворачиваем массив
//         ReverseArray(array);

//         Console.WriteLine("Перевернутый массив:");
//         PrintArray(array);
//     }

//     static void ReverseArray(int[] array)
//     {
//         int start = 0;
//         int end = array.Length - 1;

//         while (start < end)
//         {
//             // Обмен значениями
//             int temp = array[start];
//             array[start] = array[end];
//             array[end] = temp;

//             start++;
//             end--;
//         }
//     }

//     static void PrintArray(int[] array)
//     {
//         foreach (int element in array)
//         {
//             Console.Write(element + " ");
//         }
//         Console.WriteLine();
//     }

//Задача 3
// {
//     int[] array = { 1, 8, 12, 4, 26 }; //Исходный массив
//     int temp;

//     Console.Write("Исходный массив: "); // Вывод исходного массива
//     foreach (int arr in array)
//     {
//         Console.Write(arr + " ");
//     }

//     for (int i = 0; i < array.Length / 2; i++) // Реверс массива
//     {
//         temp = array[i];
//         array[i] = array[array.Length - 1 - i]; // меняем местами значения
//         array[array.Length - 1 - i] = temp;
//     }

//     Console.Write("\nПеревернутый массив: "); // Вывод изменённого массива
//     foreach (int arr in array)
//     {
//         Console.Write(arr + " ");
//     }
// }