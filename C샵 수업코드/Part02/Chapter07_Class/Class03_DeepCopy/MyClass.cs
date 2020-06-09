namespace Class03_Copy
{
    class MyClass
    {
        public int field1;
        public int field2;

        public MyClass ClassDeepCopy()
        {
            MyClass copyClass = new MyClass();
            copyClass.field1 = this.field1;
            copyClass.field2 = this.field2;

            return copyClass;
        }
    }
}