namespace WinForm07_ListView
{
    internal class Person
    {
        public static int idNum = 0;

        public Person()
        {
            idNum++;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string MajorWork { get; set; }

        public override string ToString()
        {
            return $"ID : {Id}\n" +
                $"Name : {Name}\n" +
                $"MajorWork : {MajorWork}";
        }
    }
}