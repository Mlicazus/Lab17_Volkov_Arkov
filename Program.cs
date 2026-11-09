// 2. Массив для проверки алгоритмов:

// int[] scores = { 60, 80, 40, 80, 90 };
// int sum = 0;
// int min = 1000000000;
// int max = -1;
// int count = 0;
// int first = 0;
// for (int i = 0; i < scores.Length; i++)
// {
//     sum += scores[i];
//     if (scores[i] < min)
//     {
//         min = scores[i];
//     }
//     if (scores[i] > max)
//     {
//         max = scores[i];
//     }
//     if (scores[i] >= 50)
//     {
//         count++;
//     }
// }
// while (scores[first] != 80)
// {
//     first++;
// }
// System.Console.WriteLine($"Сумма: {sum}");
// System.Console.WriteLine($"Минимум: {min}");
// System.Console.WriteLine($"Максимум: {max}");
// System.Console.WriteLine($"Количество 50+: {count}");
// System.Console.WriteLine($"Первый индекс 80: {first}");

// 3. Сумма элементов:

// int sum = 0;
// foreach (int score in scores)
// {
//     sum += score;
// }
// int SumArray(int[] numbers)
// {
//     int sum = 0;

//     foreach (int number in numbers)
//     {
//         sum += number;
//     }

//     return sum;
// }
// Console.WriteLine(SumArray(scores));

// int SumArray(int[] numbers)
// {
//     int sum = 0;

//     foreach (int number in numbers)
//     {
//         sum += number;
//     }

//     return sum;
// }

// Console.WriteLine(SumArray(new int[] { 5, -2, 7 }));

// 4. Подсчёт элементов по условию:

// int count = 0;
// int CountAtLeast(int[] numbers, int limit)
// {
//     int count = 0;

//     foreach (int number in numbers)
//     {
//         if (number >= limit)
//         {
//             count++;
//         }
//     }

//     return count;
// }
// Console.WriteLine(CountAtLeast(scores, 50));

// int CountAtLeast(int[] numbers, int limit)
// {
//     int count = 0;

//     foreach (int number in numbers)
//     {
//         if (number >= limit)
//         {
//             count++;
//         }
//     }

//     return count;
// }
// Console.WriteLine(CountAtLeast(new int[] { 40, 50, 80 }, 50));

// 5. Минимум и максимум:

// int[] numbers = { -10, -3, -20 };
// int FindMax(int[] scores)
// {
//     int max = scores[0];

//     for (int i = 1; i < scores.Length; i++)
//     {
//         if (scores[i] > max)
//         {
//             max = scores[i];
//         }
//     }

//     return max;
// }

// int FindMin(int[] scores)
// {
//     int min = scores[0];

//     for (int i = 1; i < scores.Length; i++)
//     {
//         if (scores[i] < min)
//         {
//             min = scores[i];
//         }
//     }

//     return min;
// }
// System.Console.WriteLine(FindMin(scores));
// System.Console.WriteLine(FindMax(scores));

// int FindMin(int[] numbers)
// {
//     int min = 1000000000;

//     foreach (int number in numbers)
//     {
//         if (number < min)
//         {
//             min = number;
//         }
//     }

//     return min;
// }
// Console.WriteLine(FindMin(new int[] { 12, 4, 9 }));

// 6. Линейный поиск и индекс:

// int FindIndex(int[] numbers, int target)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] == target)
//         {
//             return i;
//         }
//     }
//     return -1;
// }
// Console.WriteLine(FindIndex(scores, 80));
// Console.WriteLine(FindIndex(scores, 100));

// int FindIndex(int[] numbers, int target)
// {
//     int index = -1;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] == target)
//         {
//             index = i;
//             break;
//         }
//     }
//     return index;
// }
// Console.WriteLine(FindIndex(scores, 80));
// Console.WriteLine(FindIndex(scores, 60));
// Console.WriteLine(FindIndex(scores, 100));

// 7. Основная часть — «Анализатор результатов»:

// int[] scores = new int[7];
// for (int i = 0; i < scores.Length; i++)
// {
//     Console.Write($"Результат {i + 1}: ");
//     scores[i] = Convert.ToInt32(Console.ReadLine());
// }
// int SumArray(int[] numbers)
// {
//     int sum = 0;

//     foreach (int number in numbers)
//     {
//         sum += number;
//     }

//     return sum;
// }
// int FindMin(int[] scores)
// {
//     int min = scores[0];

//     for (int i = 1; i < scores.Length; i++)
//     {
//         if (scores[i] < min)
//         {
//             min = scores[i];
//         }
//     }

//     return min;
// }
// int FindMax(int[] scores)
// {
//     int max = scores[0];

//     for (int i = 1; i < scores.Length; i++)
//     {
//         if (scores[i] > max)
//         {
//             max = scores[i];
//         }
//     }

//     return max;
// }
// int CountAtLeast(int[] numbers, int limit)
// {
//     int count = 0;

//     foreach (int number in numbers)
//     {
//         if (number >= limit)
//         {
//             count++;
//         }
//     }

//     return count;
// }
// int FindIndex(int[] numbers, int target)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] == target)
//         {
//             return i;
//         }
//     }
//     return -1;
// }
// int sum = SumArray(scores);
// int min = FindMin(scores);
// int max = FindMax(scores);
// int count = CountAtLeast(scores, 50);
// System.Console.WriteLine(">>> Анализ результатов <<<");
// System.Console.WriteLine();
// System.Console.WriteLine($"Сумма: {sum}");
// System.Console.WriteLine($"Минимум: {min}");
// System.Console.WriteLine($"Максимум: {max}");
// System.Console.WriteLine($"Результатов 50 и больше: {count}");
// System.Console.Write("Какой результат найти: ");
// int target = int.Parse(System.Console.ReadLine());
// int index = FindIndex(scores, target);
// if (index != -1)
// {
//     System.Console.WriteLine($"Первый индекс: {index}");
// } else
// {
//     System.Console.WriteLine("Результат не найден");
// }
