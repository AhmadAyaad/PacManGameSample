using System;
using System.Collections.ObjectModel;
using System.Security.Cryptography;

namespace PacManGameSample
{
    public class Enemy
    {
        public int WeaponPower { get; set; } = 50;
        public Cell Cell { get; set; }
        public Enemy(Cell cell)
        {
            Cell = cell;
        }
        public int DecreaseHealth(Player player)
        {
            if (player.playerCell.Equals(Cell))
                return player.PlayerHealth = player.PlayerHealth - WeaponPower;
            else
            {
                Console.WriteLine("can not descrease heath ");
                return player.PlayerHealth;
            }
        }

    }
}