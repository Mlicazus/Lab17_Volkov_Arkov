int[] scores = { 60, 80, 40, 80, 90 };
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

