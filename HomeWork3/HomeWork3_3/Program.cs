Console.Write("Введи число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица кубов:\n");
for (int i = 1; i <= n; i++)
{
	int k = i * i * i;
	Console.Write($"{k} ");
}