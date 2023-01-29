using System;

public class Program
{
    static void Main(string[] args)
    {
        //tasks: request user input of three numbers and return smallest number

        Console.WriteLine("Please input the first num:");
        string FirstNum = Console.ReadLine();

        Console.WriteLine("Please input the second num:");
        string SecondNum = Console.ReadLine();
        
        Console.WriteLine("Please input the third num:");
        string ThirdNum = Console.ReadLine();

        //convert user input to an integer
        int FirstNumMath = Convert.ToInt16(FirstNum);
        int SecondNumMath = Convert.ToInt16(SecondNum);
        int ThirdNumMath = Convert.ToInt16(ThirdNum);

        //compare three numbers and return the smallest number
        if (FirstNumMath < SecondNumMath & FirstNumMath < ThirdNumMath){
        Console.WriteLine("The smallest value is: " + FirstNum);
        }

        else if (SecondNumMath < FirstNumMath & SecondNumMath < ThirdNumMath){
        Console.WriteLine("The smallest value is: " + SecondNum);
        }

        else {Console.WriteLine("The smallest value is: " + ThirdNum);
        }
    }
}