int Prompt(string msg)
{
	Console.WriteLine($"{msg}");
	return Convert.ToInt32(Console.ReadLine());
}
bool weekend(int weekday)
{
	if (weekday > 5)
	{
		return true;
	}
	return false;
}
bool noweekday(int number)
{
	if (number > 0 && number <= 7)
	{
		return true;
	}
	else
	{
		Console.WriteLine("Это не день недели");
		return false;
	}
}
int weekday = Prompt("Введи день недели");
if (noweekday(weekday))
{
	if (weekend(weekday))
	{
		Console.WriteLine("Это выходной день недели");
	}
	else
	{
		Console.WriteLine("Это будний день недели");
	}
}
