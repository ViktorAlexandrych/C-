// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0




Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

// Генерируем массив от 1 до 100

void GetArray(int a)
{
	for (int i = 0; i < a; i++)
	{
		randomArray[i] = new Random().Next(1, 100);
		Console.Write($"[{String.Join(" ", randomArray[i])}]");
	}

}

// Ищем сумму элементов на нечетных позициях, где используем переключение счетчика сразу через четный элемент

int GetAmount(int[] randomArray)
{
	int sum = 0;
	int i = 1;
	while (i < randomArray.Length)
	{
		sum = sum + randomArray[i];
		i = i + 2;
	}
	return sum;
}

GetArray(a);
Console.Write($"\nCумма элементов, стоящих на нечётных позициях: {GetAmount(randomArray)}");