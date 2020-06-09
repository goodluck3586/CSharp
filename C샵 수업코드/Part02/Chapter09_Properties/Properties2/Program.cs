/* 이것이 C# 이다. 310p 예제 */
class BirthdayInfo
{
    private string name;
    private DateTime birthday;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public DateTime Birthday
    {
        get { return birthday; }
        set { birthday = value; }
    }

    public int Age  // 자동 구현 프로퍼티
    {
        get
        {
            // Subtract() : 이 인스턴스의 값에서 지정된 날짜와 시간을 뺀 새 DateTime을 반환
            // Ticks : 이 인스턴스의 날짜와 시간을 나타내는 틱 수
            return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        BirthdayInfo birth = new BirthdayInfo();
        birth.Name = "아이유";
        birth.Birthday = new DateTime(1993, 6, 28);

        Console.WriteLine($"Name : {birth.Name}");
        Console.WriteLine($"Birthday : {birth.Birthday}");
        Console.WriteLine($"Age : {birth.Age}");
    }
}