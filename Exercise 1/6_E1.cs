/*6. Write a C# Sharp program to print the output of multiplication of three numbers which will be
entered by the user.
Test Data:
Input the first number to multiply: 2
Input the second number to multiply: 3
Input the third number to multiply: 6
Expected Output:
2 x 3 x 6 = 36   */


using System;
class exe
{
    static void Main()
    {
        Console.WriteLine("Enter First Number");
        int one = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        int two = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Third Number");
        int third = Convert.ToInt32(Console.ReadLine());
        int sum = one * two * third;
        Console.WriteLine("{0}x{1}x{2}={3}", one, two, third, sum);
    }
}