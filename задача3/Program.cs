// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] GetArray(int dimension)
{
    int[] arr = new int[dimension];
    Random randomizer = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(1, 21);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void MaxMin(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];

        if (arr[i] < min) min = arr[i];
    }

    Console.WriteLine("max: " + max);
    Console.WriteLine("min: " + min);
    Console.WriteLine($"Разница мужду максимальным и минимальным числом - " + (max - min));
}

int[] array = GetArray(10);
PrintArray(array);
Console.WriteLine();
MaxMin(array);

