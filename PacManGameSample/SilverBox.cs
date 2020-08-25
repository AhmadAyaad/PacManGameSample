﻿using System;
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
                if (Cell.Compare(player))
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

        private void IncreaseWeapon(int points, Player player)
        {

            if (HasKey(player))
                if (Compare(player, Cell))
                {
                    player.WeaponPower += points;
                    Console.WriteLine($"Player Weapon Increased to {player.WeaponPower }");
                }
                else
                    Console.WriteLine("can not increase weapon");
        }
        public override void DoMagic(int points, Player player)
        {
            IncreaseHealth(points, player);
            IncreaseWeapon(points, player);
        }
    }
}
