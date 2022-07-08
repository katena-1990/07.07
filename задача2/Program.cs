// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray(int dimension)
{
    int[] arr = new int[dimension];
    Random randomizer = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(0, 100);
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

void Summ(int[] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            summ = summ + arr[i];
        }
    }
    Console.WriteLine(summ);
}

Console.WriteLine("Введите число элементов массива: ");
int summ = int.Parse(Console.ReadLine());
int[] array = GetArray(summ);
PrintArray(array);
Console.WriteLine();
Summ(array);