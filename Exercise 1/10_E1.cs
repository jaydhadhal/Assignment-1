/*10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of
(x+y).z and x.y + y.z.
Test Data:
Enter first number - 5
Enter second number - 6
Enter third number - 7
Expected Output:
Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72*/

using System;
class exe
{
    static void Main()
    {
        Console.WriteLine("Enter First Number ");
        int one = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number ");
        int two = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Third Number ");
        int three = Convert.ToInt32(Console.ReadLine());
        float sum1 = (one + two) * three;
        float sum2 = (one * two) + (two * three);
        Console.WriteLine("Result Of Specified Numbers {0},{1} And {2},(X+Y).z is {3} And X.Y + Y.Z is {4}",one,two,three,sum1,sum2);

    }
}