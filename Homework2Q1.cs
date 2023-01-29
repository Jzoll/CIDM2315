using System;

public class Program
{
    static void Main(string[] args)
    {

     //tasks: take the user input letter grade and return the GPA points of the grade
       
       //declare GPA points
        int A = 4, B = 3, C = 2, D = 1, F = 0;
        Console.WriteLine("Please input a letter grade:");
        string UserInput = Console.ReadLine();

        //compare UserInput as string value to valid inputs and if input is valid return the GPA points
        if (UserInput == "A"){
            Console.WriteLine("GPA point: " + A);
        }

        else if (UserInput == "B"){
            Console.WriteLine("GPA point: " + B);
        }

        else if (UserInput == "C"){
            Console.WriteLine("GPA point: " + C);
        }

        else if (UserInput == "D"){
            Console.WriteLine("GPA point: " + D);
        }

        else if (UserInput == "F"){
            Console.WriteLine("GPA point: " + F);
        }

      else {
            Console.WriteLine("Wrong Letter Grade!");
        }
    }
}