//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите индекс строки, нужного вам элемента: ");
int num1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите индекс столбца, нужного вам элемента: ");
int num2 = int.Parse(Console.ReadLine() ?? "");


int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
FindNeedEl(array, num1, num2);

void FindNeedEl(int[,] arr, int number1, int number2)
{
    if (number1 >= arr.Length || number2 >= arr.Length)
    {
        Console.Write("Такого элемента нет в массиве");
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == number1 && j == number2)
            {
                int res = arr[i, j];
                Console.Write($"Ваш элемент -> {res}");
                break;
            }
        }
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}