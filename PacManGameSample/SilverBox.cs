using System;
using System.Collections.Generic;
using System.Text;

namespace PacManGameSample
{
    class SilverBox : BoxStrategy
    {
        public override bool HasKey(Player player)
        {
            if (player.Ikey is SilverKey silver)
                return true;
            return false;
        }

        public override void IncreaseHealth(int points, Player player)
        {
            if (HasKey(player))
            {
                if (Compare(player, Cell))
                {
                    if (player.PlayerHealth + points <= 100)
                        player.PlayerHealth += points;
                    Console.WriteLine($"Player health increase to :{player.PlayerHealth}");
                }
            }
            else
            {
                Console.WriteLine("can not increase health");
            }
        }

        public override void IncreaseWeapon(int points, Player player)
        {

            if (HasKey(player))
                if (Compare(player, Cell))
                    player.WeaponPower += points;
                else
                    Console.WriteLine("can not increase weapon");
        }
    }
}
