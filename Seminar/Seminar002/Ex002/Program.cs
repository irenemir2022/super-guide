﻿Console.Write("Enter a number:");
int Value2 = Convert.ToInt32(Console.ReadLine());
int Length2 = Value2.ToString().Length;
if (Length2 >= 3) 
  {
	while (Value2 > 999)
	 {
		Value2 = Value2 / 10;
	 }
	  int result = Value2 % 10;
	  Console.WriteLine("The third digit is " + result);
   } 
  else 
	 {
	  Console.WriteLine("The number contains less than 3 digits");
   } 