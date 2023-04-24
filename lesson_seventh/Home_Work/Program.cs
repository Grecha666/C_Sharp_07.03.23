// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*ПЕРВЫЙ ВАРИАНТ 

void FillArrayRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-1000, 1000)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.WriteLine("Количество строк");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Количество столбцов");
int b = int.Parse(Console.ReadLine()!);

double[,] numbers = new double[a, b];
FillArrayRandom(numbers);
PrintArray(numbers);
*/

/*ВТОРОЙ ВАРИАНТ

void Print(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        
            Console.Write($" {arr[i,j], 6} ");
        Console.WriteLine();
        
    }
    Console.WriteLine();
}

double[,] MassNums(int row, int column, int from, int to)
{
    double[,] arr = new double[row, column];
    Random n_new = new Random();

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i,j] = Math.Round(n_new.NextDouble() * (to - from) + from, 2);
        }
    }
    return arr;
}

Console.WriteLine("Напиши количество строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши количество столбцов: ");
int column_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши начало: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши конец: ");
int stop = int.Parse(Console.ReadLine()!);
Console.WriteLine();

double[,] array = MassNums(row_num, column_num, start, stop);
Print(array);
Console.WriteLine();
*/

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*ПЕРВЫЙ ВАРИАНТ

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.WriteLine("введите количество строк");
int string1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[string1, columns];

FillArrayRandom(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / string1;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);
*/

/* ВТОРОЙ ВАРИАНТ
void PrintArray(int[,]arr) 
{
    int rows_size = arr.GetLength(0);
    int colums_size = arr.GetLength(1);

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int rows, int colums, int from, int to) 
{
    int[,] arr = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            arr[i,j] = new Random().Next(from, to + 1);
        }
    }
    return arr;
}
    
void ArithmeticMean(int[,] arr)
{
    int row = arr.GetLength(0);
    int colum = arr.GetLength(1);
    double res;

    for (int i = 0; i < colum; i++)
    {
        res = 0;
        for (int j = 0; j < row; j++)
        {
            res+=arr[j,i];
        }
        Console.WriteLine($"{Math.Round(res/row, 2)}; ");
        
    }

}

Console.WriteLine("Напиши количество строк: ");
int rows_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши количество столбцов: ");
int colums_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши начало: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши конец: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] array = MassNums(rows_num, colums_num, start, stop);
PrintArray(array);
ArithmeticMean(array);
*/

//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void PrintArray(int[,]arr) 
{
    int rows_size = arr.GetLength(0);
    int colums_size = arr.GetLength(1);

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int rows, int colums, int from, int to) 
{
    int[,] arr = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            arr[i,j] = new Random().Next(from, to + 1);
        }
    }
    return arr;
}

string FindElement(int[,] arr, int f, int s)
{
    int row = arr.GetLength(0);
    int colum = arr.GetLength(1);

    if(f <= 0 || f > row || s <= 0 || s > colum)
    {
        return $"Элемента с координатами [{f}, {s}] - нет в массиве";
    }
    else
    {
        return $"Элемент есть в массиве! Его координаты: {arr[f-1, s-1]}";
    }
}

Console.WriteLine("Напиши количество строк: ");
int rows_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши количество столбцов: ");
int colums_num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши начало: ");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши конец: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] array = MassNums(rows_num, colums_num, start, stop);
PrintArray(array);

Console.WriteLine("Напиши первую координату искомого числа: ");
int n  = int.Parse(Console.ReadLine()!);
Console.WriteLine("Напиши вторую координату искомого числа: ");
int m  = int.Parse(Console.ReadLine()!);
Console.WriteLine(FindElement(array, n, m));

//ЗДЕСЬ КАКАЯ-ТО ОШИБКА В ТЕРМИНАЛЕ, НА ДРУГОМ ТЕРМИНАЛЕ ВСЕ РАБОТАЕТ