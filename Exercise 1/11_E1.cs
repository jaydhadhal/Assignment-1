/*11. Write a C# Sharp program that takes an age (for example 20) as input and prints something
as "You look older than 20".
Test Data:
Enter your age – 25
Expected Output:
You look older than 25*/

using System;
class exe
{
    static void Main()
    {

        Console.WriteLine("Enter Your Age =");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You Look Older Than {0}", age);

    }
}