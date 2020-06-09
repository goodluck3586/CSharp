/* delegate(메소드를 가리킬 수 있는 타입) */
class Program
{
    // 델리게이트는 메소드에 대한 참조이기 때문에 '반환 형식'과 '매개 변수'를 명시해야 한다.
    // 1. 델리게이트를 선언한다.
    delegate int MyDelegateType(int a, int b);  // delegate는 Type이다. (int, float 처럼)

    static void Main(string[] args)
    {
        int Plus(int a, int b)
        {
            return a + b;
        }

        int Minus(int a, int b)
        {
            return a - b;
        }

        // 2. 델리게이트 참조변수 생성
        MyDelegateType Callback;  // Callback : MyDelegate의 델리게이트 인스턴스

        // 3. 델리게이트의 인스턴스를 생성, 이때 델리게이트가 참조할 메소드를 매개변수로 넘긴다.
        Callback = new MyDelegateType(Plus);  // 메소드를 인자로 갖는 타입의 인스턴스 생성

        // 4. 델리게이트를 호출한다.
        Console.WriteLine(Callback(3, 5));  // Plus(3, 5)

        Callback = new MyDelegateType(Minus);
        Console.WriteLine(Callback(7, 5));  // Minus(7, 5)


        Calcultor calc = new Calcultor();
        MyDelegateType calcDelegate;  // 1. 델리게이트 참조변수 생성

        calcDelegate = new MyDelegateType(calc.Plus);  // 2. 델리게이트 인스턴스 생성(메소드 참조)
        Console.WriteLine(calcDelegate(3, 5));  // 3. 델리게이트 사용

        calcDelegate = new MyDeleMyDelegateTypegate(Calcultor.Minus);
        Console.WriteLine(calcDelegate(7, 5));

        // 델리게이트 인스턴스를 생성할 때 생성자를 사용하지 않고, 참조할 메소드명을 이용할 수 있다.
        calcDelegate = calc.Plus;
        calcDelegate += Calcultor.Minus;  // + 연산자로 델리게이트를 연결할 수 있다.
        calcDelegate(1, 2);
    }
}

class Calcultor
{
    public int Plus(int a, int b)
    {
        Console.WriteLine("Calcultor.Plus(int a, int b)");
        return a + b;
    }

    public static int Minus(int a, int b)
    {
        Console.WriteLine("Calcultor.Minus(int a, int b)");
        return a - b;
    }
}