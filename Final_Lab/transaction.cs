using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab
{
    class transaction : account
    {
        public account sender;
        public account receiver;
        public int amount;
        public string additionalInfo;

        public account Sender
        {
            get { return sender; }
            set { sender = value; }
        }
        public account Receiver
        {
            get { return receiver; }
            set { receiver = value; }
        }
        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public String AdditionalInfo
        {
            get { return additionalInfo; }
            set { additionalInfo = value; }
        }

        public transaction()
        {
            Console.WriteLine(" Transaction Deafult.");
        }
        public transaction(account sender, account receiver, int amount, string additionalInfo)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.amount = amount;
            this.additionalInfo = additionalInfo;
        }

        override public void showInfo()
        {
            Console.WriteLine("Sender name: " + sender.accName, sender.accId);
            Console.WriteLine("Receiver name: " + receiver.accName, receiver.accId);
            Console.WriteLine("Amount amount: " + amount);
            Console.WriteLine("Additional Info: " + additionalInfo);
        }
    }
}
