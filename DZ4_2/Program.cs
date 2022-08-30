// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");

int GetSumNums(int number)
{
    int sum = 0;
    while(number>0)
    {
        sum+=number%10;
        number/=10;
    }
    return sum;
}

// почему-то не работает:  ((((
// int num = Convert.ToInt32(Console.ReadLine());
// string result = Convert.ToString(num);
// int index = 0;
// int summa = 0;

// while(index < result.Length)
// {
//     summa = summa + Convert.ToInt32(result[index]);
//     index++;
// }
// Console.WriteLine(num + " -> " + summa);

