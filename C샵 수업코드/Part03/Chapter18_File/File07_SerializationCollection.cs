/* 601p 예제 */
namespace File07_SerializationCollection
{
    [Serializable]
    class NameCard
    {
        public string Name;
        public string Phone;
        public int Age;

        public NameCard(string name, string phone, int age)
        {
            Name = name;
            Phone = phone;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stream ws = new FileStream("a.dat", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();

            List<NameCard> list = new List<NameCard>();
            list.Add(new NameCard("아이유", "010-444-4444", 28));
            list.Add(new NameCard("장만월", "010-444-4444", 280));
            list.Add(new NameCard("구천성", "010-999-9999", 24));

            serializer.Serialize(ws, list);
            ws.Close();

            Stream rs = new FileStream("a.dat", FileMode.Open);

            List<NameCard> list2;
            list2 = serializer.Deserialize(rs) as List<NameCard>;
            rs.Close();

            foreach (var item in list2)
            {
                Console.WriteLine($"Name: {item.Name}, Phone: {item.Phone}, Age: {item.Age}");
            }
        }
    }
}