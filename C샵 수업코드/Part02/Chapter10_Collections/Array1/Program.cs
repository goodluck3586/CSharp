/* 배열을 초기화하는 방법 */
namespace Collection_Array1
{
  class Program
  {
    static void Main(string[] args)
    {
      // 방법1: 코드를 읽는 사람이 파악하기 편함.
      string[] array1 = new string[3] { "안녕", "hello", "halo" };
      Console.WriteLine("array1...");
      foreach(string greeting in array1)
          Console.WriteLine($"{greeting}");

      // 방법2
      string[] array2 = new string[] { "안녕", "hello", "halo" };
      Console.WriteLine("array2...");
      foreach (string greeting in array2)
          Console.WriteLine($"{greeting}");

      // 방법3: 코드 작성이 편리함.
      string[] array3 = { "안녕", "hello", "halo" };
      Console.WriteLine("array3...");
      foreach (string greeting in array3)
          Console.WriteLine($"{greeting}");

      Console.WriteLine(array1.GetType());
      Console.WriteLine(array1.GetType().BaseType);
    }   
  }
}