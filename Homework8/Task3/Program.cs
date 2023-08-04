// Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18




int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] firstArray = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

FillArrayRandom(firstArray);
PrintArray2D(firstArray);

Console.WriteLine();

FillArrayRandom(secondArray);
PrintArray2D(secondArray);

Console.WriteLine();

if (firstArray.GetLength(0) != secondArray.GetLength(1))
{
	Console.WriteLine(" Нельзя перемножить ");
	return;
}
for (int i = 0; i < firstArray.GetLength(0); i++)
{
	for (int j = 0; j < secondArray.GetLength(1); j++)
	{
		resultArray[i, j] = 0;
		for (int k = 0; k < firstArray.GetLength(1); k++)
		{
			resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
		}
	}
}

PrintArray2D(resultArray);




int ReadInt(string message)
{
	Console.Write(message);
	return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandom(int[,] firstArray)
{
	for (int i = 0; i < firstArray.GetLength(0); i++)
	{
		for (int j = 0; j < firstArray.GetLength(1); j++)
		{
			firstArray[i, j] = new Random().Next(1, 10);
		}
	}
}

void PrintArray2D(int[,] firstArray)
{
	for (int i = 0; i < firstArray.GetLength(0); i++)
	{
		for (int j = 0; j < firstArray.GetLength(1); j++)
		{
			Console.Write($"{firstArray[i, j]} ");
		}
		Console.WriteLine();
	}
}