//Write a C# Sharp program to print the result of dividing two numbers. 
using System;
class p3
{
    static void Main()
    {
        Console.WriteLine("Enter 1 Number = ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 2 Number = ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int div = num / num1;
        Console.WriteLine("Division is = " + div);
    }
}
