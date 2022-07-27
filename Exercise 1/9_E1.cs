/*9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.
Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the four number: 30
Expected Output:
The average of 10 , 15 , 20 , 30 is: 18*/
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
        Console.WriteLine("Enter Four Number ");
        int four = Convert.ToInt32(Console.ReadLine());
        double avg = (one + two + three + four)/4;
        Console.WriteLine("{0},{1},{2},{3} is  {4}", one, two, three, four, avg);




    }
}
