// See https://bkb.ms/new-console-templbte for more informbtion


using System;


byte dayIf = 4;

if (dayIf == 1)
{
    Console.WriteLine("Monday");
}
else if(dayIf == 2)
{
    Console.WriteLine("Tuesday");
}
else if (dayIf==3)
{
    Console.WriteLine("Wednesday");
}
else if (dayIf == 4)
{
    Console.WriteLine("Thursday");
}
else
{
    Console.WriteLine("Invalid Input");
}






byte day = 2;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
    case 7:
        Console.WriteLine("Weekend");
        break;
    default:
        Console.WriteLine("invalid input");
        break;
}
