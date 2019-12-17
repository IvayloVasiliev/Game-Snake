namespace SimpleSnake
{
    using SimpleSnake.GameObjects;
    using SimpleSnake.GameObjects.Foods;
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using Utilities;
    using SimpleSnake.Core;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleWindow.CustomizeConsole();

            Wall wall = new Wall(120, 40);
            Snake snake = new Snake(wall);

            Engine engine = new Engine(snake, wall);
            engine.Run();
        }
    }
}
