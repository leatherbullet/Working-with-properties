using System;

namespace Working_with_properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Renderer renderer = new Renderer();
            Player player = new Player(25, 10, '@');

            renderer.Draw(player.PositionX, player.PositionY, player.Simbol);
        }
    }

    class Player
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }
        public char Simbol {  get; private set; }

        public Player(int positionX, int positionY, char simbol)
        {
            PositionX = positionX;
            PositionY = positionY;
            Simbol = simbol;
        }
    }

    class Renderer
    {
        public void Draw(int x, int y, char simbol)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write(simbol);
            Console.ReadKey(true);
        }
    }
}
