// See https://aka.ms/new-console-template for more information
using ConcurrentProject;
using System.Text.Json;

Banking banking = new Banking();
Account account = new Account();
BankingTransaction bankingTransaction = new BankingTransaction();
BankingOperation bankingOperation = new BankingOperation();
banking.CreateAccount("Divyansh", 1000);
banking.CreateAccount("Pratham", 2000);
banking.CreateAccount("Abhishek", 1000);
banking.CreateAccount("Jayprateek", 2000);
banking.CreateAccount("Divyansh", 1000);
banking.CreateAccount("Pratham", 2000);
banking.CreateAccount("Abhishek", 1000);
banking.CreateAccount("Jayprateek", 2000);

Console.WriteLine(JsonSerializer.Serialize(Account.AccountInfo));
bankingOperation.Opertaion(account, bankingTransaction);
foreach (var v in Account.AccountInfo) 
{
    Console.WriteLine(JsonSerializer.Serialize(v));
}



