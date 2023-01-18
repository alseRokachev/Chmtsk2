// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// Первый вариант

int answer = 0;

System.Console.Write("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());

if(numb > 99 & numb < 1000) {
answer = (numb /10) % 10;
System.Console.WriteLine($"Это число: {answer}");
} else {
    System.Console.WriteLine("Некорректное число");
}


// Второй вариант через массив


System.Console.Write("Введите число: ");

string text = Console.ReadLine();
int textLength = text.Length;

if(textLength == 3) {
System.Console.WriteLine($"Это число: {text[1]}");
} else {
    System.Console.WriteLine("Некорректное число");
}