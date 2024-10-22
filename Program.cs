using System;

class Program
{
    public static void Main (string[] args)
    {
        SwitchStatements();
    }

    public static void SwitchStatements()
    {
        Console.WriteLine("Enter a number 1-10:");
        int number = int.Parse(Console.ReadLine()!);

        int x = number;
        switch (x)
        {
            case 1:
                Console.WriteLine("your number is one");
                break;
            case 2:
                Console.WriteLine("your number is two");
                break;
            case 3:
                Console.WriteLine("your number is three");
                break;
            case 4:
                Console.WriteLine("your number is four");
                break;
            case 5:
                Console.WriteLine("your number is five");
                break;
            case 6:
                Console.WriteLine("your number is six");
                break;
            case 7:
                Console.WriteLine("your number is seven");
                break;
            case 8:
                Console.WriteLine("your number is eight");
                break;
            case 9:
                Console.WriteLine("your number is nine");
                break;
            case 10:
                Console.WriteLine("your number is ten");
                break;
            default:
                Console.WriteLine("that number is not in range");
                break;
        }
    }
}
