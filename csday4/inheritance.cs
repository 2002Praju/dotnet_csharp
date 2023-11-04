
public class BankAccount{
    protected int AccountNo;
    public string Name;
    public decimal Balance =0;
    public void Deposit(int amount){
        this.Balance = this.Balance + amount;
    }


    public void Withdraw(int amount){
        if(this.Balance >= amount)
            this.Balance = this.Balance - amount;
        else
            Console.WriteLine("Balance is low");
    }
}

public class SavingAccount : BankAccount{
    public decimal CalculateInterest(){
        this.InterestRates=5.5M;
        decimal interest = (Balance* InterestRate)/100;
        return interest;
    }
}

public class CurrentAccount : BankAccount{

}

public class Inheritance{
    public static void Main(){
        SavingAccount savingAccount = new SavingAccount();
        savingAccount.Add(101, "Mohan");
        decimal interest = savingAccount.CalculateInterest();
        Console.WriteLine($"Interest:{interest}");
    }
}