using System;
using System.Collections.Generic;
using System.Text;

namespace PacManGameSample
{
    class Box
    {
        public BoxStrategy BoxStrategy { get; set; }
        public Box(BoxStrategy strategy)
        {
            BoxStrategy = strategy;
        }
        public void IncreaseHealth(int points, Player player)
        {
            BoxStrategy.IncreaseHealth(points, player);
        }
        public void IncreaseWeapon(int points, Player player)
        {
            BoxStrategy.IncreaseWeapon(points, player);
        }
    }
}
