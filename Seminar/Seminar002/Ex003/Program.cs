Console.Write("Enter a day of week");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day >= 1 && Day <=7) 
{
	if (Day >= 6) 
	{
		Console.Write("It's a holiday");
	} 
	else 
	{
		Console.Write("Working day");
	}
} 
else 
{
	Console.Write("Enter a valid day between 1 and 7");
}