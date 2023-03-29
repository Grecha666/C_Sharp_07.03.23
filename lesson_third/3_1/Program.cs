// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y])

void Quarters(int num)
{
    if (num == 1)
    {    
        Console.WriteLine("Значения x > 0, y > 0");
    }    
    else if(num == 2)
    {
        Console.WriteLine("Значения x < 0, y > 0");
    }
    else if(num == 3)
    {
       Console.WriteLine("Значения x < 0, y < 0"); 
    }
    else if(num == 4)
    {
       Console.WriteLine("Значения x > 0, y < 0");
    }
    else 
    {
       Console.WriteLine("ЭРОР!!! Ты написал число, не соответствующее номеру четверти!");
    }
}

Console.WriteLine("Напиши число, соответствующее номеру четверти (1, 2, 3 или 4) "); 
int quarter_number = int.Parse(Console.ReadLine()!);

Quarters(quarter_number);

