Console.WriteLine("Задача 4");
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int Startnumber = 1;

    while(Startnumber <= N)
      { 
        if (Startnumber %2 == 0)
        Console.Write(Startnumber + ",");
        Startnumber ++;
      }

