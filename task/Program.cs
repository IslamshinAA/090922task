// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for(int i =0; i < b; i++)
// {
//     result = result * a;
// }
// Console.WriteLine(result);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int n = Convert.ToInt32(Console.ReadLine());
// int result = 0;
// while(n > 0) 
// {
// result = result + n % 10;
// n /= 10;
// }
// Console.WriteLine(result);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
// int [] array = new int [8];
// int n = 0;
// for (int i = 0; i < array.Length; i++)
// { n = Convert.ToInt32(Console.ReadLine());
//     array[i] = n;
// }
// Console.WriteLine("[" + string.Join(", ", array) + "]");