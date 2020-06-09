/* Collection(크기가 정해지지 않음)
 * ArrayList, List<> */

 class Program
{
    static void Main(string[] args)
    {
        #region ArrayList
        // 초기화
        ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };  // 컬렉션 초기자 사용 가능
        for (int i = 6; i <= 10; i++)  // 값 추가
            list.Add(i);

        Console.WriteLine("초기상태");
        PrintArrayList(list);

        Console.WriteLine("list.RemoveAt(2)");  // 인덱스로 제거
        list.RemoveAt(2);
        PrintArrayList(list);

        Console.WriteLine("list.Insert(2, 2)");  // 인덱스로 새로운 값 추가
        list.Insert(2, 3);
        PrintArrayList(list);

        Console.WriteLine("list.Add(\"abc\")");  // 다양한 데이터 타입 수용
        list.Add("abc");
        Console.WriteLine("list.Add(\"def\")");
        list.Add("def");
        PrintArrayList(list);
        #endregion

        #region List<>
        List<int> list2 = new List<int>() { 1, 2, 3, 4, 5 };  // 컬렉션 초기자 사용 가능
        for (int i = 6; i <= 10; i++)
        {
            list2.Add(i);
        }
        Console.WriteLine("초기상태");
        PrintList(list2);

        Console.WriteLine("list.RemoveAt(2)");
        list2.RemoveAt(2);
        PrintList(list2);

        Console.WriteLine("list.Insert(2, 2)");
        list2.Insert(2, 3);
        PrintList(list2);

        //Console.WriteLine("list.Add(\"abc\")");
        //list2.Add("abc");
        #endregion
    }

    static void PrintArrayList(ArrayList list)
    {
        foreach (var obj in list)
            Console.Write($"{obj} ");
        Console.WriteLine('\n');
    }

    static void PrintList(List<int> list)
    {
        foreach (var obj in list)
            Console.Write($"{obj} ");
        Console.WriteLine('\n');
    }
}