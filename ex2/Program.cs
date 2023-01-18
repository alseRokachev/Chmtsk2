// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



// Первый вариант(без массива)

System.Console.WriteLine("Введите число: ");
string stringNumb1 = Console.ReadLine();
int numb1 = Convert.ToInt32(stringNumb1);
int numbLength1 = stringNumb1.Length;
int answer = numb1;
int divider = 10;

if (numbLength1 > 2)
{
    if (numbLength1 > 3)
    {
        while (answer > 1000)
        {
            answer = numb1 / divider;
            divider = divider * 10;
        }
        answer = answer % 10;
        System.Console.WriteLine($"Ответ: {answer}");
    }
    else
    {
        System.Console.WriteLine($"Ответ: {numb1 % 10}");
    }
}
else
{
    System.Console.WriteLine("Некорректное число");
}

// Второй вариант(с массивом)


System.Console.Write("Введите число: ");
string numb2 = Console.ReadLine();
int numbLength2 = numb2.Length;

if(numbLength2 > 2) {
    System.Console.WriteLine($"Это число: {numb2[2]}");
} else {
    System.Console.WriteLine("Некорректное число");
}