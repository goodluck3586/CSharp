using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 프로그램에서 다뤄지는 모든 데이터는 엄밀히 byte 데이터다. */
/* 직렬화(Serialization), 역직렬화(Deserialization) */
/* 직렬화: (좁은 의미) 일련의 바이트 배열로 변환하는 작업 */
namespace File04_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            /* System.BitConverter */
            // 기본 타입을 바이트 배열로 변환(직렬화)
            byte[] boolBytes = BitConverter.GetBytes(true);
            byte[] shortBytes = BitConverter.GetBytes((short)1024);
            byte[] intBytes = BitConverter.GetBytes(1024);

            // 바이트 배열을 기본 타입으로 복원(역질렬화)
            bool boolData = BitConverter.ToBoolean(boolBytes, 0);
            short shortData = BitConverter.ToInt16(shortBytes, 0);
            int intData = BitConverter.ToInt32(intBytes, 0);

            // 바이트 배열을 16진수로 출력(2진 데이터(binary data))
            Console.WriteLine(BitConverter.ToString(boolBytes));
            Console.WriteLine(BitConverter.ToString(shortBytes));
            Console.WriteLine(BitConverter.ToString(intBytes));


            /* System.IO.MemoryStream */ // Stream: 일련의 바이트를 일관성 있게 다루는 공통 기반 제공, 바이트 데이터의 흐름
            // MemoryStream: 메모리에 바이트 데이터를 순서대로 읽고 쓰는 작업을 수행하는 클래스

            // int, float 데이터를 MemoryStream에 직렬화
            MemoryStream ms = new MemoryStream();
            ms.Write(shortBytes, 0, shortBytes.Length);  // ms.Position = 2
            ms.Write(intBytes, 0, intBytes.Length);  // ms.Position = 6

            ms.Position = 0;  // Read 메서드를 역질렬화를 수행하기 위해 Position을 0으로 설정해야 한다.

            // MemoryStream으로부터 short 데이터 역질렬화
            byte[] outBytes1 = new byte[2];
            ms.Read(outBytes1, 0, 2);
            int shortResult = BitConverter.ToInt16(outBytes1, 0);
            Console.WriteLine(shortResult);

            // MemoryStream으로부터 int 데이터 역질렬화
            byte[] outBytes2 = new byte[4];
            ms.Read(outBytes2, 0, 4);
            int intResult = BitConverter.ToInt32(outBytes2, 0);
            Console.WriteLine(intResult);
            
        }
    }
}
