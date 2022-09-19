/*
Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

*/

string[] inputArray = { "Hello", "2", "world", ":-)" };
int size = inputArray.Length;

string[] resultArray = new string[size];

int count = 0; // счетчик количества элементов в новом массиве

Console.WriteLine("Исходный массив: ");
Console.WriteLine($"[ {String.Join(", ", inputArray)} ]");
Console.WriteLine("Результат: ");

for (int i = 0; i < size; i++)
{
    if (inputArray[i].Length <= 3)
    {
        count++;
        resultArray[i] = inputArray[i];
        Console.Write(resultArray[i] + " ");  
        // печать элементов с размером <=3 символам 
    }
}

