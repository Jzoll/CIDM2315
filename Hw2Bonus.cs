using System;
using System.Text.RegularExpressions;

public class Program
{
public static void Main(string[] args)
    {
        //Ask the user to input some number
        //If the user inputs a non-number, ask again

        //Ask the user for input until they submit a proper year
        string UserInput = "";
        int matchCount = 0;
        do {
            Console.WriteLine("Please input a year :");
            UserInput = Console.ReadLine();

            //we have the input, now validate with a regex
            Regex rx = new Regex(@"\D",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(UserInput);
            matchCount = matches.Count;
        } while (matchCount != 0);
        
        int UserInputMath = Convert.ToInt16(UserInput);

        //bools for readaboolity
        bool divisibleByFour = UserInputMath % 4 == 0;
        bool divibleByHundred = UserInputMath % 100 == 0;
        bool divibleByFourHundred = UserInputMath % 400 == 0;

        if((divisibleByFour && divibleByHundred && divibleByFourHundred)
        || (divisibleByFour && !divibleByHundred && !divibleByFourHundred)){
        Console.WriteLine(UserInput + " is a Leap Year");
        }

        else{Console.WriteLine(UserInput + " is not a Leap Year");

        }
    }
}