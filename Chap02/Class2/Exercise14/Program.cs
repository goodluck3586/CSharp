using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    interface ITransactions
    {
        string ProductName { get; set; }
        DateTime TransactionDate { get; set; }
        int TransactionAmount { get; set; }

        void showTransaction();
    }

    class Transaction : ITransactions
    {
        public string ProductName { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        public int TransactionAmount { get; set; }

        public void showTransaction()
        {
            Console.WriteLine("*************** 거래 정보 ***************");
            Console.WriteLine($"ProductName: {ProductName}");
            Console.WriteLine($"TransactionDate: {TransactionDate}");
            Console.WriteLine($"TransactionAmount: {TransactionAmount}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction()
            {
                ProductName = "노트북",
                TransactionAmount = 240
            };
            t1.showTransaction();

            Transaction t2 = new Transaction()
            {
                ProductName = "데스트탑",
                TransactionDate = new DateTime(2020, 3, 1),
                TransactionAmount = 80
            };
            t2.showTransaction();
        }
    }
}
