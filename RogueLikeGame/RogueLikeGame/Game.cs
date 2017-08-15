using RLNET;
using RogueLikeGame.Core;
using RogueLikeGame.System;

namespace RogueLikeGame
{
    public class Game
    {
        // overall screen 
        private static readonly int _screenWidth = 100;
        private static readonly int _screenHeight = 70;
        private static RLRootConsole _rootConsole;

        // map console
        private static readonly int _mapWidth = 80;
        private static readonly int _mapHeight = 48;
        private static RLConsole _mapConsole;

        // message console
        private static readonly int _messageWidth = 80;
        private static readonly int _messageHeight = 11;
        private static RLConsole _messageConsole;

        // stat console
        private static readonly int _statWidth = 20;
        private static readonly int _statHeight = 70;
        private static RLConsole _statConsole;

        // item console
        private static readonly int _inventoryWidth = 80;
        private static readonly int _inventoryHeight = 11;
        private static RLConsole _inventoryConsole;

        public static DungeonMap DungeonMap { get; private set; }

        public static void Main()
        {

            MapGenerator mapGenerator = new MapGenerator(_mapWidth, _mapHeight);
            DungeonMap = mapGenerator.CreateMap();

            string fontFileName = "terminal8x8.png";
            string consoleTitle = "RougeLikeGame - Level 1";


            _rootConsole = new RLRootConsole(fontFileName, _screenWidth, _screenHeight, 8, 8, 1f, consoleTitle);

            _mapConsole = new RLConsole(_mapWidth, _mapHeight);
            _messageConsole = new RLConsole(_messageWidth, _messageHeight);
            _statConsole = new RLConsole(_statWidth, _statHeight);
            _inventoryConsole = new RLConsole(_inventoryWidth, _inventoryHeight);

            _rootConsole.Update += OnRootConsoleUpdate;
            _rootConsole.Render += OnRootConsoleRender;
            _rootConsole.Run();
        }

        private static void OnRootConsoleUpdate(object sender, UpdateEventArgs e)
        {
            _mapConsole.SetBackColor(0, 0, _mapWidth, _mapHeight, Color.FloorBackground);
            _mapConsole.Print(1, 1, "Map", Color.TextHeading);

            _messageConsole.SetBackColor(0, 0, _messageWidth, _messageHeight, Palette.DbDeepWater);
            _messageConsole.Print(1, 1, "Messages", Color.TextHeading);

            _statConsole.SetBackColor(0, 0, _statWidth, _statHeight, Palette.DbOldStone);
            _statConsole.Print(1, 1, "Stats", Color.TextHeading);

            _inventoryConsole.SetBackColor(0, 0, _inventoryWidth, _inventoryHeight, Palette.DbWood);
            _inventoryConsole.Print(1, 1, "Inventory", Color.TextHeading);
        }

        private static void OnRootConsoleRender(object sender, UpdateEventArgs e)
        {
            RLConsole.Blit(_mapConsole, 0, 0, _mapWidth, _mapHeight, _rootConsole, 0, _inventoryHeight);
            RLConsole.Blit(_statConsole, 0, 0, _statWidth, _statHeight, _rootConsole, _mapWidth, 0);
            RLConsole.Blit(_messageConsole, 0, 0, _messageWidth, _messageHeight, _rootConsole, 0, _screenHeight - _messageHeight);
            RLConsole.Blit(_inventoryConsole, 0, 0, _inventoryWidth, _inventoryHeight, _rootConsole, 0, 0);

            DungeonMap.Draw(_mapConsole);
            _rootConsole.Draw();
        }
    }
}