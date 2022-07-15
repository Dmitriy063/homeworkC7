// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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
void Position(int[,] array)
{
    int a = 0;
    int b = 0;
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (a == i && b == j)
            {
                
                System.Console.WriteLine($"Запрашиваемый элемент {array[i,j]}");
            }
            else {System.Console.WriteLine("Элемент не существует");}
            }
    }
    
    return;
}

int rows = Prompt("Введите количество строк: ");
int columns = Prompt("Введите количество столбцов: ");
int[,] myArray = GenerateArray(rows, columns, -10, 10);
PrintArray(myArray);
int a = Prompt("Введите строку элемента: ");
int b = Prompt("Введите столбец элемента: ");
if (a > myArray.GetLength(0) || b > myArray.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента строки: {a} столбца: {b} равно {myArray[a-1,b-1]}");
}
System.Console.WriteLine();

