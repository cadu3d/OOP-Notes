﻿namespace OOP_Notes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int myNum;
            myNum = 15;
            Console.WriteLine(myNum);

            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);
        }
    }
}