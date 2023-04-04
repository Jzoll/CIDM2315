using System;


namespace Homework7
{
    class Program
    {
        
        static void Main(string[] args)
        {
        Customer alice = new Customer(110, "Alice", 28);
        Customer bob = new Customer(111, "Bob", 30);

        alice.PrintCusInfo();
        bob.PrintCusInfo();

        alice.ChangeID(220);
        bob.ChangeID(221);

        alice.PrintCusInfo();
        bob.PrintCusInfo();

        alice.CompareAge(bob);
        }
    }

    class Customer {
        private int cus_id;
        public string cus_name;
        public int cus_age;
        
        public Customer(int cus_id, string cus_name, int cus_age){
            this.cus_id = cus_id;
            this.cus_name = cus_name;
            this.cus_age = cus_age;
        }
        
        //declaring ChangeID as an ability of the user within Customer class
        public void ChangeID(int new_id){
            this.cus_id = new_id;
        }

        public void PrintCusInfo(){
            Console.Write("Customer: {0}", cus_id);
            Console.Write(", Name: {0}",cus_name);
            Console.WriteLine(", Age: {0}", cus_age);
        }

        public void CompareAge(Customer objCustomer){
            int age = objCustomer.cus_age;
            if (age>cus_age){
            Console.WriteLine(objCustomer.cus_name + " is older");
            }
            else if (age == cus_age)
            {
            Console.WriteLine(cus_name + " is the same age as " + objCustomer.cus_name);
            }
            else
            {
            Console.WriteLine(cus_name + " is older");

            }
        }
    }
}