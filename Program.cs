// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("\n\n");
short A = 82;
short B = 20;
Console.WriteLine(Math.Max(A, B));
Console.WriteLine(Math.Min(A, B));

int newA = A;
int newB = B;
Console.Write("\n\n");
Console.Write($"Check whether {A} is even or odd :\n");
Console.Write("---------------------------------------");
Console.Write("\n\n");
Console.Write("Input an integer : ");
newA = Convert.ToInt32(Console.ReadLine());
newB = newA % 2;
if (newB == 0)
    Console.WriteLine($"{A} is an even integer.\n", newA);
else
    Console.WriteLine($"{A} is an odd integer.\n", newA);
Console.Write("\n\n");
Console.Write($"Check whether {B} is even or odd :\n");
Console.Write("---------------------------------------");
Console.Write("\n\n");
Console.Write("Input an integer : ");
newB = Convert.ToInt32(Console.ReadLine());
newA = newB % 2;
if (newA == 0)
    Console.WriteLine($"{B} is an even integer.\n", newB);
else
    Console.WriteLine($"{B} is an odd integer.\n", newB);
Console.Write("\n\n");
Console.Write($"Check if {A} and {B} are equal :\n");
if (newA == newB)
    Console.WriteLine($"{A} and {B} are equal.\n");
else
    Console.WriteLine($"{A} and {B} are not equal.\n");
if (newA >= 0)
{
    if (newB >= 0)
    {
        Console.WriteLine($"{A} and {B} are positive numbers.\n");
    }
}
if (newA < 100)
{
    if (newB < 100)
    {
        Console.WriteLine($" {A} and {B} are less than 100");
    }
}
Console.Write("\n\n");

//int time = 8;
//int Day = 5;
//int Month = 11;
//int Year = 2022;

if (time < 12)
{
    Console.WriteLine("Good morning Sunshine!");
}
if (time > 13 && time < 19)
{
    Console.WriteLine("Good afternoon. Work hard.");
}
if (time > 20 && time < 24)
{
    Console.WriteLine("Good evening. Get some rest.");
}
// Day7, individual task1 Ieva P.

// Task 2 Ieva P. practice
int day = 10;

if (day <= 0 && day > 7)
{
    Console.ReadLine("Write the day number:");
}
else
{
    Console.WriteLine("Invalid input!");
}
    switch (day)
    {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
            Console.WriteLine("It is a working day");
            break;
        case 6:
        case 7:
            Console.WriteLine("It is holiday!");
            break;
        default:
            Console.WriteLine("Invalid input!");
            break;
    }

    











