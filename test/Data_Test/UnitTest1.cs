using Xunit;

namespace Data_Test;

public class UnitTest1
{
    
    [Fact]
    public void MainTransaction_Title()
    {
        Transaction one = new Transaction();
        one.Title = "Test Input";

        string exp = "Test Input";
        string act = one.Title;

        Assert.Equal(exp, act);
    }
    
    [Fact]
    public void MainTransaction_Amount()
    {
        Transaction one = new Transaction();
        one.Amount = 1.29m;

        decimal exp = 1.29m;
        decimal act = one.Amount;

        Assert.Equal(exp, act);
    }

    [Fact]
    public void MainTransaction_Type()
    {
        Transaction one = new Transaction();
        one.Type = TransactionType.deposit;

        string exp = "deposit";
        string act = one.Type.ToString();

        Assert.Equal(exp, act);
    }

    [Fact]
    public void MainTransaction_Association()
    {
        Transaction one = new Transaction();
        Association set = new Association("Grocery");
        one.Association = set;

        string exp = "grocery";
        string act = one.Association.Title.ToLower();

        Assert.Equal(exp, act);
    }


}