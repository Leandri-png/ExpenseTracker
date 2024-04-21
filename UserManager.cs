using System;
using System.Collections.Generic;

namespace ExpenseTracker.Managers
{
    public class UserManager
    {
        private static List<User> users = new List<User>();

        public static void Register()
        {
            Console.WriteLine("User Registration:");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            
            users.Add(new User { Username = username, Password = password });
            Console.WriteLine("Registration successful!");
        }

        public static void Login()
        {
            Console.WriteLine("User Login:");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            
            User currentUser = users.Find(u => u.Username == username && u.Password == password);
            if (currentUser != null)
            {
                Console.WriteLine("Login successful!");
                // Optionally, you can return the current user or set it as a static property for future use.
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }
        }

        // Additional user management methods can be added here.
    }
}
