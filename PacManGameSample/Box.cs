using System;
using System.Collections.Generic;
using System.Text;

namespace PacManGameSample
{
    //context
    class Box
    {
        public BoxStrategy BoxStrategy { get; set; }
        public Box(BoxStrategy strategy)
        {
            BoxStrategy = strategy;
        }

        public void DoMagic(int points, Player player)
        {
            BoxStrategy.DoMagic(points, player);
        }

    }
}
