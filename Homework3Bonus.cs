using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Assign an int value to N:");
        int num = Convert.ToInt32(Console.ReadLine());
        int m = num;
        int i = 1;
        //numberOfSpaces is countdown from num to keep track of " "
        int numberOfSpaces = m-i;

        //Outer loop is a counter and stops when i is greater than num. loop also prints new line(tab)
        for(i = 1; i <= num; i++)
        {
            //Inner loop prints spaces and then numbers according to k
            for(int p = 1; p <= num; p++)
            {
                //prints spaces
                if (p<=numberOfSpaces)
                {
                Console.Write(" ");
                }
                //prints number
                else{
                Console.Write(i);
                }
            }
            numberOfSpaces--;
            //this write line is how this is counting new lines
            Console.WriteLine();
        }
        
    }
}