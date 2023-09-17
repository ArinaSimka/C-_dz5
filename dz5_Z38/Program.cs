// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double GetNumber(string message)
{
    Console.Write($"Введите значение {message}:");
    double num = Convert.ToInt32(Console.ReadLine());
    return num;
}
double[] GetArray(int size)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((rand.NextDouble()*100),2);
    }
    return array;
}
void Print(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    { Console.Write($"   {arr[i]} "); }
    Console.WriteLine();
}
double MaxN(double[] arr)
{
    double Nmax = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (Nmax < arr[i])
        {
            Nmax = arr[i];
        }
    }
    return Nmax;
}
double MinN(double[] arr)
{
    double Nmin = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (Nmin > arr[i])
        {
            Nmin = arr[i];
        }
    }
    return Nmin;
}
Console.Write("Введите размерность массива: ");
string strNum = Console.ReadLine();
int size = int.Parse(strNum);

double[] array = GetArray(size);
Print(array);
double Nmin = MinN(array);
double Nmax = MaxN(array);

double rez = Math.Round((Nmax - Nmin),2);
Console.WriteLine($"разница максимального числа {Nmax} и минимального {Nmin} = {rez}");
