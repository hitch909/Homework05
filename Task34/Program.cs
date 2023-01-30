//  Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
int[] GetArray(int size, int min, int max)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
        res[i] = new Random().Next(min, max + 1);
    return res;
}
int[] array = GetArray(12, 100, 999);
Console.WriteLine(String.Join(", ", array));

void PositivArray(int[] array)
{
    int res = 0;
    foreach (int i in array)
    {
        if (i % 2 == 0) res++;
    }
    Console.WriteLine($"количество четных чисел в массиве = {res}");
}
PositivArray(array);