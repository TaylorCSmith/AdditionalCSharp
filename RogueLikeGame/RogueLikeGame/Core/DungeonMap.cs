using RLNET;
using RogueSharp;

namespace RogueLikeGame.Core
{
    public class DungeonMap : Map
    {
        public void Draw (RLConsole mapConsole)
        {
            mapConsole.Clear(); 
            foreach (Cell cell in GetAllCells())
            {
                SetConsoleSymbolForCell(mapConsole, cell);
            }
        }

        private void SetConsoleSymbolForCell (RLConsole console, Cell cell)
        {
            // ensures that unexplored cells are left blank
            if (!cell.IsExplored)
            {
                return; 
            }

            // when a cell is within fov, it should be lighter
            if (IsInFov(cell.X, cell.Y))
            {
                if (cell.IsWalkable)
                {
                    console.Set(cell.X, cell.Y, Color.FloorFov, Color.FloorBackgroundFov, '.');
                }
                else
                {
                    console.Set(cell.X, cell.Y, Color.WallFov, Color.WallBackgroundFov, '#');
                }
            }

            // when is a cell is outside of fov but has been explored, it should be darker
            else
            {
                if (cell.IsWalkable)
                {
                    console.Set(cell.X, cell.Y, Color.Floor, Color.FloorBackground, '.');
                }
                else
                {
                    console.Set(cell.X, cell.Y, Color.Wall, Color.WallBackground, '#');
                }
            }
        }
    }
}
