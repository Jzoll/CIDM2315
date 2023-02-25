using System;

public class Program
{
    static void Main(string[] args)
    {

        //Request user input
        Console.WriteLine("Input an integer:");
        int num = Convert.ToInt32(Console.ReadLine());
        
        //Case for the number 1
        if(num == 1){
            Console.WriteLine(num + " is non-prime");
            }

        //Testing other numbers
        for(int i = 2; i <= num/2; i++)
        {

            //non-prime case
            if(num%i==0)
            {
            Console.WriteLine(num + " is non-prime");
            break;
            }

            //prime case
            else
            {
            Console.WriteLine(num + " is prime");
            break;
            }
        }
    }
}