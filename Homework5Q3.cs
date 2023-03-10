using System;

public class Program
{
    static void Main(string[] args)
    {
        createAccount();    
    }

    //check if user is older than 18
    static bool checkAge(int birth_year)    
    {
        int age = 2023 - birth_year;

        if(age >=18)
        {
            //bool is true if user is older than 18
            return true;
        }
        else
        {
            return false;
        }
    }

    //check if password == passwordReentry
    static bool checkPassword(string password, string passwordReentry)    
    {
        if(password == passwordReentry)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //creates an account
    static void createAccount()    
    {
        Console.WriteLine("Enter Your username:");
        string username = Console.ReadLine();
        Console.WriteLine("Enter Your Password:");
        string password = Console.ReadLine();
        Console.WriteLine("Enter Your Password Again:");
        string passwordReentry = Console.ReadLine();
        Console.WriteLine("Enter Your Birthyear:");
        int birth_year = Convert.ToInt32(Console.ReadLine());

        //check user age
        if (checkAge(birth_year) == true){
            //check user password if they are older than 18
            if (checkPassword(password, passwordReentry) == true)
            {
                //account creation success message
                Console.WriteLine("Account is created successfully");      
            }
            else
            {
                //password missmatch message 
                Console.WriteLine("Wrong password");
            }
        }
        //user is younger than 18, print error message
        else{
            Console.WriteLine("Could not create an account");

        }
    }
}