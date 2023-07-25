// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// Операнд случайного вещественного числа rand.NextDouble()
//  rand = new Random();






Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
double[] randomArray = new double[a];

// Задаем случайные вещественные значения элементов массива, где формат вывода - 2 знака после запятой

void GetArray(int a)
{
	Random rand = new Random();
	for (int i = 0; i < a; i++)
	{
		randomArray[i] = rand.NextDouble();
		Console.Write($"{randomArray[i]:F2} ");
	}

}

// Находим минимальное и максимальное через while и 2 if. 
// А после возвращаем результат разницей одного от другого

double GetDifference(double[] randomArray)
{
	double min = randomArray[0];
	double max = randomArray[0];
	int i = 1;
	while (i < randomArray.Length)
	{
		if (max < randomArray[i])
			max = randomArray[i];
		if (min > randomArray[i])
			min = randomArray[i];
		i++;
	}
	return max - min;
}

GetArray(a);
Console.Write($"\nРазница между максимальным и минимальным элементов массива: {GetDifference(randomArray):F2}");