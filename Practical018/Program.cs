﻿/*Задача 29: Напишите программу, которая задаёт массив
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] a = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };


for (int i = 0; i < a.Length; i++){
    Console.Write($"{a[i]}, ");
}
