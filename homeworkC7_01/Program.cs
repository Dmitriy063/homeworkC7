// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}
double[,] GenerateArray(int rows, int columns, int min, int max)
{
    double[,] answers = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
           answers[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
    return answers;
}
void PrintArray(double[,] array)
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
double[,] myArray = GenerateArray(rows, columns, -100, 100);
PrintArray(myArray);