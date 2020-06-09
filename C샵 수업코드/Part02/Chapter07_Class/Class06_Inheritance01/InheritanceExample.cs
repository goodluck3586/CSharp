namespace Ex01_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Study();

            UniversityStudent us1 = new UniversityStudent();
            us1.Study();

            DoStudy(s1);
            DoStudy(us1);   // vitual-override 처기가된 경우, 자식의 override되어있는 Study() 메소드가 호출된다.
        }

        static void DoStudy(Student s)
        {
            s.Study();
        }
    }

    class UniversityStudent : Student
    {
        public override void Study()    // 부모의 메소드를 재정의
        {
            Console.WriteLine("대학생이 도서관에서 공부한다.");
        }
    }

    class Student
    {
        public virtual void Study()     // 자식이 메소드를 재정의할 수 있도록 허용.
        {
            Console.WriteLine("학생이 도서관에서 공부한다.");
        }
    }
}