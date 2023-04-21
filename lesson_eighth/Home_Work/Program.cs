// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*
int row = InputNum("Введите количество строк: ");
int column = InputNum("Введите количество столбцов: ");
int range = InputNum("Введите диапазон матрицы: ");

int[,] array = new int[row, column];
CreateArray(array);
PrintArray(array);

int InputNum(string input)
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine()!);
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

void FromMaxToMin(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int n = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = n;
                }
            }
        }
    }
}

FromMaxToMin(array);
Console.WriteLine(array);
PrintArray(array);

*/

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
int row = InputNum("Введите количество строк: ");
int column = InputNum("Введите количество столбцов: ");
int range = InputNum("Введите диапазон матрицы: ");

int[,] array = new int[row, column];
CreateArray(array);
WriteArray(array);

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

int minSumLine = 0;
int SumMin = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int new_temp = SumLineElements(array, i);
  if (SumMin > new_temp)
  {
    SumMin = new_temp;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa, сумма значений которой наименьшая во всей матрице ({SumMin}) ");


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int InputNum(string input)
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine()!);
  return output;
}

*/

//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int row_1 = InputNum("Введите количество строк для 1 матрицы: ");
int column_1 = InputNum("Введите количество столбцов для 1 матрицы: ");
int row_2 = InputNum("Введите количество строк для 2 матрицы: ");
int column_2 = InputNum("Введите количество столбцов для 2 матрицы ");
int range = InputNum("Введите диапазон матриц: ");

int[,] Martrix1 = new int[row_1, column_1];
CreateArray(Martrix1);
Console.WriteLine($"Первая матрица:");
PrintArray(Martrix1);

int[,] Martrix2 = new int[column_1, row_2];
CreateArray(Martrix2);
Console.WriteLine($"Вторая матрица:");
PrintArray(Martrix2);

int[,] resultMatrix = new int[row_1,row_2];

int InputNum(string input)
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine()!);
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

MultiplyMatrix(Martrix1, Martrix2, resultMatrix);
Console.WriteLine($"Произведение матриц:");
PrintArray(resultMatrix);


