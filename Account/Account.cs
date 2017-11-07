using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        private string accId;
        private string accName;
        private double balance;
        private int count = 1;

        public Account() { }
        public Account(string accName,double balance)
        {
            this.accName = accName;
            this.balance = balance;
            accIdGen();
        }
        public string AccId {
            get
            {
                return accId;
            }
        }
        public string AccName
        {
            set {
                this.accName = value;
            }
            get {
                return accName;
            }
        }
        public double Balance {
            set
            {
                this.balance = value;
            }
            get {
                return balance;
            }
        }
        public void deposit(double amount)
        {
            balance += amount;
        }
        public void withdraw(double amount)
        {
            balance -= amount;
        }
        public void accIdGen()
        {
            string month, year;
            month = DateTime.Now.ToString("MMM");
            year = DateTime.Now.Year.ToString();
            Console.WriteLine(year+"."+month+"."+count);
            count++;
        }
        public void transfer(Account a, double amount) {
            this.withdraw(amount);
            a.deposit(amount);
        }
        public void show()
        {
            Console.WriteLine("Acc name: "+accName);
            Console.WriteLine("Acc bal: " + balance);
        }
    }
}
