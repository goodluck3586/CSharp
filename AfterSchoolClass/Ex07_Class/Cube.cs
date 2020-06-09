namespace Ex07_Class
{
    internal class Cube
    {
        int x, y, z;        // 멤버 인스턴스 필드(큐브의 가로, 세로, 높이 저장)
        static int countOfInstance;     // 멤버 정적 필드(생성된 큐브의 개수 저장)

        public Cube(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            countOfInstance++;
        }

        public int GetVolume()
        {
            System.Console.WriteLine("생성된 Cube의 개수" + countOfInstance);
            return x * y * z;
        }

    }
}