namespace maze_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to maze game !");
            Console.WriteLine("Use arrows to move the player..");
            Thread.Sleep(1000);

            maze maze = new maze(40, 20);
            while (true)
            {
                maze.MazeDrow();
                maze.MovePlayer();
            }


        }
    }
}