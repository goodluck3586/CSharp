/* System.Threading.Tasks : 병렬 코드나 비동기 코드 작성 */
// System.Threading.Tasks.Task 클래스 : 비동기 코드 작성
namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("메인 스레드 출력1");

            // 메소드를 Action delegate 변수에 담아둔다.
            Action someAction = () =>
            {
                Console.WriteLine("비동기 함수1 시작");
                Thread.Sleep(1000);
                Console.WriteLine("비동기 함수1 종료");
            };

            /* 비동기 메소드 실행방법1 : Task 객체 생성 + Start() 메소드 */
            Task myTask1 = new Task(someAction);
            myTask1.Start();  // 생성자로 넘겨받은 무명 메소드를 비동기로 실행.

            Console.WriteLine("메인 스레드 출력2");

            /* 비동기 메소드 실행방법2 : Task.Run()로 Task의 생성과 실행을 한 번에 처리 */
            var myTask2 = Task.Run(() =>
            {
                Console.WriteLine("비동기 함수2 시작");
                Thread.Sleep(1000);
                Console.WriteLine("비동기 함수2 종료");
            });

            Console.WriteLine("메인 스레드 출력3");

            // 비동기 함수 실행을 기다리지 않으면, 메인 스레드가 끝나면 프로세스가 끝난다. 
            myTask1.Wait();  // 비동기 실행이 왼료될 때까지 기다린다.
            myTask2.Wait();

            Console.WriteLine("메인 스레드 종료");
        }
    }
}