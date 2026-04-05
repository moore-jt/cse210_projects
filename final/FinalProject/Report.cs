using System;
using System.Collections.Generic;

public class Report
{
    public DateTime ReportDate { get; set; }
    public string Title { get; set; }
    public string SummaryData { get; set; }

    public Report()
    {
        ReportDate = DateTime.Now;
    }

    public void PrintReport()
    {
        Console.WriteLine("\n==============================");
        Console.WriteLine($"REPORT: {Title}");
        Console.WriteLine($"DATE: {ReportDate.ToShortDateString()}");
        Console.WriteLine("------------------------------");
        Console.WriteLine(SummaryData);
        Console.WriteLine("==============================\n");
    }
}

public static class ReportGenerator
{
    public static Report GenerateBudgetStatus(User user)
    {
        Report report = new Report();
        report.Title = "Budget Utilization Summary";

        List<Transaction> allTransactions = new List<Transaction>();
        List<Account> userAccounts = user.GetAccounts();

        foreach (Account account in userAccounts)
        {
            allTransactions.AddRange(account.GetTransactions());
        }

        string reportDetails = "";
        List<Budget> userBudgets = user.Budgets;

        foreach (Budget budget in userBudgets)
        {
            decimal spent = budget.CalculateCurrentSpending(allTransactions);
            decimal limit = budget.Limit;
            decimal remaining = limit - spent;
            string status = budget.IsOverBudget(allTransactions) ? "!! OVER !!" : "OK";

            reportDetails += $"Category: {budget.BudgetCategory.Name}\n";
            reportDetails += $"Status: {status} | Spent: {spent:C} / {limit:C} | Remaining: {remaining:C}\n";
            reportDetails += "------------------------------\n";
        }

        report.SummaryData = string.IsNullOrEmpty(reportDetails) ? "No budget data available." : reportDetails;
        return report;
    }

    public static Report GenerateMonthlyReport(Account acc)
    {
        Report report = new Report();
        report.Title = $"Activity Report for {acc.Name}";

        decimal totalIncome = 0;
        decimal totalExpense = 0;
        List<Transaction> history = acc.GetTransactions();

        foreach (Transaction t in history)
        {
            if (t is Income)
            {
                totalIncome += t.Amount;
            }
            else if (t is Expense)
            {
                totalExpense += t.Amount;
            }
        }

        report.SummaryData = $"Account Balance: {acc.GetBalance():C}\n" +
                             $"Total Income: {totalIncome:C}\n" +
                             $"Total Expenses: {totalExpense:C}";
        
        return report;
    }
}
