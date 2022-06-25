using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public interface ITransaction
{
    public int ID { get; set; }
    public string Title { get; set; }
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public TransactionType Type { get; set; }
    public string Note { get; set; }
    public string TransactionNumber { get; set; }
    public Association Association { get; set; }
}
