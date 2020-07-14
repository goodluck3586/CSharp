namespace Ex07_Class
{
    internal class Cube
    {
        int x, y, z;
        static int countOfInstance;

        public Cube(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

            countOfInstance++;
        }

        public int GetVolume()
        {
            System.Console.WriteLine($"생성된 큐브의 갯수 : {countOfInstance}");
            return x * y * z;
        }
    }
}