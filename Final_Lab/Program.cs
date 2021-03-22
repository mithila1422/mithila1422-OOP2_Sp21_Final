using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            account a1 = new account("Insana", "39411", 50000);
            account a2 = new account("Marium", "39412", 55000);
            account a3 = new account("Mithila", "39413", 60000);

            a1.Withdraw(10000);
            a2.Withdraw(5000);
            a3.Deposit(15000);
            a1.Transfer(a2, 8000);
            a1.showInfo();
            a2.showInfo();
            transaction t1 = new transaction(a1, a2, 10000, "Study perpose");
            t1.showInfo();
        }
    }
}