// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. РЕзультат записать в новом массиве

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
int[] pairsArr = MyltiplyPairs(mass);
Console.WriteLine("Новый массив, созданный из произведения пар элементов в выведенном выше массиве:");
Print(pairsArr);

int[] NewMass(int size, int from, int to)  //заполняющая функция
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
        return arr;
}

void Print(int[] arr)  //выводящая функция
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
     
}

int[] MyltiplyPairs(int[] array)
{
    int arrLength = array.Length;
    int[] pairs = new int[arrLength/2 + arrLength%2];

    for (int i = 0; i < arrLength/2; i++)
    {
        pairs[i] = array[i] * array[arrLength - i - 1];
    }
    if (arrLength%2 == 1)
    {
        pairs[pairs.Length - 1] = array[arrLength - 1];
    }
    return pairs;
}




