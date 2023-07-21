// Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.

int[] randomArray = new int[8];

for (int i = 0; i < 8; i++)
{
	randomArray[i] = new Random().Next(1, 99);
	Console.Write(randomArray[i] + " ");
}