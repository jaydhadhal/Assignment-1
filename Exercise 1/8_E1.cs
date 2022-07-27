/*8. Write a C# Sharp program that takes a number as input and print its multiplication table.
Test Data:
Enter the number: 5
Expected Output:
5 * 0 = 0
5 * 1 = 5
5 * 2 = 10
5 * 3 = 15
....
5 * 10 = 50*/

using System;
class exe
{
    static void Main()
    {
        Console.WriteLine("Enter Number = ");
        int one = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(one+ " x " +i+ " = " +one*i);
        }

    }
}