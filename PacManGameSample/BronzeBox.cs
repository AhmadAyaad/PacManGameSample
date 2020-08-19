using System;
using System.Collections.Generic;
using System.Text;

namespace PacManGameSample
{
    class BronzeBox : BoxStrategy
    {
        public override bool HasKey(Player player)
        {
            if (player.Ikey is BronzeKey silver)
                return true;
            return false;
        }

        public override void IncreaseHealth(int points, Player player)
        {
            if (HasKey(player))
                if (Compare(player, Cell))
                {
                    if (player.PlayerHealth + points <= 100)
                        player.PlayerHealth += points;
                    Console.WriteLine($"Player health increase to :{player.PlayerHealth}");
                }
                else
                    Console.WriteLine("can not increase health");
        }

        public override void IncreaseWeapon(int points, Player player)
        {
            player.WeaponPower += 0;
        }
    }
}
