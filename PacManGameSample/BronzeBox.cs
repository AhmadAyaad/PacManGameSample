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
                if (Cell.Compare(player))
                {
                    if (player.PlayerHealth + points <= 100)
                        player.PlayerHealth += points;
                    Console.WriteLine($"Player health increase to :{player.PlayerHealth}");
                }
                else
                    Console.WriteLine("can not increase health");
        }


        public override void DoMagic(int points, Player player)
        {
            IncreaseHealth(points, player);
        }


    }
}
