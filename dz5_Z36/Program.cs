// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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
    { Console.Write($"   {arr[i]} "); }
    Console.WriteLine();
}
int Summa(int[] arr)
{
    int rez = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        rez = rez + arr[i];
    }
    return rez;
}
int size = GetNumber("размерности массива");
int min = GetNumber("минимальное массива");
int max = GetNumber("максимальное массива");
int[] array = GetArray(size, min, max);
Print(array);
int rez = Summa(array);
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях: {rez}");



