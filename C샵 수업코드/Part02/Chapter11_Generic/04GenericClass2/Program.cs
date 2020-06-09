/* 교재 379p 예제 */
class MyList<T>
{
    private T[] array;

    public MyList()
    {
        array = new T[3];
    }

    public T this[int index]
    {
        get { return array[index]; }
        set // 배열의 범위를 벗어난 index 요청이 오면 배열의 크기를 증가시킨다.
        {
            if (index >= array.Length)
            {
                Array.Resize<T>(ref array, index + 1);
                Console.WriteLine($"Array Resized : {array.Length}");
            }
            array[index] = value;
        }
    }

    public int Length { get { return array.Length; } }
}

class Program
{
    static void Main(string[] args)
    {
        MyList<string> str_list = new MyList<string>();
        str_list[0] = "abc";
        str_list[1] = "def";
        str_list[2] = "ghi";
        str_list[3] = "jkl";
        str_list[4] = "mno";

        for (int i = 0; i < str_list.Length; i++)
            Console.WriteLine(str_list[i]);
        Console.WriteLine('\n');

        MyList<int> int_list = new MyList<int>();
        for (int i = 0; i < 5; i++)
            int_list[i] = i;

        for (int i = 0; i < int_list.Length; i++)
            Console.WriteLine(int_list[i]);
    }
}