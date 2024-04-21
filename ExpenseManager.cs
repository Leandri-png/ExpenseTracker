using System;
using System.Collections.Generic;

namespace ExpenseTracker.Managers
{
    public class ExpenseManager
    {
        private static List<Expenses> expenses = new List<Expenses>();

        public static void AddExpense()
        {
            Console.WriteLine("Add Expense:");
            Console.Write("Enter description: ");
            string description = Console.ReadLine();
            Console.Write("Enter amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            
            expenses.Add(new Expenses { Description = description, Amount = amount });
            Console.WriteLine("Expense added successfully!");
        }

        public static void EditExpense()
        {
            Console.WriteLine("Edit Expense:");
            Console.Write("Enter expense description to edit: ");
            string description = Console.ReadLine();
            Expenses expense = expenses.Find(e => e.Description == description);
            
            if (expense != null)
            {
                Console.Write("Enter new description: ");
                string newDescription = Console.ReadLine();
                Console.Write("Enter new amount: ");
                decimal newAmount = decimal.Parse(Console.ReadLine());
                
                expense.Description = newDescription;
                expense.Amount = newAmount;
                Console.WriteLine("Expense edited successfully!");
            }
            else
            {
                Console.WriteLine("Expense not found.");
            }
        }

        public static void ViewExpenses()
        {
            Console.WriteLine("View Expenses:");
            if (expenses.Count == 0)
            {
                Console.WriteLine("No expenses added yet.");
            }
            else
            {
                foreach (var expense in expenses)
                {
                    Console.WriteLine($"Description: {expense.Description}, Amount: {expense.Amount}");
                }
            }
        }

        public static void DeleteExpense()
        {
            Console.WriteLine("Delete Expense:");
            Console.Write("Enter expense description to delete: ");
            string description = Console.ReadLine();
            Expenses expense = expenses.Find(e => e.Description == description);
            
            if (expense != null)
            {
                expenses.Remove(expense);
                Console.WriteLine("Expense deleted successfully!");
            }
            else
            {
                Console.WriteLine("Expense not found.");
            }
        }
    }
}
