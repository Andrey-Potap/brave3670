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

// Homework C# Lesson 3 Task 19
/*Console.Write("Введите число: ");
string number = Convert.ToString(Console.ReadLine());
if (number[0] == number[4] && number[1] == number[3])
{
    Console.WriteLine("Да");
}
else Console.WriteLine("Нет");*/

// Homework C# Lesson 3 Task 21
/*Console.Write("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между 2 точками в 3-D пространстве: {x1},{y1}, {x2},{y2}, {z1},{z2} = {Math.Round(distance, 2)}");*/

// Homework C# Lesson 3 Task 23
/*Console.Write("Введите число N: ");
int finish = Convert.ToInt32(Console.ReadLine());
for (int start = 1; start <= finish; start++)
{
    Console.Write(Math.Pow(start, 3) + " ");
}*/