/* 교재 449p 예제 */
namespace Event01
{
    /* 이벤트 : 대리자를 event 한정자로 수식해서 만든다. */
    delegate void EventHandler(string message);  // 대리자 선언(클래스 밖과 안에서 모두 선언 가능)

    class MyNotifier
    {
        public event EventHandler SomethingHappend;  // 대리자의 인스턴스를 event 한정자로 수식해서 선언

        public void DoSomething(int number)
        {
            int temp = number % 10;

            if(temp != 0 && temp % 3 == 0)
                SomethingHappend(String.Format("{0} : 짝", number));  // 이벤트 발생 코드
        }
    }
    class Program
    {
        // 이벤트 핸들러(이벤트가 발생하면 실행되는 메소드)
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier(); // 이벤트를 가진 클래스의 인스턴스 생성
            notifier.SomethingHappend += new EventHandler(MyHandler);  // 이벤트 핸들러 등록

            // 이벤트 발생코드 실행
            for (int i = 0; i < 30; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}