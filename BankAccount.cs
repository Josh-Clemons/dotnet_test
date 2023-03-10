namespace Classes;

public class BankAccount {
    private static int accountNumberSeed = 1234567890;
    private List<Transaction> allTransactions = new List<Transaction>();
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance { get
        {
            decimal balance = 0;
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
            }
            return balance;
        } 
    }
    

    public BankAccount(string name, decimal initialBalance)
    {
        Owner = name;
        Number = accountNumberSeed.ToString();
        accountNumberSeed ++;
        MakeDeposit(initialBalance, DateTime.Now, "Initial Deposit");
    }

    public void MakeDeposit(decimal amount, DateTime date, string note) 
    {
        if (amount <=0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit can't be negative");
        }
        var deposit = new Transaction(amount, date, note);
        allTransactions.Add(deposit);
    }
    
    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException("Not sufficient funds for withdrawal");
        }
        var withdrawal = new Transaction(-amount, date, note);
        allTransactions.Add(withdrawal);
    }

}

