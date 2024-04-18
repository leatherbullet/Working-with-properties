using System;

namespace Working_with_properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(25, 10, '@');
            Renderer renderer = new Renderer();

            renderer.Draw(player);
        }
    }

    class Player
    {
        public Player(int positionX, int positionY, char simbol)
        {
            PositionX = positionX;
            PositionY = positionY;
            Simbol = simbol;
        }

        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public char Simbol { get; private set; }
    }

    class Renderer
    {
        public void Draw(Player player)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(player.PositionX, player.PositionY);
            Console.Write(player.Simbol);
            Console.ReadKey(true);
        }
    }
}
