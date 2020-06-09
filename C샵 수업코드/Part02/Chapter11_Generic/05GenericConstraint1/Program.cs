/* 형식 매개 변수 제약시키기 */
/* 교재 384p 예제 */
class StructArray<T> where T : struct  // T는 값 형식이어야 한다.
{
    public T[] Array { get; set; }
    public StructArray(int size)
    {
        Array = new T[size];
    }
}

class RefArray<T> where T : class  // T는 참조 형식이어야 한다.
{
    public T[] Array { get; set; }
    public RefArray(int size)
    {
        Array = new T[size];
    }
}

class Base { }
class Derived : Base { }
class BaseArray<U> where U : Base  // U는 명시한 기반 클래스이거나 기반 클래스의 파생 클래스여야 한다.
{
    public U[] Array { get; set; }
    public BaseArray(int size)
    {
        Array = new U[size];
    }

    public void CopyArray<T>(T[] source) where T : U  // T는 또 다른 형식 매개 변수 U로부터 상속받은 클래스여야 한다.
    {
        source.CopyTo(Array, 0);
    }
}

class Program
{
    static void Main(string[] args)
    {
        #region 값 형식, 참조 형식 제약조건
        StructArray<int> a = new StructArray<int>(3);  // T는 값 형식이어야 한다.
        a.Array[0] = 0;
        a.Array[1] = 1;
        a.Array[2] = 2;
        //StructArray<string> s = new StructArray<string>(3);  // error

        RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
        b.Array[0] = new StructArray<double>(5);
        b.Array[1] = new StructArray<double>(10);
        b.Array[2] = new StructArray<double>(15);
        //RefArray<int> i = new RefArray<int>(3);  // error
        #endregion

        BaseArray<Base> c = new BaseArray<Base>(3);
        c.Array[0] = new Base();
        c.Array[1] = new Derived();
        c.Array[2] = CreateInstance<Base>();

        BaseArray<Derived> d = new BaseArray<Derived>(2);
        d.Array[0] = new Derived();  // Base 형식은 여기에 할달 할 수 없다.
        d.Array[1] = CreateInstance<Derived>(); 

        BaseArray<Derived> e = new BaseArray<Derived>(2);
        e.CopyArray<Derived>(d.Array);
    }

    private static T CreateInstance<T>() where T : new()  // T는 매개변수가 없는 생성자가 있어야 한다.
    {
        return new T();
    }
}