/*12. Write a C# program to that takes a number as input and display it four times in a row
(separated by blank spaces), and then four times in the next row, with no separation. You should
do it two times: Use Console. Write and then use {0}.
Test Data:
Enter a digit: 25
Expected Output:
25 25 25 25
25252525
25 25 25 25
25252525*/

using System;
class exe
{
    static void Main()
    {

        Console.WriteLine("Enter First Number ");
        int one = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0} {0} {0} {0}", one);
        Console.WriteLine("{0}{0}{0}{0}", one);
        Console.WriteLine("{0} {0} {0} {0}", one);
        Console.WriteLine("{0}{0}{0}{0}", one);
    }
}