using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a second integer:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        //call LargestNumber and store return value as result
        int result = LargestNumber(num1,num2);
        //print the largest number
        Console.WriteLine($"The largest number is: {result}");
    }
    //method that takes two int and returns the largest one
    static int LargestNumber(int num1, int num2) 
    {
        if(num1<num2)
        {
            return num2;
        }
        else
        //default response but also covers if x ==y
        {
            return num1;
        }
    }
}