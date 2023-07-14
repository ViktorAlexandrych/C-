int Prompt(string msg)
{
	Console.WriteLine($"{msg}");
	return Convert.ToInt32(Console.ReadLine());
}

int fnumber(int number)
{
	while (number > 999)
	{
		number /= 10;
	}
	return number % 10;
}

bool check(int number)
{
	if (number < 100)
	{
		Console.WriteLine("Не обманывай! Цифр меньше трех!");
		return false;
	}
	else return true;
}
int number = Prompt("Введи трехзначное или больше число");
if (check(number))
{
	Console.WriteLine(fnumber(number));
}