// Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.

// rows = 3, columns = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[rows, columns];

void massiv(int rows, int columns)
{
	int i, j;
	Random rand = new Random();
	for (i = 0; i < rows; i++)
	{
		Console.WriteLine();
		for (j = 0; j < columns; j++)
		{
			randomArray[i, j] = rand.NextDouble();
			Console.Write($"{randomArray[i, j]:F2} ");
		}

	}

}

massiv(rows, columns);