/* Queue(First In First Out)*/

class Program
{
    static void Main(string[] args)
    {
        #region System.Collections.Queue
        Queue q = new Queue();
        q.Enqueue(1);
        q.Enqueue(3.14);
        q.Enqueue('A');
        q.Enqueue("Queue");
        PrintQueue(q);

        // 배열을 이용한 초기화
        Object[] arr = new object[] { 1, 3.14, 'A', "Queue" };
        Queue q2 = new Queue(arr);
        PrintQueue(q2);

        Queue q3 = new Queue(new Object[]{ 1, 3.14, 'A', "Queue" });
        PrintQueue(q3);
        #endregion

        #region System.Collections.Generic.Queue<>
        Queue<int> gq = new Queue<int>();
        for (int i = 1; i <= 5; i++)
        {
            gq.Enqueue(i);
        }

        while (gq.Count > 0)
            Console.Write($"{gq.Dequeue()} ");
        Console.WriteLine('\n');
        #endregion
    }

    static void PrintQueue(Queue q)
    {
        while (q.Count > 0)
            Console.Write($"{q.Dequeue()} ");
        Console.WriteLine('\n');
    }
}