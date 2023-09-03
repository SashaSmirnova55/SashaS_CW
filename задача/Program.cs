﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array1 = { "123", "23", "hello", "world", "res" };


string[] SecondArrayWithIF(string[] array1)
{

    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array1[count] = array1[i];
            count++;
        }
    }
    Console.WriteLine(string.Join(", ", array1));

    string[] array2 = new string[count];
    for (int i = 0; i < count; i++)
    {
        array2[i] = array1[i];
    }
    return array2;



}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


PrintArray(SecondArrayWithIF(array1));