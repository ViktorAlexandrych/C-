int Prompt(string msg)
{
	Console.WriteLine($"{msg}");
	return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введи трехзначное число");
if (number < 100 || number >= 1000)
{
	Console.WriteLine("Не обманывай. Пиши трехзначное число");
	return;
}
Console.WriteLine($"{number}");
int secondRank = number / 10 % 10;
Console.Write($"{secondRsaank}");