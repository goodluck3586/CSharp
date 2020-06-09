/* Getter, Setter와 Properties 비교 */
public class Person_GetSet
{
    private string name;

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }
}

public class Person_Properties
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }  // value : set 접근자의 암묵적 매개변수
    }
}

class Program
{
    static void Main(string[] args)
    {
        // getter, setter 사용
        Person_GetSet p1 = new Person_GetSet();
        p1.SetName("이동윤");
        Console.WriteLine(p1.GetName());

        // properties 사용
        Person_Properties p2 = new Person_Properties();
        p2.Name = "이동윤";
        Console.WriteLine(p2.Name);
    }
}