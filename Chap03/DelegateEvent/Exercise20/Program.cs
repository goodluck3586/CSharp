using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 453p 연습문제 */
namespace Exercise20
{
    delegate void MyDeldgate(int a);

    class Market
    {
        public event MyDeldgate CustomerEvent;

        public void BuySomething(int CustomerNo)
        {
            if (CustomerNo == 30)
                CustomerEvent(CustomerNo);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Market market = new Market();
            market.CustomerEvent += new MyDeldgate(delegate(int num){
                    Console.WriteLine($"축하합니다. {num}번째 고객 이벤트에 당첨되셨습니다.");
            });

            for (int customerNo = 0; customerNo < 100; customerNo += 10)
                market.BuySomething(customerNo);
        }
    }
}
