// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


System.Console.WriteLine("Введите число: ");
string stringNumb = Console.ReadLine();
int numb = Convert.ToInt32(stringNumb);
int numbLength = stringNumb.Length;
int answer = numb;
int divider = 10;

if (numbLength > 2)
{
    if (numbLength > 3)
    {
        while (answer > 1000)
        {
            answer = numb / divider;
            divider = divider * 10;
        }
        answer = answer % 10;
        System.Console.WriteLine($"Ответ: {answer}");
    }
    else
    {
        System.Console.WriteLine($"Ответ: {numb % 10}");
    }
}
else
{
    System.Console.WriteLine("Некорректное число");
}




// System.Console.Write("Введите число: ");
// string numb = Console.ReadLine();
// int numbLength = numb.Length;

// if(numbLength > 2) {
//     System.Console.WriteLine($"Это число: {numb[2]}");
// } else {
//     System.Console.WriteLine("Некорректное число");
// }