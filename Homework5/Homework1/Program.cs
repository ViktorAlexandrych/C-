// Задайте массив заполненный случайными положительными трёхзначными
//  числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

// Задаем случайносгенерированный массив

void GetArray(int a)
{
	for (int i = 0; i < a; i++)
	{
		randomArray[i] = new Random().Next(10, 1000);
		Console.Write(randomArray[i] + " ");
	}

}

// Ищем количество четных чисел в массиве

int amount(int[] randomArray)
{
	int amount = 0;
	for (int i = 0; i < randomArray.Length; i++)
	{
		if (randomArray[i] % 2 == 0)
			amount = amount + 1;
	}
	return amount;
}


GetArray(a);
Console.Write($"\nКоличество чётных чисел в массиве: {amount(randomArray)}");