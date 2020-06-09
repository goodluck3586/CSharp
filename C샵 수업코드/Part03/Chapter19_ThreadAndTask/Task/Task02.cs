/* Task<TResult> : 비동기 실행 결과의 반환값이 있는 경우 처리 */
namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 비동기 함수 생성과 시작
            var myTask = Task<List<int>>.Run(() =>
            {
                Thread.Sleep(1000);

                List<int> list = new List<int>();
                list.Add(3);
                list.Add(4);
                list.Add(5);

                return list;
            });

            myTask.Wait();  // 비동기 함수 실행이 완료될 때까지 기다림.

            foreach (var item in myTask.Result)  // myTask.Result(비동기 함수 실행결과가 담겨있음.)
                Console.Write($"{item} ");    // 3, 4, 5
            Console.WriteLine();

            // 0, 1, 2를 요소로 갖는 List<int> 생성
            var myList = new List<int>();
            myList.Add(0);
            myList.Add(1);
            myList.Add(2);
            myList.AddRange(myTask.Result);  // myList에 비동기 처리 결과인 리스트를 붙임.

            // 0, 1, 2, 3, 4, 5
            foreach (var item in myList)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}