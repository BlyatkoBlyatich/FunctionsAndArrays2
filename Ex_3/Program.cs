//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool Weekends(int number)
{
    if(number== 6 || number == 7)
    {
        return true;
    }

    else
    {
        return false;
    }
}

Console.WriteLine("Введите день недели");
int day = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Weekends(day));


  
