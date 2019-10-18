using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 식으로 이루어진 멤버 : {}로 이루어진 멤버를 람다식으로 표현 */
/* 476p 예제 */
namespace Lambda03_ExpressionMember
{
    class FriendList
    {
        private List<string> list = new List<string>();

        public void Add(string name) => list.Add(name);
        public void Remove(string name) => list.Remove(name);
        public void PrintAll()
        {
            foreach (var s in list)
                Console.WriteLine(s);
        }

        // 생성자와 소멸자
        public FriendList() => Console.WriteLine("FriendList()");
        ~FriendList() => Console.WriteLine("~FriendList()");

        //public int Capacity => list.Capacity;  // 읽기 전용
        public int Capacity
        {
            get => list.Capacity;
            set => list.Capacity = value;
        }

        //public string this[int index] => list[index];  // 읽기 전용
        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            FriendList obj = new FriendList();
            obj.Add("Eeny");
            obj.Add("Meeny");
            obj.Add("Miny");
            obj.Remove("Eeny");
            obj.PrintAll();

            Console.WriteLine($"{obj.Capacity}");
            obj.Capacity = 10;
            Console.WriteLine($"{obj.Capacity}");

            Console.WriteLine($"{obj[0]}");
            obj[0] = "Moe";
            obj.PrintAll();
        }
    }
}
