public class Transactions
{
    // Properties (Paste here!)
    public decimal Amount { get; }
    public DateTime Date { get; }
    public string Notes { get; }


    // Constructor
    public Transactions(decimal amount, DateTime date, string note)
    {
        this.Amount = amount;
        this.Date = date;
        this.Notes = note;
    }
}