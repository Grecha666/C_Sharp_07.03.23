// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
void Print(int[] arr)  //выводящая функция
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");  
}

int[] NewMass(int size)  //заполняющая функция
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(100,1000);
        return arr;
}

int Pos_Numbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    if(arr[i]%2==0)
    {
        count = count + 1;
    }
    return count;
}

Console.WriteLine("Напишите размер нового массива: ");
int num = int.Parse(Console.ReadLine()!);

int[] mass = NewMass(num); //возвращаем одномерный массив, 'сложили в коробочку информацию о массиве'
Console.Write("Новый массив: ");   
Print(mass); 
Console.WriteLine();
Console.WriteLine("Количество чётных чисел в массиве равно: ");
Console.WriteLine(Pos_Numbers(mass));
*/

//Задайте одномерный массив, заполненный случайнми числами. Найдите сумму элементов, стоящих на нечётных позициях

/*
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

int SumOddNumber(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    sum = sum + arr[i];
    return sum;
}


Console.WriteLine("Напишите размер нового массива: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите начало диапазона массива: ");
int start = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите конец диапазона массива: ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = NewMass(num, start, stop); //возвращаем одномерный массив, 'сложили в коробочку информацию о массиве'
Console.Write("Новый массив: ");   
Print(mass); 
Console.WriteLine();
int a = SumOddNumber(mass);
Console.Write($"Cумма элементов, стоящих на нечётных позициях равна: {a}"); 
*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

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

Console.WriteLine("Напишите размер нового массива: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите начало диапазона массива: ");
int start = int.Parse(Console.ReadLine()!);

Console.WriteLine("Напишите конец диапазона массива: ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = NewMass(num, start, stop); //возвращаем одномерный массив, 'сложили в коробочку информацию о массиве'
Console.Write("Новый массив: ");   
Print(mass); 
Console.WriteLine();

