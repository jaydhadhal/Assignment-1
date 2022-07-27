/*14. Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
Test Data:
Enter the amount of celsius: 30
Expected Output:
Kelvin = 303
Fahrenheit = 86*/

using System;
class exe
{
    static void Main()
    {
        Console.WriteLine("Enter First Number ");
        float Celsius = Convert.ToInt32(Console.ReadLine());
        float Fahrenheit = (((Celsius * 9) / 5) + 32);
        float Kelvin = Celsius + 273;
        Console.WriteLine("Kelvin = {0}", Kelvin);
        Console.WriteLine("Fahrenheit = {0}", Fahrenheit);
    }
}
