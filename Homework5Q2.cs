using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a second integer:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a third integer:");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a fourth integer:");
        int num4 = Convert.ToInt32(Console.ReadLine());

        //call LargestNumber twice to get the largest int from the two sets of numbers from the user input
        int set1 = LargestNumber(num1,num2);
        int set2 = LargestNumber(num3,num4);
        //call LargestNumber to find the largest number from set1 and set2
        int set3 = LargestNumber(set1,set2);

        //print what the largest number is
        Console.WriteLine($"The largest number is: {set3}");
    }
    //method that takes two int and returns the largest one
    static int LargestNumber(int num1, int num2) 
    {
        if(num1<num2)
        {
            return num2;
        }
        else
        //default response but also covers if x == y
        {
            return num1;
        }
    }
}