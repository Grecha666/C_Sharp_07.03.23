it // Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый на последнем и т.д)

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

void RevMass(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size/2; i++)
    (arr[i], arr[size - i - 1]) = (arr[size - i - 1], arr[i]);   // способ Кортежей

  
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
RevMass(mass); 
Console.WriteLine();
Console.Write("Массив - перевертыш: ");  
Print(mass); 

