using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._1_P2
{
    internal class Account
    {
        public double balance;

        public Account()
        {
            balance = 0;
        }
        public Account(double balance)
        {
            this.balance = balance;
        }
        public void Input()
        {
            Console.WriteLine("So tien ban dau: ");
            balance = double.Parse(Console.ReadLine());
        }
        public virtual double Deposit(double money)
        {
            return money;
            
        }
        public virtual double WithDraw(double money)
        {
            return money;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
    class SavingAccount: Account
    {
        public double rate;

        public SavingAccount(double balance, double rate) :base(balance)
        {
            this.rate = rate;
        }
        public double Interest()
        {
            return (rate * balance)/ 100; 
        }
        public void GetInterest()
        {
            Console.WriteLine("So tien lai " + Interest());
        }

    }
    class CheckAccount: Account
    {
        public double feeTransfer;

        public CheckAccount(double balance,double feeTransfer):base(balance)
        {
            this.feeTransfer = feeTransfer;
        }
    
        public override double Deposit(double money)
        {
            return money - feeTransfer;

        }
        public override double WithDraw(double money)
        {
            return money - feeTransfer;
        }
        public double GetBalance()
        {
            return balance;
        }
    }
    
}
