using System;
using ExpenseTracker.Managers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Expense Tracker Application!");

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    UserManager.Register(); // Call the Register method from the UserManager class
                    break;
                case "2":
                    UserManager.Login(); // Call the Login method from the UserManager class
                    ShowMainMenu(); // Show the main menu after successful login
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ShowMainMenu()
    {
        while (true)
        {
            Console.WriteLine("\nMain Menu:");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. Edit Expense");
            Console.WriteLine("3. View Expenses");
            Console.WriteLine("4. Delete Expense");
            Console.WriteLine("5. Logout");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ExpenseManager.AddExpense(); // Call the AddExpense method from the ExpenseManager class
                    break;
                case "2":
                    ExpenseManager.EditExpense(); // Call the EditExpense method from the ExpenseManager class
                    break;
                case "3":
                    ExpenseManager.ViewExpenses(); // Call the ViewExpenses method from the ExpenseManager class
                    break;
                case "4":
                    ExpenseManager.DeleteExpense(); // Call the DeleteExpense method from the ExpenseManager class
                    break;
                case "5":
                    return; // Return to the main menu
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

