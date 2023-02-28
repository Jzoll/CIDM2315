using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the left or right to define the shape:");
        string shape = Console.ReadLine().ToLower();

        Console.Write("N is : " + x);
        Console.WriteLine("; shape is " + shape);
    
        Option(x, shape);
    }
    static void Option(int x, string shape) 
    {
        //check "shape" and run Left or Right
        if(shape == "left"){
        Left(x, shape);
        }
        else
        {
        //if program cannot parse input for "left" default case is to run Right
        Right(x, shape);
        }
    }
    static void Left(int x, string shape) 
    {
        //Left triangle
        for(int i = 0; i < x; i++)
        {
            //Inner Loop prints * and " "
            for(int p = 0; p < x; p++)
            {
                if (p<=i)
                {
                Console.Write("*");
                }
                else
                {
                Console.Write(" ");
                }
        
            }
            Console.WriteLine();
        }
    }
    static void Right(int x, string shape) 
    {
        int m = x;
        int i = 1;
        //numberOfSpaces is countdown from num to keep track of " "
        int numberOfSpaces = m-i;

        //Outer loop is a counter and stops when i is greater than num. loop also prints new line(tab)
        for(i = 1; i <= x; i++)
        {
            //Inner loop prints spaces and then numbers according to k
            for(int p = 1; p <= x; p++)
            {
                //prints spaces
                if (p<=numberOfSpaces)
                {
                Console.Write(" ");
                }
                //prints number
                else{
                Console.Write("*");
                }
            }
            numberOfSpaces--;
            //this write line is how this is counting new lines
            Console.WriteLine();
        }
    }
}