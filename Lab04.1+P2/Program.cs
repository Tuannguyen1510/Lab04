using Lab04._1_P2;

internal class Program
{
    private static void Main(string[] args)
    {
        // Account
        
        Account account = new Account();
        account.Input();
        Console.WriteLine("So tien gui:" + account.Deposit(1000));
        Console.WriteLine("So tien rut:" + account.WithDraw(2000));
        Console.WriteLine("So tien trong tai khoan la:" + (account.GetBalance() + account.Deposit(1000) - account.WithDraw(2000)));
       ;
       
        // Saving Account 
        SavingAccount sv = new SavingAccount(100000 , 20);
        sv.GetInterest();
        // CheckAcount 
        CheckAccount ck = new CheckAccount(100, 10);
        Console.WriteLine("So tien gui:" + account.Deposit(10));
        Console.WriteLine("So tien rut:" + account.WithDraw(20));
        Console.WriteLine("So tien trong tai khoan la:" + (ck.GetBalance() + ck.Deposit(10) - ck.WithDraw(20)));
    }
}