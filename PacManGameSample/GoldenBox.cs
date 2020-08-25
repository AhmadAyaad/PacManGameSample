using System;
using System.Collections.Generic;
using System.Text;

namespace PacManGameSample
{
    class GoldenBox : BoxStrategy
    {
        public override void DoMagic(int points, Player player)
        {
            IncreaseHealth(points, player);
            IncreaseWeapon(points, player);
        }

        public override bool HasKey(Player player)
        {
            if (player.Ikey is GoldenKey silver)
                return true;
            return false;
        }
        public override void IncreaseHealth(int points, Player player)
        {
            if (HasKey(player))
                if (Cell.Compare(player))
                {
                    if (player.PlayerHealth + points <= 100)
                        player.PlayerHealth += points;
                    Console.WriteLine($"Player health increase to :{player.PlayerHealth}");
                }
                else
                    Console.WriteLine("can not increase health");
        }

        private void IncreaseWeapon(int points, Player player)
        {
            if (HasKey(player))
                if (Cell.Compare(player))
                {
                    player.WeaponPower += points;
                    Console.WriteLine($"Player Wepaon Power increased to  :{player.WeaponPower}");

                }
                else
                    Console.WriteLine("can not increase weapon power");
        }
    }
}
