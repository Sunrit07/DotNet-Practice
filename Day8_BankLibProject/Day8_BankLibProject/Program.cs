
using Day8_BankLib;
using System;
using System.Collections.Generic;
using System.Security.Principal;

public class Program
{
    static IBankRepository bankRepository = new BankRepository();

    public static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Create New Account");
            Console.WriteLine("2. Get All Accounts");
            Console.WriteLine("3. Get Account Details");
            Console.WriteLine("4. Deposit Amount");
            Console.WriteLine("5. Withdraw Amount");
            Console.WriteLine("6. Get Transactions");
            Console.WriteLine("7. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewAccount();
                    break;
                case "2":
                    GetAllAccounts();
                    break;
                case "3":
                    GetAccountDetails();
                    break;
                case "4":
                    DepositAmount();
                    break;
                case "5":
                    WithdrawAmount();
                    break;
                case "6":
                    GetTransactions();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public static void CreateNewAccount()
    {
        var account = new SBAccount();

        Console.Write("Enter Account Number:- ");
        account.AccountNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter Customer Name:- ");
        account.CustomerName = Console.ReadLine();

        Console.Write("Enter Customer Address:- ");
        account.CustomerAddress = Console.ReadLine();

        Console.Write("Enter Initial Balance:- ");
        account.CurrentBalance = decimal.Parse(Console.ReadLine());

        try
        {
            bankRepository.NewAccount(account);
            Console.WriteLine("Account created successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public static void GetAllAccounts()
    {
        var accounts = bankRepository.GetAllAccounts();
        foreach (var account in accounts)
        {
            Console.WriteLine($"Account Number: {account.AccountNumber}, Name: {account.CustomerName}, Balance: {account.CurrentBalance}");
        }
    }

    public static void GetAccountDetails()
    {
        Console.Write("Enter Account Number: ");
        int accno = int.Parse(Console.ReadLine());

        try
        {
            var account = bankRepository.GetAccountDetails(accno);
            Console.WriteLine($"Account Number: {account.AccountNumber}, Name: {account.CustomerName}, Address: {account.CustomerAddress}, Balance: {account.CurrentBalance}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public static void DepositAmount()
    {
        Console.Write("Enter Account Number: ");
        int accno = int.Parse(Console.ReadLine());

        Console.Write("Enter Amount to Deposit: ");
        decimal amt = decimal.Parse(Console.ReadLine());

        try
        {
            bankRepository.DepositAmount(accno, amt);
            Console.WriteLine("Amount deposited successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public static void WithdrawAmount()
    {
        Console.Write("Enter Account Number: ");
        int accno = int.Parse(Console.ReadLine());

        Console.Write("Enter Amount to Withdraw: ");
        decimal amt = decimal.Parse(Console.ReadLine());

        try
        {
            bankRepository.WithdrawAmount(accno, amt);
            Console.WriteLine("Amount withdrawn successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public static void GetTransactions()
    {
        Console.Write("Enter Account Number: ");
        int accno = int.Parse(Console.ReadLine());

        var transactions = bankRepository.GetTransactions(accno);
        foreach (var transaction in transactions)
        {
            Console.WriteLine($"Transaction ID: {transaction.TransactionId}, Date: {transaction.TransactionDate}, Amount: {transaction.Amount}, Type: {transaction.TransactionType}");
        }
    }
}