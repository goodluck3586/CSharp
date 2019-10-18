using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
/* 600p 예제 */
namespace File07_Serializable
{
    [Serializable]
    class NameCard
    {
        public string Name;
        public string Phone;
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stream ws = new FileStream("a.txt", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();  // 객체를 직렬화/역직렬화 하는 클래스

            NameCard nc = new NameCard();
            nc.Name = "아이유";
            nc.Phone = "010-444-4444";
            nc.Age = 28;

            serializer.Serialize(ws, nc);  // nc객체를 직렬화하여 ws FileStream 작성 
            ws.Close();

            Stream rs = new FileStream("a.txt", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();  

            NameCard nc2;
            nc2 = deserializer.Deserialize(rs) as NameCard;  // rs FileStream에서 직렬화된 데이터를 읽어와 NameCard 객체로 역직렬화
            rs.Close();

            Console.WriteLine($"Name: {nc2.Name}");
            Console.WriteLine($"Name: {nc2.Phone}");
            Console.WriteLine($"Name: {nc2.Age}");
        }
    }
}
