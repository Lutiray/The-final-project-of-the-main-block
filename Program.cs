﻿/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив 
из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести 
с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

int FilterString(string[] array)
{
    int count = 0;
    foreach (string element in array)
    {
        if (element.Length <= 3)
        {
            count++;
        }
    }

    return count;
}

string[] CreatingNewArray(string[] array)
{
    string [] result = new string[FilterString(array)];
    int index = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[index] = array[i];
            index++;
        }
    }

    return result;
}

void OutputArray(string[] resultArray, string[] array)
{
    Print(array);
    Console.Write(" => ");
    if (resultArray.Length != 0)
    {
        Print(resultArray);
    }
    else Console.WriteLine("[]");
}

void Print(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"\"{array[i]}\", ");
    }
    Console.Write($"\"{array[array.Length - 1]}\"");
    Console.Write("]");
}

string[] array1 = new string[] { "Hello", "2", "world", ":-)" };
string[] array2 = new string[] { "1234", "1567", "-2", "computer science" };
string[] array3 = new string[] { "Russia", "Denmark", "Kazan" };

OutputArray(CreatingNewArray(array1), array1);
Console.WriteLine();
OutputArray(CreatingNewArray(array2), array2);
Console.WriteLine();
OutputArray(CreatingNewArray(array3), array3);

