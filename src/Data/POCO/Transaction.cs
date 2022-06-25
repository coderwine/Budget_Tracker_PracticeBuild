using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Transaction : ITransaction
{
    public Transaction(){}
    public Transaction(string title)
    {
        Title = title;
    }
    public Transaction(string title, DateTime date, decimal amount, TransactionType type, Association association)
    {
        Title = title;
        Date = date;
        Amount = amount;
        Type = type;
        Association = association;
    }    

    public int ID { get; set; }
    public string Title { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public decimal Amount { get; set; }
    public TransactionType Type { get; set; }
    public string Note { get; set; }
    public string TransactionNumber { get; set; }
    public Association Association { get; set; }
}
