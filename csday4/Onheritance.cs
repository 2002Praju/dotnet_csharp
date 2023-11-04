public class BankAccount
{
    protected int AccountNo;
    public string Name;
    protected decimal Balance = 0;
    protected decimal InterestRate = 0;
    public void Add(int accountNo, string name)
    {
        this.AccountNo = accountNo;
        this.Name = name;
    }
    public void Deposit(int amount)
    {
        this.Balance = this.Balance + amount;
    }
    public void Withdraw(int amount)
    {
        if (this.Balance >= amount)
            this.Balance = this.Balance - amount;
        else
            Console.WriteLine("Balance is low");
    }
    public virtual decimal CalculateInterest()
    {
        return 0;
    }
}


public class SavingAccount : BankAccount
{
    //method overriding
    public override decimal CalculateInterest()
    {
        this.InterestRate = 5.5M;
        decimal interest = (Balance * InterestRate) / 100;
        return interest;
    }
}


public class CurrentAccount : BankAccount
{


}


public class Onheritance
{
    public static void Main()
    {
        SavingAccount savingAccount = new SavingAccount();
        savingAccount.Add(101, "Mohan");
        savingAccount.Deposit(1000);
       
        decimal interest = savingAccount.CalculateInterest();
        Console.WriteLine($"Interest:{interest}");
    }
}
