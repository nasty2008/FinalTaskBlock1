/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо 
задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше 
обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
 */

using static System.Console;
Clear();
string[] array = { "Tom", "Henry","Sam", "Bob", "Henry", "Jessica","Kim", "Bill", "Cat" };
string[] array1 = new string[array.Length];

FillArray(array, array1);
PrintArray(array1);

void FillArray(string[] array, string[] array1)
{
    int a = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array1[a] = array[i];
        a++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
