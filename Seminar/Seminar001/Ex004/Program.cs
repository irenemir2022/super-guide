Console.WriteLine("Задача 4");
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int Startnumber= 1;
 while(Startnumber <= N)
  { 
    if (Startnumber %2 == 0)
     if (Startnumber == N || Startnumber == N - 1) Console.WriteLine(Startnumber);
      else
       Console.Write(Startnumber + ",");
    Startnumber ++;
  }

System.Console.WriteLine();