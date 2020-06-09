/* 491p 예제(중첩된 from문 사용) */
namespace LINQ03_doubleFrom
{
    class Class
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. 데이터 소스
            Class[] arrClass = 
            {
                new Class() {Name="연두반", Score=new int[] {99,80,70,24}},
                new Class() {Name="분홍반", Score=new int[] {60,45,87,72}},
                new Class() {Name="파랑반", Score=new int[] {92,30,85,94}},
                new Class() {Name="노랑반", Score=new int[] {90,88,0,17}}
            };

            // 2. 쿼리 만들기(반 이름, 60점 미만 점수의 무형 객체, 점수로 오름차순 정렬)
            var classes = from c in arrClass
                          from s in c.Score
                          where s < 60
                          orderby s 
                          select new { c.Name, Score=s };

            // 3. 쿼리 실행(출력)
            foreach (var item in classes)
            {
                Console.WriteLine($"낙제 : {item.Name}({item.Score})");
            }
        }
    }
}