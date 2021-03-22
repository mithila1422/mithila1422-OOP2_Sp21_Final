using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab
{
    class account
    {
        public string AccName;
        public string AccId;
        public double AccBalance;
        public int TotalNumberOfTransaction;

        public String accName
        {
            get { return AccName; }
            set { AccName = value; }
        }
        public String accId
        {
            get { return AccId; }
            set { AccId = value; }
        }
        public double accBalance
        {
            get { return AccBalance; }
            set { AccBalance = value; }
        }
        public int totalNumberofTransaction
        {
            get { return TotalNumberOfTransaction; }
            set { TotalNumberOfTransaction = value; }
        }

        private transaction[] ListOfTransaction;

        public account()
        {
            Console.WriteLine(" Account is Default");
        }
        public account(string AccName, string AccId, double AccBalance)
        {
            accName = AccName;
            accId = AccId;
            accBalance = AccBalance;
        }

        public void Deposit(double amount)
        {
            this.AccBalance += amount;
            Console.WriteLine("Deposit successfully done." + this.AccBalance);
        }

        public void Withdraw(double amount)
        {
            if (amount <= AccBalance)
            {

                this.AccBalance -= amount;
                Console.WriteLine("Withdraw successfully done.");
            }
            else
            {
                Console.WriteLine("Insufficient Balance.");
            }
        }

        public void Transfer(account acc, double amount)
        {
            if (amount <= AccBalance)
            {

                AccBalance -= amount;
                acc.AccBalance += amount;
                Console.WriteLine("Balance transfered successfully done.");
            }
            else
            {
                Console.WriteLine("Transfer cannot be done insufficient Balance.");
            }
        }

        public void AddTransaction(transaction Transaction)
        {
            ListOfTransaction[TotalNumberOfTransaction++] = Transaction;
        }
        public void ShowAllTransactions()
        {
            for (int i = 0; i < (TotalNumberOfTransaction + 1); i++)
            {
                ListOfTransaction[i].showInfo();
            }
        }

        virtual public void showInfo()
        {
            Console.WriteLine("acc Name: " + AccName);
            Console.WriteLine("acc No: " + AccId);
            Console.WriteLine("accBalance: " + AccBalance);
        }
    }
}



