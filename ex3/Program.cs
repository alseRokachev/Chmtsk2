// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Введите число, обозначающее день недели: ");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb < 8 & numb > 0)
{
    if (numb == 1)
    {
        System.Console.WriteLine("Понедельник");
    }
    else if (numb == 2)
    {
        System.Console.WriteLine("Вторник");
    }
    else if (numb == 3)
    {
        System.Console.WriteLine("Среда");
    }
    else if (numb == 4)
    {
        System.Console.WriteLine("Четверг");
    }
    else if (numb == 5)
    {
        System.Console.WriteLine("Пятница");
    }
    else if (numb == 6)
    {
        System.Console.WriteLine("Суббота");
    }
    else if (numb == 7)
    {
        System.Console.WriteLine("Воскресенье");
    }
}
else
{
    System.Console.WriteLine("Некорректное число");
}