Console.WriteLine("Задача 2");
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

  if (a > b && a > c)
     {
      Console.WriteLine("max" + a);
     }
    else
       {
        Console.WriteLine("max" + c);
       }    
       if (b > c)
       {
        Console.WriteLine("max" + b);
       }