using System;

public class Program
{
//Main method takes two user input and sets it as int x and int y
static void Main(string[] args)
{
    Console.WriteLine("Enter the first number:");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number:");
    int y = Convert.ToInt32(Console.ReadLine());

    Console.Write("a = " + x);
    Console.WriteLine("; b = " + y);
    //calls compare method and applies to user defined integers
    Compare(x,y);
}
static void Compare(int x, int y)
{
    //compares x & y and prints largest value
    if(x<y)
    {
        Console.WriteLine("The largest number is: " + y);
    }
    else
    {
        Console.WriteLine("The largest number is: " + x);
    }
}
}
