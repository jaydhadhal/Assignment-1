/*13. Write a C# program that takes a number as input and then displays a rectangle of 3 columns
wide and 5 rows tall using that digit.
Test Data:
Enter a number: 5
*/

using System;
class exe
{
    static void Main()
    {
        Console.WriteLine("Enter First Number ");
        int one = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0}{0}{0}", one);
        Console.WriteLine("{0} {0}", one);
        Console.WriteLine("{0} {0}", one);
        Console.WriteLine("{0} {0}", one);
        Console.WriteLine("{0}{0}{0}", one);


    }
}
