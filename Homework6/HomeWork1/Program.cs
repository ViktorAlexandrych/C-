// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[a];

void GetArray(int m)
{
	for (int i = 0; i < m; i++)
	{
		Console.WriteLine($"Введите {i + 1} элемент массива ");
		Array[i] = Convert.ToInt32(Console.ReadLine());
	}

}

int GetCount(int[] Array)
{
	int count = 0;
	for (int i = 0; i < Array.Length; i++)
	{
		if (Array[i] > 0)
			count = count + 1;
	}
	return count;
}

GetArray(a);
Console.Write($"\n Чисел больше нуля: {GetCount(Array)}");
