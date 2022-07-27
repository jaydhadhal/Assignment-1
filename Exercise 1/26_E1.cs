//26.  Write a C# program to reverse the words of a sentence.
using System;
using System.Linq;

class Pro26
{
static void Main()
    {
string text = " Friend name is brij Patel";

Console.WriteLine(string.Join(" ", text.Split(' ').Reverse()));
    }
}
