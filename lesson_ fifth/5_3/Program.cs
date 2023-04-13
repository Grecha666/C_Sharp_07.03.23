// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]

Console.WriteLine("Напишите размер нового массива: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите начало диапазона массива: ");
int start = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите конец диапазона массива: ");
int stop = int.Parse(Console.ReadLine()!);


void Print(int[] arr)  //выводящая функция
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
     
}

int[] NewMass(int size, int from, int to)  //заполняющая функция
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
        return arr;
}

int Number_of_2digit_numbers(int[] arr)
{

    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (10 <= arr[i] && arr[i] <= 99)
        count = count + 1;
    }
    return count;
}

int[] mass = NewMass(num, start, stop); //возвращаем одномерный массив, 'сложили в коробочку информацию о массиве'
Console.Write("Новый массив: ");   
Print(mass); 
Console.WriteLine();
Console.WriteLine("Количество элементов в массиве в промежутке от [10,99] ");
Console.Write(Number_of_2digit_numbers(mass));   
