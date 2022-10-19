//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThreeDigit(int number)
{
    if(number<100)
    {
        return -1;
    }
    else
    {
        while(number>999)
        {
            number = number / 10;
        }
        number = number % 10;
        return number;
    }
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if(ThreeDigit(num) == -1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(ThreeDigit(num));    
}

