using System;
using System.Collections.Generic;
using System.Text;

namespace PacManGameSample.Box_Factory
{
    class GoldenBoxCreator : IBoxCreator
    {
        public BoxStrategy CreateBox()
        {
            Console.WriteLine("Golden box has been created");

            return new GoldenBox();
        }
    }
}
