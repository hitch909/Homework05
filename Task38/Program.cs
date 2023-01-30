// Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.

Console.Clear();
Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];
for (int i = 0; i < size; i++)
{
    numbers[i] = new Random().Next(1, 20);
    Console.Write($" {numbers[i]} ");
}

Console.WriteLine();
int max = 0;
int min = numbers[0];
int result = 0;
foreach (var i in numbers)
{
    if (i > max) max = i;
    else
    {
        if (i < min) min = i;
    }
}
result = max - min;
Console.Write($"разница между максимальным и минимальным элементов массива = {result}");
