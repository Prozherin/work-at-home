// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите два числа:");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

double result = 1;

for (int i = 0; i < B; i++)
{
    result *= A;
}

Console.WriteLine($"Результат возведения числа {A} в степень {B}: {result}");