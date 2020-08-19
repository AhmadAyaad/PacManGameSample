using System;
using System.Collections.Generic;
using System.Text;

namespace PacManGameSample
{
    public abstract class BoxStrategy
    {
        public Cell Cell { get; set; }
        public abstract void IncreaseHealth(int points, Player player);
        public abstract void IncreaseWeapon(int points, Player player);

        public bool Compare(Player player, Cell boxCell)
        {
            if (player.playerCell.Equals(boxCell))
                return true;
            return false;
        }
        public abstract bool HasKey(Player player);
    }
}
