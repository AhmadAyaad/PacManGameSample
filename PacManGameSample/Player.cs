using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PacManGameSample
{
    public class Player
    {
        static Player _instance;
        static object syncLock = new object();
        public Cell playerCell { get; set; } = new Cell(0, 0);
        public int PlayerHealth { get; set; } = 100;
        public int WeaponPower { get; set; } = 80;
        public Map Map { get; set; }
        public Ikey Ikey { get; set; }
        public BoxStrategy BoxStrategy { get; set; }

        public static Player GetPlayer()
        {
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Player();
                    }
                }
            }

            return _instance;
        }
        public void Walk(Cell cell)
        {
            if (cell.X == playerCell.X + 1 || cell.X == playerCell.X - 1 || cell.X == playerCell.X &&
                cell.Y == playerCell.Y + 1 || cell.Y == playerCell.Y - 1 || cell.Y == playerCell.Y)
            {
                playerCell = cell;
                Console.WriteLine($"Player moved to cell : {cell}");
            }
            else
                Console.WriteLine("can not move more than one cell");
        }
      
    
    }
}
