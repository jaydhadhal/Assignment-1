/*7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and
dividing of two numbers which will be entered by the user.
Test Data:
Input the first number: 25
Input the second number: 4
Expected Output:
25 + 4 = 29
25 - 4 = 21
25 x 4 = 100
25 / 4 = 6
25 mod 4 = 1*/


using System;
class exe
{
    static void Main()
    {
        Console.WriteLine("Enter First Number");
        int one = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        int two = Convert.ToInt32(Console.ReadLine());
        int add = one + two;
        int sub = one - two;
        int mul = one * two;
        int div = one / two;
        int mod = one % two;
        Console.WriteLine("{0} + {1} = {2}", one, two, add);
        Console.WriteLine("{0} - {1} = {2}", one, two, sub);
        Console.WriteLine("{0} x {1} = {2}", one, two, mul);
        Console.WriteLine("{0} / {1} = {2}", one, two, div);
        Console.WriteLine("{0} % {1} = {2}", one, two, mod);

    }
}
