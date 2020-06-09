/* CodeCombat*/
namespace Exercise18_Delegate
{
    class Hero
    {
        public delegate void heroMoveDelegate();
        private heroMoveDelegate movements;

        public void Addmovement(heroMoveDelegate movement)
        {
            movements += movement;
        }
        public void AddMovements(heroMoveDelegate[] movement)
        {
            foreach (var item in movement)
            {
                movements += item;
            }
        }
        public void RemoveMovement(heroMoveDelegate movement)
        {
            movements -= movement;
        }
        public void Move()
        {
            movements();
        }
    }

    class Program
    {
        static void moveRight()
        {
            Console.WriteLine("move right");
        }
        static void moveLeft()
        {
            Console.WriteLine("move left");
        }
        static void moveUp()
        {
            Console.WriteLine("move up");
        }
        static void moveDown()
        {
            Console.WriteLine("move down");
        }

        static void Main(string[] args)
        {
            Hero hero = new Hero();
            hero.Addmovement(moveRight);
            hero.Addmovement(moveUp);
            hero.Addmovement(moveRight);
            hero.Addmovement(moveDown);
            hero.Addmovement(moveRight);
            hero.Move();

            Hero hero2 = new Hero();
            hero.AddMovements(new Hero.heroMoveDelegate[] { moveRight, moveUp, moveRight, moveDown, moveRight });
            hero2.Move();
        }
    }
}