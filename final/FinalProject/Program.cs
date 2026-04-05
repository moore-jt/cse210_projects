using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string savePath = "userData.json";
        User currentUser = FileHandler.LoadUserData(savePath);

        if (currentUser == null)
        {
            currentUser = new User("Student", "student@school.edu");
            Account initialAccount = new Account("Checking");
            currentUser.AddAccount(initialAccount);
        }

        if (currentUser.GetAccounts().Count == 0)
        {
            Account initialAccount = new Account("Checking");
            currentUser.AddAccount(initialAccount);
        }
        Account mainAccount = currentUser.GetAccounts()[0];
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- BUDGETING APP MENU ---");
            Console.WriteLine($"User: {currentUser.Username} | Total Wealth: {currentUser.GetTotalBalance():C}");
            Console.WriteLine("1. Add Income");
            Console.WriteLine("2. Add Expense");
            Console.WriteLine("3. View Current Balance");
            Console.WriteLine("4. View Transaction History");
            Console.WriteLine("5. Exit & Save");
            Console.Write("Select an option: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddIncomeFlow(mainAccount);
                    break;
                case "2":
                    AddExpenseFlow(mainAccount);
                    break;
                case "3":
                    Console.WriteLine($"Current Balance: {mainAccount.GetBalance():C}");
                    break;
                case "4":
                    PrintHistory(mainAccount);
                    break;
                case "5":
                    // 2. Save data before quitting
                    FileHandler.SaveUserData(currentUser, savePath);
                    running = false;
                    Console.WriteLine("Data saved. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }


    static void AddIncomeFlow(Account account)
    {
        try
        {
            Console.Write("Enter Income Amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Source: ");
            string source = Console.ReadLine();

            Income newIncome = new Income(amount, source);
            newIncome.Description = $"Deposit from {source}";
            
            account.AddTransaction(newIncome);
        }
        catch (Exception) { Console.WriteLine("Invalid input. Amount must be a number."); }
    }

    static void AddExpenseFlow(Account account)
    {
        try
        {
            Console.Write("Enter Expense Amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Merchant: ");
            string merch = Console.ReadLine();

            Category general = new Category("General", 500.00m);
            
            Expense newExpense = new Expense(amount, general, merch);
            account.AddTransaction(newExpense);
        }
        catch (Exception) { Console.WriteLine("Invalid input. Amount must be a number."); }
    }

    static void PrintHistory(Account account)
    {
        Console.WriteLine("\n--- Transaction History ---");
        List<Transaction> history = account.GetTransactions();
        
        if (history.Count == 0)
        {
            Console.WriteLine("No transactions found.");
        }
        else
        {
            foreach (Transaction t in history)
            {
                Console.WriteLine(t.GetSummary());
            }
        }
    }
}
