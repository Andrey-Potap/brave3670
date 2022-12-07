// Homework C# Lesson 2 Task 10
/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = number / 10;
int number3 = number2 % 10;
Console.WriteLine("второе число: " + number3);*/

// Homework C# Lesson 2 Task 13
/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int bignumber = number / 10;
if (number > -100 && number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else if (number > -999 && number < 999)
{
    int number3 = number % 10;
    Console.WriteLine("третья цифра: " + number3);
}
else if (number > 999)
{
    while (number > 999)
    {
        number = number / 10;
        int++;
    }
    int number3 = number % 10;
    Console.WriteLine("третья цифра: " + number3);
}*/

// Homework C# Lesson 2 Task 15
/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 0 && number < 8)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Этот день выходной");
    }
    else Console.WriteLine("Это рабочий день");
}
Console.WriteLine("Укажите значение между 1 и 7");*/