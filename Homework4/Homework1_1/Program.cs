// Напишите цикл , который принимает на вход два числа {А и В)
// и возводит число А в натуральную степень В.
// 3, 5 -> 243 (3 5 )
// 2, 4 -> 16

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = 1;
if (b < 1)
	Console.Write("Число B должно быть натуральным\n");
else
{
	while (b != 0)
	{
		c = c * a;
		b = b - 1;
	}
	Console.Write($"Число A в натуральной степени B равно {c}");
}
