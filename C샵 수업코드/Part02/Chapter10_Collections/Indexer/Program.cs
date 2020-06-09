/* Indexer(객체를 배열처럼 사용) */

class MyList
{
    private int[] array = new int[5];

    public int this[int index]
    {
        get{ return array[index]; }
        set
        {
            if (index >= array.Length)
                Console.WriteLine("index가 범위를 벗어났습니다.");
            else
                array[index] = value;
        }
    }

    public int Length
    {
        get { return array.Length; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyList myList = new MyList();
        myList[0] = 100;
        myList[1] = 200;

        for (int i = 0; i < myList.Length; i++)
            myList[i] = (i + 1) * 100;

        for (int i = 0; i < myList.Length; i++)
            Console.WriteLine(myList[i]);
    }
}