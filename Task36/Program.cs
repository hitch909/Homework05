//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
int[] GetArray(int size, int min, int max)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
        res[i] = new Random().Next(min, max);
    return res;
}
int[] array = GetArray(6, 1, 10);
Console.WriteLine(String.Join(", ", array));

void NegativArray(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        summ = summ + array[i];
    }
    Console.WriteLine($"сумма элементов, стоящих на нечётных позициях = {summ}");
}
NegativArray(array);
