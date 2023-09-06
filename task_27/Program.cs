// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число:");
int number = Int32.Parse(Console.ReadLine());

int sumOfDigits = 0;
while (number > 0)
{
    sumOfDigits += number % 10;
    number /= 10;
}

Console.WriteLine("Сумма чисел равна " + sumOfDigits.ToString() + ".");