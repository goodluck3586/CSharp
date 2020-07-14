class NameCard1
{
    private string name;
    private string phoneNumber;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }
}

class NameCard2  // 자동 구현 프로퍼티
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
}

class NameCard3  // 자동 구현 프로퍼티 선언과 동시에 초기화 가능, 생성자에서 안해도 됨.
{
    public string Name { get; set; } = "Unknown";
    public string PhoneNumber { get; set; } = "000-000-0000";
}

class Program
{
    static void Main(string[] args)
    {
        NameCard1 n1 = new NameCard1();
        n1.Name = "아이유";
        n1.PhoneNumber = "010-444-4444";
        Console.WriteLine($"Name : {n1.Name}");
        Console.WriteLine($"PhoneNumber : {n1.PhoneNumber}");

        NameCard2 n2 = new NameCard2();
        n2.Name = "박보검";
        n2.PhoneNumber = "010-123-4567";
        Console.WriteLine($"Name : {n2.Name}");
        Console.WriteLine($"PhoneNumber : {n2.PhoneNumber}");

        NameCard3 n3 = new NameCard3();
        Console.WriteLine($"Name : {n3.Name}");
        Console.WriteLine($"PhoneNumber : {n3.PhoneNumber}");

        // 객체를 생성하면서 프로퍼티를 초기화할 수도 있다.
        NameCard3 n4 = new NameCard3()
        {
            Name = "박상현",
            PhoneNumber = "010-111-2222"
        };
    }
}