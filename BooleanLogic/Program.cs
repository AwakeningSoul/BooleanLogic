using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {   // Prints the message "Car Insurance Application" to the console
            Console.WriteLine("Car Insurance Application");
            // Prints the message "What is your age?" to the console
            Console.WriteLine("What is your age?");
            // Reads the user's input, converts it to an integer, and stores it in the variable 'age'
            int age = Convert.ToInt32(Console.ReadLine());
            // Prints the message "Have you ever had a DUI? (Yes or No)" to the console
            Console.WriteLine("Have youever had a DUI? (Yes or No)");
            // Reads the user's input, converts it to lowercase, and stores it in the variable 'answer'
            string answer = Console.ReadLine().ToLower();
            // Checks if the user's input is "yes" and stores the result (true or false) in the variable 'dui'
            bool dui = answer == "yes";
            // Prints the message "How many speeding tickets do you have?" to the console
            Console.WriteLine("How many speeding tickets do you have?");
            // Reads the user's input, converts it to an integer, and stores it in the variable 'tickets'
            int tickets = Convert.ToInt32(Console.ReadLine());
            // Prints the message "Qualified for insurance?" to the console
            Console.WriteLine("Qualified for insurance?");
            // Evaluates if the user is qualified for insurance and stores the result (true or false) in the variable 'qualified'
            bool qualified = (age > 15) && !dui && (tickets <= 3);
            // Prints the value of 'qualified' to the console (true or false)
            Console.WriteLine(qualified);

        }
    }
}
