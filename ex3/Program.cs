// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите цифру, обозначающую день недели, и проверим, является ли этот день выходным: ");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb > 0 & numb < 8)
{
    if (numb <= 5 & numb > 0)
    {
        if (numb == 1)
        {
            System.Console.WriteLine("Нет, Понедельник");
        }
        else if (numb == 2)
        {
            System.Console.WriteLine("Нет, Вторник");
        }
        else if (numb == 3)
        {
            System.Console.WriteLine("Нет, Среда");
        }
        else if (numb == 4)
        {
            System.Console.WriteLine("Нет, Четверг");
        }
        else if (numb == 5)
        {
            System.Console.WriteLine("Нет, Пятница");
        }
    }
    else
    {
        if (numb == 6)
        {
            System.Console.WriteLine("Да, Суббота");
        } else if(numb ==7) {
            System.Console.WriteLine("Да, Воскресенье");
        }
    }
}
else
{
    System.Console.WriteLine("Некорректное число");
}