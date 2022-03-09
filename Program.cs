// Day7, individual task1 Ieva P.

// Task 2 Ieva P. practice

var inputdate = Console.ReadLine();
int day = Convert.ToInt32(inputdate);
Console.WriteLine($"\n Write the day number:");
Console.ReadLine();
if (day <= 0 && day > 7)
{
    Console.WriteLine("\nInvalid input!");
}
    switch (day)
    {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
            Console.WriteLine("\nIt is a working day");
            break;
        case 6:
        case 7:
            Console.WriteLine("\nIt is holiday!");
            break;
        default:
            Console.WriteLine("\nInvalid input!");
            break;
    }

//Task 1
var DayOfYear = Console.ReadLine();
int Month=1;
int Day = Convert.ToInt32(DayOfYear);
Console.WriteLine($"\n Write the day number:");
Console.ReadLine();
if (Day <= 0 && Day > 365)
{
    Console.WriteLine("\nInvalid input!");
}
if (Month >=0 && Month >12)
{
    Console.WriteLine("\nInvalid input!");
}
switch (Month)
{
    case 1:
       Day = (1 - 31);
        Console.WriteLine("\n It is January");
        break;
    case 2:
        Day = (32 - 59);
        Console.WriteLine("\n It is February");
        break;
    case 3:
        Day = (60 - 90);
        Console.WriteLine("\n It is March");
        break;
    case 4:
        Day = (91 - 120);
        Console.WriteLine("\n It is April");
        break;
    case 5:
        Day = (121 - 151);
        Console.WriteLine("\nIt is May");
        break;
    case 6:
        Day = (152 - 181);
        Console.WriteLine("\nIt is June");
        break;
    case 7:
        Day = (182 - 212);
        Console.WriteLine("\nIt is July!");
        break;
    case 8:
        Day = (213 - 243);
        Console.WriteLine("\nIt is August!");
        break;
    case 9:
        Day = (244 - 273);
        Console.WriteLine("\nIt is September!");
        break;
    case 10:
        Day = (274 - 304);
        Console.WriteLine("\nIt is October!");
        break;
    case 11:
        Day = (305 - 334);
        Console.WriteLine("\nIt is November!");
        break;
    case 12:
        Day = (335 - 365);
        Console.WriteLine("\nIt is December!");
        break;
    default:
        Console.WriteLine("\nInvalid input!");
        break;
}










