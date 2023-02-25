using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Assign an int value to N:");
        int num = Convert.ToInt32(Console.ReadLine());
        //Outer loop creating rows based on user input
        for(int i = 0; i < num; i++)
        {
            //Inner Loop prints * and " "
            for(int p = 0; p < num; p++)
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
}