// Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[rows, colums];

void Massiv(int rows, int colums)
{
	Random rand = new Random();
	for (int i = 0; i < rows; i++)
	{
		Console.WriteLine();
		for (int j = 0; j < colums; j++)
		{
			randomArray[i, j] = rand.Next(1, 9);
			Console.Write($"{randomArray[i, j]} ");
		}
		Console.WriteLine();
	}
}

void ArithmeticException(int rows, int colums)
{
	int i, j;
	Console.Write("Среднее арифметическое каждого столбца: ");
	Random rand = new Random();
	for (j = 0; j < colums; j++)
	{
		double sum = 0;
		for (i = 0; i < rows; i++)
		{
			sum = sum + randomArray[i, j];
		}
		Console.Write($"{sum / (i):F1}; ");
	}
}
Massiv(rows, colums);
ArithmeticException(rows, colums);