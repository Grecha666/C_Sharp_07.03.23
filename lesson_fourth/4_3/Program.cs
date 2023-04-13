// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

PrintArray(MakeArray());

 int[] MakeArray()
 {
    int[] arr = new int[8];
    for(int i = 0; i < 8; i++)
    {
        arr[i] = GeneralNumber();
    }
    return arr;
 }
 
 int GeneralNumber()
 {
    int number = new Random().Next(2);
    return number;
 }

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

