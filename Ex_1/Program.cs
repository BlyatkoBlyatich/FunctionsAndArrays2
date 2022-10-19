//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int TwoDigit(int number)
{
    int des = number /10 % 10;

    return des;
}

Console.WriteLine("Input Three digit-number");
int result = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(TwoDigit(result));

