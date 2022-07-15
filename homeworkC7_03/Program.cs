// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}
int[,] GenerateArray(int rows, int columns, int min, int max)
{
    int[,] answers = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answers[i, j] = rnd.Next(min, max + 1);
        }
    }
    return answers;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}
int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
void arithmean(int[,] array)
{
    double summ = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ = (summ + array[i, j]);
        }
        summ = summ / rows;
        Console.Write(summ + "; ");
    }

    return;
}

int[,] myArray = GenerateArray(rows, columns, -10, 10);
PrintArray(myArray);
System.Console.WriteLine();
arithmean(myArray);
