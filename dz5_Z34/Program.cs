// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int GetNumber(string message)
{
    Console.Write($"Введите значение {message}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}
void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    { Console.Write($"{arr[i]} "); }
    Console.WriteLine();
}
int Pol(int[] arr)
{
    int rez = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] % 2) == 0) // ((arr[i] & 1) == 0)
        {
           // System.Console.WriteLine($"чисто{arr[i]}четное");
            rez = rez + 1;
        }
    }
    return rez;
}
int size = GetNumber("размерности массива");
int[] array = GetArray(size, 100, 999);
Print(array);
Console.WriteLine($"количество четных значений {Pol(array)}");


