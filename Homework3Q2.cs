using System;

public class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Input an integer:");
        int num = Convert.ToInt32(Console.ReadLine());

        //outer loop creates rows
        for(int i = 0; i<num; i++)
        {
            //inner loop prints # based on user input to fill rows
            for(int m = 0; m<num; m++)
            {
            Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}