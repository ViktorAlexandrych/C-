// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка



Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[rows, colums];

void Massiv(int rows, int colums)
{
	int i, j;
	Random rand = new Random();
	for (i = 0; i < rows; i++)
	{
		for (j = 0; j < colums; j++)
		{
			randomArray[i, j] = rand.Next(1, 9);
		}
	}
}

void PrintRows(int[,] array)
{
	int i, j;
	for (i = 0; i < array.GetLength(0); i++)
	{
		Console.WriteLine();
		for (j = 0; j < array.GetLength(1); j++)
		{
			Console.Write($"{array[i, j]} ");
		}
		Console.WriteLine();
	}
}

Massiv(rows, colums);
Console.WriteLine("\nИсходный массив: ");
PrintRows(randomArray);

// Функция, считающая сумму элементов в строке
int SumLine(int[,] array, int i)
{
	int sum = array[i, 0];
	for (int j = 1; j < array.GetLength(1); j++)
	{
		sum += array[i, j];
	}
	return sum;
}

int MinSum = 1;
int sum = SumLine(randomArray, 0);
for (int i = 1; i < randomArray.GetLength(0); i++)
{
	if (sum > SumLine(randomArray, i))
	{
		sum = SumLine(randomArray, i);
		MinSum = i + 1;
	}
}

Console.WriteLine($"\nСтрока c наименьшей суммой элементов: {MinSum}");