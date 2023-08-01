//  Напишите программу, которая на вход принимает позиции элемента 
//  в двумерном массиве, и возвращает значение этого элемента 
//  или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[rows, colums];




void Index(int rows, int colums)
{
	Console.Write("Введите индекс строки: ");
	int rowsindex = Convert.ToInt32(Console.ReadLine());
	Console.Write("Введите индекс столбца: ");
	int columsindex = Convert.ToInt32(Console.ReadLine());
	Random rand = new Random();
	if (rowsindex < rows && columsindex < colums)
	{
		for (int j = 0; j < colums; j++)
		{
			for (int i = 0; i < rows; i++) ;
		}
		Console.WriteLine($"Значение элемента на этой позиции: {randomArray[rowsindex, columsindex]}");
	}
	else Console.WriteLine($"Индекс строки {rowsindex}, индекс столбца {columsindex} -> такого числа в массиве нет");
}

void CreateRandomArray(int rows, int colums)
{
	int i, j;
	Random rand = new Random();
	for (i = 0; i < rows; i++)
	{
		Console.WriteLine();
		for (j = 0; j < colums; j++)
		{
			randomArray[i, j] = rand.Next(1, 9);
			Console.Write($"{randomArray[i, j]} ");
		}
		Console.WriteLine();
	}
}


CreateRandomArray(rows, colums);
Index(rows, colums);